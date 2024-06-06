using MediaTek86.bddmanager;
using System;
using System.Windows.Forms;

namespace MediaTek86.dal
{
    /// <summary>
    /// Singleton: classe d'accès à BddManager.cs
    /// </summary>
    public class Access
    {
        /// <summary>
        /// nom de connexion à la bdd
        /// </summary>
        private static readonly string connectionName = "server=localhost;user id=mediatek_user;password=Admin123!!;database=mediatek86";
        /// <summary>
        /// instance unique de la classe
        /// </summary>
        private static Access instance = null;
        /// <summary>
        /// Getter sur l'objet d'accès aux données
        /// </summary>
        public BddManager Manager { get; }

        /// <summary>
        /// Création unique de l'objet de type BddManager
        /// Arrête le programme si l'accès à la BDD a échoué
        /// </summary>
        private Access()
        {
            try
            {
                Manager = BddManager.GetInstance(connectionName);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERREUR >> Impossible de se connecter à la base de données ! (Message d'erreur: " + e.Message + " )");
                MessageBox.Show("Erreur: impossible de démarrer MediaTek86. \r\n\r\nLa communication avec la base de données a échouée ! \r\nVeuillez vérifier votre connexion internet et réessayer.", "Mediatek86 - Impossible de démarrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }

        /// <summary>
        /// Création d'une seule instance de la classe
        /// </summary>
        /// <returns></returns>
        public static Access GetInstance()
        {
            if (instance == null)
            {
                instance = new Access();
            }
            return instance;
        }

    }
}
