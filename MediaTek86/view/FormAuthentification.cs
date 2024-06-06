using System;
using MediaTek86.controller;
using MediaTek86.model;
using System.Windows.Forms;
using MediaTek86.view.assets;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'authentification du responsable (seul le responsable devrait avoir accès au logiciel de gestion du personnel)
    /// </summary>
    public partial class FormAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormAuthentificationController controller;

        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        public FormAuthentification()
        {
            InitializeComponent();
            controller = new FormAuthentificationController();
        }

        /// <summary>
        /// Demande au contrôleur de contrôler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            string login = txtIdentifiant.Text;
            string password = txtPassword.Text;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                Responsable responsable = new Responsable(login, password);
                if (controller.ControleAuthentification(responsable))
                {
                    txtIdentifiant.Text = "";
                    txtPassword.Text = "";
                    NotificationIcon.NotifyWindows("✅ Connexion réalisé", "La connexion a été réalisé avec succès ! Bienvenue sur Mediatek86 - Gestion des membres du personnel.");
                    FormPersonnels formPersonnels = new FormPersonnels(this);
                    this.Hide();
                    formPersonnels.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Erreur: le nom d'utilisateur ou le mot de passe est incorrect", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Erreur: tous les champs doivent être remplis !", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
