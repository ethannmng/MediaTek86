using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaTek86
{
    /// <summary>
    /// Fenêtre d'authentification du responsable (seul le responsable devrait avoir accès au logiciel de gestion du personnel)
    /// </summary>
    public partial class FormAddEditPersonnel : Form
    {
        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        public FormAddEditPersonnel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FormPersonnels personnels = new FormPersonnels();
            personnels.Show();
        }
    }
}
