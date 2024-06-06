using System;
using System.Collections.Generic;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre FormAddEditPersonnel.cs
    /// </summary>
    class FormAddEditPersonnelController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la gestion des personnels et des absences
        /// </summary>
        private readonly GestionAccess gestionAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FormAddEditPersonnelController()
        {
            gestionAccess = new GestionAccess();
        }

        /// <summary>
        /// Récupère la liste des services
        /// </summary>
        /// <returns>Liste des services</returns>
        public List<Service> GetServices()
        {
            return gestionAccess.GetServices();
        }

        /// <summary>
        /// Ajoute un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void AddPersonnel(Personnel personnel)
        {
            gestionAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Modifie un membre du personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void UpdatePersonnel(Personnel personnel)
        {
            gestionAccess.UpdatePersonnel(personnel);
        }
    }
}
