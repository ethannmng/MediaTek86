﻿using System;
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
    public partial class FormAuthentification : Form
    {
        /// <summary>
        /// Construction des composants graphiques
        /// </summary>
        public FormAuthentification()
        {
            InitializeComponent();
        }
    }
}
