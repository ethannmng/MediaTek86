using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre FormAbsences.cs
    /// </summary>
    class FormAbsencesController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la gestion des personnels et des absences
        /// </summary>
        private readonly GestionAccess gestionAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FormAbsencesController()
        {
            gestionAccess = new GestionAccess();
        }

        /// <summary>
        /// Récupère la liste des absences d'un membre du personnel
        /// </summary>
        /// <returns>Liste des absences du membre du personnel</returns>
        public List<Absence> GetAbsences(Personnel personnel)
        {
            return gestionAccess.GetAbsences(personnel);
        }

        /// <summary>
        /// Supprimer une absence
        /// </summary>
        /// <param name="absence">L'absence à supprimer</param>
        public void DeleteAbsence(Absence absence)
        {
            gestionAccess.DeleteAbsence(absence);
        }
    }
}
