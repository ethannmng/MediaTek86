using System;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view.assets;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'ajout et de modification des absences
    /// </summary>
    public partial class FormAddEditAbsence : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormAddEditAbsenceController controller;
        /// <summary>
        /// Type de modification des données
        /// </summary>
        private string TypeUpdateAbsence;

        /// <summary>
        /// Le personnel sélectionné
        /// </summary>
        private Personnel personnel;
        /// <summary>
        /// L'absence à modifier
        /// </summary>
        private Absence UpdateAbsence;

        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        internal FormAddEditAbsence(string type, Personnel personnel, Absence absence)
        {
            InitializeComponent();
            controller = new FormAddEditAbsenceController();
            FindServices();

            this.personnel = personnel;

            InitMethod(type, absence);
        }

        /// <summary>
        /// Récupération des motifs et ajout à la combobox
        /// </summary>
        private void FindServices()
        {
            foreach (Motif motif in controller.GetMotifs())
            {
                comboMotif.Items.Add(motif.Libelle);
            }
        }

        /// <summary>
        /// Initialisation de la fenêtre de façon à correspond à l'ajout ou à la modification
        /// </summary>
        /// <param name="type"></param>
        /// <param name="absence"></param>
        internal void InitMethod(string type, Absence absence)
        {
            if (type == "EDIT")
            {
                TypeUpdateAbsence = type;
                UpdateAbsence = absence;

                this.Text = this.Text.Replace("{0}", "Modifier");
                labelTitle.Text = labelTitle.Text.Replace("{0}", "Modifier");
                labelTitle.Text = labelTitle.Text.Replace("{1}", absence.Personnel.Prenom + " " + absence.Personnel.Nom);
                btnUpdateAbsences.Text = btnUpdateAbsences.Text.Replace("{0}", "Modifier");

                dtpDateStart.Value = absence.Datedebut;
                dtpDateEnd.Value = absence.Datefin;
                comboMotif.SelectedIndex = absence.Motif.Idmotif - 1;
            }
            else if (type == "ADD")
            {
                TypeUpdateAbsence = type;

                this.Text = this.Text.Replace("{0}", "Ajouter");
                labelTitle.Text = labelTitle.Text.Replace("{0}", "Ajouter");
                labelTitle.Text = labelTitle.Text.Replace("{1}", personnel.Prenom + " " + personnel.Nom);
                btnUpdateAbsences.Text = btnUpdateAbsences.Text.Replace("{0}", "Ajouter");
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Bouton d'envoi de l'ajout ou de la modification de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateAbsences_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous votre demande ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dtpDateStart.Value < dtpDateEnd.Value && comboMotif.SelectedIndex != -1)
                {
                    Motif motif = new Motif(comboMotif.SelectedIndex+1, comboMotif.SelectedItem.ToString());
                    Absence absence = new Absence(personnel, dtpDateStart.Value, dtpDateEnd.Value, motif);

                    if (TypeUpdateAbsence == "ADD")
                    {
                        controller.AddAbsence(absence);
                        NotificationIcon.NotifyWindows("✅ Ajout de l'absence", "L'absence a été ajouté avec succès dans la liste.");
                    }
                    else // EDIT
                    {
                        controller.UpdateAbsence(absence);
                        NotificationIcon.NotifyWindows("✅ Modification de l'absence", "L'absence a été modifié avec succès.");
                    }
                }
                else
                {
                    NotificationIcon.NotifyWindows("❌ Impossible de valider votre action", "Tous les champs n'ont pas été remplis ou la période n'est pas correcte.");
                }
                this.Close();
            }
        }

        /// <summary>
        /// Demande la confirmation d'annulation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler la demande en cours ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
