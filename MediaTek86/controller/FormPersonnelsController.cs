using MediaTek86.dal;
using MediaTek86.model;
using System.Collections.Generic;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre FormPersonnels.cs
    /// </summary>
    class FormPersonnelsController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la gestion des personnels et des absences
        /// </summary>
        private readonly GestionAccess gestionAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FormPersonnelsController()
        {
            gestionAccess = new GestionAccess();
        }

        /// <summary>
        /// Récupère la liste des membres du personnel
        /// </summary>
        /// <returns>Liste des membres du personnel</returns>
        public List<Personnel> GetPersonnels()
        {
            return gestionAccess.GetPersonnels();
        }

        /// <summary>
        /// Supprimer un membre du personnel
        /// </summary>
        /// <param name="personnel">Le membre à supprimer</param>
        public void DeletePersonnel(Personnel personnel)
        {
            gestionAccess.DeletePersonnel(personnel);
        }
    }
}
