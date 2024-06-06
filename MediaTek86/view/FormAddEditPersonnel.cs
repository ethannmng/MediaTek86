using System;
using System.Windows.Forms;
using MediaTek86.controller;
using MediaTek86.model;
using MediaTek86.view.assets;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'ajout et de modification des membres du personnel
    /// </summary>
    public partial class FormAddEditPersonnel : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FormAddEditPersonnelController controller;
        /// <summary>
        /// Type de modification des données
        /// </summary>
        private string TypeUpdatePersonnel;
        /// <summary>
        /// Le personnel à modifier
        /// </summary>
        private Personnel UpdatePersonnel;

        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        internal FormAddEditPersonnel(string type, Personnel personnel)
        {
            InitializeComponent();
            controller = new FormAddEditPersonnelController();
            FindServices();

            InitMethod(type, personnel);
        }

        /// <summary>
        /// Récupération des services et ajout à la combobox
        /// </summary>
        private void FindServices()
        {
            foreach (Service service in controller.GetServices())
            {
                comboService.Items.Add(service.Nom);
            }
        }

        /// <summary>
        /// Initialisation de la fenêtre de façon à correspond à l'ajout ou à la modification
        /// </summary>
        /// <param name="type"></param>
        /// <param name="personnel"></param>
        internal void InitMethod(string type, Personnel personnel)
        {
            if (type == "EDIT")
            {
                TypeUpdatePersonnel = type;
                UpdatePersonnel = personnel;

                this.Text = this.Text.Replace("{0}", "Modifier");
                labelTitle.Text = labelTitle.Text.Replace("{0}", "Modifier");
                btnUpdatePersonnel.Text = btnUpdatePersonnel.Text.Replace("{0}", "Modifier");

                textFirstname.Text = personnel.Prenom;
                textName.Text = personnel.Nom;
                textEmail.Text = personnel.Mail;
                textNumber.Text = personnel.Tel;
                comboService.SelectedIndex = personnel.Service.Idservice-1;

            }
            else if (type == "ADD")
            {
                TypeUpdatePersonnel = type;

                this.Text =  this.Text.Replace("{0}", "Ajouter");
                labelTitle.Text = labelTitle.Text.Replace("{0}", "Ajouter");
                btnUpdatePersonnel.Text = btnUpdatePersonnel.Text.Replace("{0}", "Ajouter");
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Bouton d'envoi de l'ajout ou de la modification des personnels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdatePersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmez-vous votre demande ?", "MediaTek86 - Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(textFirstname.Text) && !string.IsNullOrEmpty(textName.Text) && !string.IsNullOrEmpty(textEmail.Text) && !string.IsNullOrEmpty(textNumber.Text) && comboService.SelectedItem != null)
                {
                    Service service = new Service(comboService.SelectedIndex+1, comboService.SelectedItem.ToString());
                    

                    if (TypeUpdatePersonnel == "ADD")
                    {
                        Personnel personnel = new Personnel(0, textName.Text, textFirstname.Text, textNumber.Text, textEmail.Text, service);
                        controller.AddPersonnel(personnel);
                        NotificationIcon.NotifyWindows("✅ Ajout du membre", "Le membre " + personnel.Prenom + " " + personnel.Nom + " a été ajouté avec succès dans la liste.");
                    }
                    else // EDIT
                    {
                        Personnel personnel = new Personnel(UpdatePersonnel.Idpersonnel, textName.Text, textFirstname.Text, textNumber.Text, textEmail.Text, service);
                        controller.UpdatePersonnel(personnel);
                        NotificationIcon.NotifyWindows("✅ Modification du membre", "Le membre " + personnel.Prenom + " " + personnel.Nom + " a été modifié avec succès.");
                    }
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
