using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view.assets;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre de gestion des membres du personnel
    /// </summary>
    public partial class FormPersonnels : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormPersonnelsController controller;

        /// <summary>
        /// Formulaire d'origine
        /// </summary>
        private FormAuthentification formOrigin;

        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        public FormPersonnels(FormAuthentification origin)
        {
            InitializeComponent();
            formOrigin = origin;

            controller = new FormPersonnelsController();
            FindPersonnels();
        }

        /// <summary>
        /// Affiche la liste des personnels
        /// </summary>
        private void FindPersonnels()
        {
            List<Personnel> lesPersonnels = controller.GetPersonnels();
            dgvPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Ajout d'un membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPersonnel_Click(object sender, EventArgs e)
        {
            FormAddEditPersonnel formAddEditPersonnel = new FormAddEditPersonnel("ADD", null);
            formAddEditPersonnel.ShowDialog();
            this.FindPersonnels();
        }

        /// <summary>
        /// Supprime le membre du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeletePersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvPersonnels.Rows[dgvPersonnels.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show("Voulez-vous supprimer " + personnel.Prenom + " " + personnel.Nom.ToUpper() + " ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controller.DeletePersonnel(personnel);
                    FindPersonnels();
                    NotificationIcon.NotifyWindows("✅ Membre supprimé", "Le membre a été supprimé avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Erreur: vous devez sélectionner une ligne.", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modification du membre du personnel choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvPersonnels.Rows[dgvPersonnels.SelectedRows[0].Index].DataBoundItem;

                FormAddEditPersonnel formAddEditPersonnel = new FormAddEditPersonnel("EDIT", personnel);
                formAddEditPersonnel.ShowDialog();
                this.FindPersonnels();
            }
            else
            {
                MessageBox.Show("Erreur: vous devez sélectionner une ligne.", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Affichage de la liste des absences du membre du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGestAbsPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnels.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)dgvPersonnels.Rows[dgvPersonnels.SelectedRows[0].Index].DataBoundItem;

                FormAbsences formAbsences = new FormAbsences(personnel);
                formAbsences.ShowDialog();
                this.FindPersonnels();
            }
            else
            {
                MessageBox.Show("Erreur: vous devez sélectionner une ligne.", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Demande la confirmation de fermeture (déconnexion)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vous déconnecter ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Notification de déconnexion et affichage du formulaire de connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormPersonnels_FormClosed(object sender, FormClosedEventArgs e)
        {
            NotificationIcon.NotifyWindows("ℹ️ Vous avez été déconnecté", "Suite à la fermeture du panneau de gestion, vous avez été déconnecté !");
            formOrigin.Show();
        }
    }
}
