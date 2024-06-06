using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MediaTek86.model;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permetant de gérer les données
    /// </summary>
    class GestionAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public GestionAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Contrôle si l'utilisateur est autorisé à se connecter (identifiant et mot de passe)
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns>Vrai si l'utilisateur est autorisé à se connecter</returns>
        public bool ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string query = "SELECT * FROM `responsable` WHERE login=@login AND pwd=SHA2(@pwd,256)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@login", responsable.Login },
                    { "@pwd", responsable.Pwd }
                };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(query, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return false;
        }

        //
        // PERSONNELS
        //

        /// <summary>
        /// Récupère et retourne la liste des membres du personnel
        /// </summary>
        /// <returns>Liste des membres du personnel</returns>
        public List<Personnel> GetPersonnels()
        {
            List<Personnel> personnels = new List<Personnel>();
            if (access.Manager != null)
            {
                string query = "SELECT p.idpersonnel As Id_Personnel, p.nom, p.prenom, p.tel As Telephone, p.mail, s.idservice As Id_Service, s.nom As Service FROM `personnel` p ";
                query += "JOIN `service` s ON (p.idservice = s.idservice) ORDER BY p.nom, p.prenom";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(query);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], service);

                            personnels.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return personnels;
        }

        /// <summary>
        /// Ajoute un membre du personnel
        /// </summary>
        /// <param name="personnel">Membre du personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string query = "INSERT INTO `personnel` (`nom`, `prenom`, `tel`, `mail`, `idservice`) VALUES (@nom, @prenom, @tel, @mail, @idservice)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.Idservice }
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Modifie un membre du personnel
        /// </summary>
        /// <param name="personnel">Membre du personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string query = "UPDATE `personnel` SET `nom`=@nom, `prenom`=@prenom, `tel`=@tel, `mail`=@mail, `idservice`=@idservice WHERE `idpersonnel`=@idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.Idservice },
                    { "@idpersonnel", personnel.Idpersonnel }
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Suppression d'un membre du personnel
        /// </summary>
        /// <param name="personnel">Membre à supprimer</param>
        public void DeletePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string query = "DELETE FROM `personnel` WHERE `idpersonnel`=@idpersonnel";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel },
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //
        // SERVICE
        //

        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetServices()
        {
            List<Service> services = new List<Service>();
            if (access.Manager != null)
            {
                string query = "SELECT * FROM `service`";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(query);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Service service = new Service((int)record[0], (string)record[1]);

                            services.Add(service);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return services;
        }

        //
        // ASBENCE
        //

        /// <summary>
        /// Récupère et retourne la liste des absences d'un personnel
        /// </summary>
        /// <returns>Liste des absences</returns>
        public List<Absence> GetAbsences(Personnel personnel)
        {
            List<Absence> absences = new List<Absence>();
            if (access.Manager != null)
            {
                string query = "SELECT a.datedebut As Date_Debut, a.datefin As Date_Fin, m.idmotif as Idmotif, m.libelle As Motif FROM `absence` a ";
                query += "JOIN `personnel` p ON (p.idpersonnel = a.idpersonnel) JOIN `motif` m ON (m.idmotif = a.idmotif) WHERE a.idpersonnel=@idpersonnel ORDER BY a.datedebut, a.datefin";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel }
                };

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(query, parameters);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[2], (string)record[3]);
                            Absence absence = new Absence(personnel, (DateTime)record[0], (DateTime)record[1], motif);

                            absences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return absences;
        }

        /// <summary>
        /// Ajoute une absence à un membre du personnel
        /// </summary>
        /// <param name="absence">Absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string query = "INSERT INTO `absence` (`idpersonnel`, `datedebut`, `datefin`, `idmotif`) VALUES (@idpersonnel, @datedebut, @datefin, @motif)";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@motif", absence.Motif.Idmotif }
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Modifie une absence
        /// </summary>
        /// <param name="absence">Absence à modifier</param>
        public void UpdateAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string query = "UPDATE `absence` SET `idpersonnel`=@idpersonnel, `datedebut`=@datedebut, `datefin`=@datefin, `idmotif`=@motif WHERE `idpersonnel`=@idpersonnel AND `datedebut`=@datedebut";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@motif", absence.Motif.Idmotif }
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        /// <summary>
        /// Suppression une absence
        /// </summary>
        /// <param name="absence">Absence à supprimer</param>
        public void DeleteAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string query = "DELETE FROM `absence` WHERE `idpersonnel`=@idpersonnel AND `datedebut`=@datedebut";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebut", absence.Datedebut }
                };

                try
                {
                    access.Manager.ReqUpdate(query, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //
        // MOTIF
        //

        /// <summary>
        /// Récupère et retourne la liste des motifs
        /// </summary>
        /// <returns>Liste des motifs</returns>
        public List<Motif> GetMotifs()
        {
            List<Motif> motifs = new List<Motif>();
            if (access.Manager != null)
            {
                string query = "SELECT * FROM `motif`";

                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(query);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            Motif motif = new Motif((int)record[0], (string)record[1]);

                            motifs.Add(motif);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return motifs;
        }
    }
}
