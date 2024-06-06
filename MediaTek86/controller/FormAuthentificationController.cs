using System;
using MediaTek86.dal;
using MediaTek86.model;

namespace MediaTek86.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre FormAuthentification.cs
    /// </summary>
    class FormAuthentificationController
    {
        /// <summary>
        /// Objet d'accès aux opérations possibles sur la gestion des personnels et des absences
        /// </summary>
        private readonly GestionAccess gestionAccess;

        /// <summary>
        /// Récupère l'accès aux données
        /// </summary>
        public FormAuthentificationController()
        {
            gestionAccess = new GestionAccess();
        }

        /// <summary>
        /// Vérifie l'authentification de l'utilisateur
        /// </summary>
        /// <param name="responsable">Objet qui contient les informations de connexion</param>
        /// <returns>Vrai si l'utilisateur est autorisé à se connecter</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            return gestionAccess.ControleAuthentification(responsable);
        }
    }
}
