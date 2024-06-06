using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view.assets;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre de gestion des absences
    /// </summary>
    public partial class FormAbsences : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormAbsencesController controller;
        /// <summary>
        /// Membre du personnel sélectionné
        /// </summary>
        private Personnel personnelSelected;

        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        internal FormAbsences(Personnel personnel)
        {
            InitializeComponent();
            personnelSelected = personnel;
            controller = new FormAbsencesController();

            labelPersonnelChoise.Text = labelPersonnelChoise.Text.Replace("{0}", personnelSelected.Prenom + " " + personnelSelected.Nom);

            FindAbsences();
        }

        /// <summary>
        /// Affiche la liste des absences du membre du personnel
        /// </summary>
        private void FindAbsences()
        {
            List<Absence> absences = controller.GetAbsences(personnelSelected);
            dgvAbsences.DataSource = absences;
            dgvAbsences.Columns["personnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Ajout d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAbsence_Click(object sender, System.EventArgs e)
        {
            FormAddEditAbsence formAddEditAbsence = new FormAddEditAbsence("ADD", personnelSelected, null);
            formAddEditAbsence.ShowDialog();
            this.FindAbsences();
        }

        /// <summary>
        /// Supprime l'absence sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteAbsence_Click(object sender, System.EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)dgvAbsences.Rows[dgvAbsences.SelectedRows[0].Index].DataBoundItem;
                if (MessageBox.Show("Voulez-vous supprimer l'absence du " + absence.Datedebut.ToString() + " au " + absence.Datefin.ToString() + " ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controller.DeleteAbsence(absence);
                    FindAbsences();
                    NotificationIcon.NotifyWindows("✅ Absence supprimé", "L'absence a été supprimé avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Erreur: vous devez sélectionner une ligne.", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Modification de l'absence sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditAbsence_Click(object sender, System.EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)dgvAbsences.Rows[dgvAbsences.SelectedRows[0].Index].DataBoundItem; ;

                FormAddEditAbsence formAddEditAbsence = new FormAddEditAbsence("EDIT", personnelSelected, absence);
                formAddEditAbsence.ShowDialog();
                this.FindAbsences();
            }
            else
            {
                MessageBox.Show("Erreur: vous devez sélectionner une ligne.", "MediaTek86 - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
