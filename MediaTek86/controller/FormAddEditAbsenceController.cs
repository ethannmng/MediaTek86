using System;
using System.Collections.Generic;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre FormAddEditAbsence.cs
    /// </summary>
    class FormAddEditAbsenceController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la gestion des personnels et des absences
        /// </summary>
        private readonly GestionAccess gestionAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FormAddEditAbsenceController()
        {
            gestionAccess = new GestionAccess();
        }

        /// <summary>
        /// Récupère la liste des motifs
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Motif> GetMotifs()
        {
            return gestionAccess.GetMotifs();
        }

        /// <summary>
        /// Ajoute une absence
        /// </summary>
        /// <param name="absence"></param>
        public void AddAbsence(Absence absence)
        {
            gestionAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Modifie une absence
        /// </summary>
        /// <param name="absence"></param>
        public void UpdateAbsence(Absence absence)
        {
            gestionAccess.UpdateAbsence(absence);
        }
    }
}
