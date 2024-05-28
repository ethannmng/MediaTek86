
namespace MediaTek86
{
    partial class FormAddEditPersonnel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditPersonnel));
            this.btnUpdatePersonnel = new Krypton.Toolkit.KryptonButton();
            this.paletteSuccess = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.textFirstname = new Krypton.Toolkit.KryptonTextBox();
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.labelFirstname = new Krypton.Toolkit.KryptonLabel();
            this.labelName = new Krypton.Toolkit.KryptonLabel();
            this.textName = new Krypton.Toolkit.KryptonTextBox();
            this.labelNumber = new Krypton.Toolkit.KryptonLabel();
            this.textNumber = new Krypton.Toolkit.KryptonTextBox();
            this.labelEmail = new Krypton.Toolkit.KryptonLabel();
            this.textEmail = new Krypton.Toolkit.KryptonTextBox();
            this.labelService = new Krypton.Toolkit.KryptonLabel();
            this.comboService = new Krypton.Toolkit.KryptonComboBox();
            this.palettePrimary = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.comboService)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdatePersonnel
            // 
            this.btnUpdatePersonnel.Location = new System.Drawing.Point(36, 239);
            this.btnUpdatePersonnel.Name = "btnUpdatePersonnel";
            this.btnUpdatePersonnel.Palette = this.paletteSuccess;
            this.btnUpdatePersonnel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnUpdatePersonnel.Size = new System.Drawing.Size(267, 26);
            this.btnUpdatePersonnel.TabIndex = 0;
            this.btnUpdatePersonnel.Values.Text = "{0} le membre";
            this.btnUpdatePersonnel.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // paletteSuccess
            // 
            this.paletteSuccess.BaseFont = new System.Drawing.Font("Segoe UI", 9F);
            this.paletteSuccess.BaseFontSize = 9F;
            this.paletteSuccess.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.paletteSuccess.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Back.ColorAngle = 95F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Border.ColorAngle = 95F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.paletteSuccess.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 7F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAngle = 95F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAngle = 95F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 7F;
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.paletteSuccess.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(210)))), ((int)(((byte)(114)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(210)))), ((int)(((byte)(114)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(210)))), ((int)(((byte)(114)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(210)))), ((int)(((byte)(114)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(220)))), ((int)(((byte)(124)))));
            this.paletteSuccess.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.paletteSuccess.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.paletteSuccess.ThemeName = "";
            this.paletteSuccess.UseKryptonFileDialogs = true;
            // 
            // textFirstname
            // 
            this.textFirstname.Location = new System.Drawing.Point(36, 79);
            this.textFirstname.Name = "textFirstname";
            this.textFirstname.Size = new System.Drawing.Size(191, 31);
            this.textFirstname.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textFirstname.StateCommon.Border.Rounding = 15F;
            this.textFirstname.StateCommon.Border.Width = 0;
            this.textFirstname.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = false;
            this.labelTitle.Location = new System.Drawing.Point(29, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(404, 27);
            this.labelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 12F);
            this.labelTitle.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.labelTitle.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Values.Text = "{0} un membre dans la liste des personnels";
            // 
            // labelFirstname
            // 
            this.labelFirstname.Location = new System.Drawing.Point(36, 57);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(61, 21);
            this.labelFirstname.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelFirstname.TabIndex = 5;
            this.labelFirstname.Values.Text = "Prénom:";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(233, 57);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(107, 21);
            this.labelName.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelName.TabIndex = 6;
            this.labelName.Values.Text = "Nom de famille:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(233, 79);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(191, 31);
            this.textName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textName.StateCommon.Border.Rounding = 15F;
            this.textName.StateCommon.Border.Width = 0;
            this.textName.TabIndex = 7;
            // 
            // labelNumber
            // 
            this.labelNumber.Location = new System.Drawing.Point(36, 169);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(148, 21);
            this.labelNumber.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelNumber.TabIndex = 9;
            this.labelNumber.Values.Text = "Numéro de téléphone:";
            // 
            // textNumber
            // 
            this.textNumber.Location = new System.Drawing.Point(36, 191);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(191, 31);
            this.textNumber.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textNumber.StateCommon.Border.Rounding = 15F;
            this.textNumber.StateCommon.Border.Width = 0;
            this.textNumber.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(36, 113);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(108, 21);
            this.labelEmail.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Values.Text = "Adresse e-mail:";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(36, 135);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(388, 31);
            this.textEmail.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textEmail.StateCommon.Border.Rounding = 15F;
            this.textEmail.StateCommon.Border.Width = 0;
            this.textEmail.TabIndex = 10;
            // 
            // labelService
            // 
            this.labelService.Location = new System.Drawing.Point(233, 169);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(139, 21);
            this.labelService.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelService.TabIndex = 12;
            this.labelService.Values.Text = "Service d\'affectation:";
            // 
            // comboService
            // 
            this.comboService.DropDownWidth = 181;
            this.comboService.IntegralHeight = false;
            this.comboService.Location = new System.Drawing.Point(233, 191);
            this.comboService.Name = "comboService";
            this.comboService.Size = new System.Drawing.Size(191, 31);
            this.comboService.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.comboService.StateCommon.ComboBox.Border.Rounding = 16F;
            this.comboService.StateCommon.ComboBox.Border.Width = 0;
            this.comboService.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.comboService.TabIndex = 13;
            // 
            // palettePrimary
            // 
            this.palettePrimary.BaseFont = new System.Drawing.Font("Segoe UI", 9F);
            this.palettePrimary.BaseFontSize = 9F;
            this.palettePrimary.BasePaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.palettePrimary.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Back.ColorAngle = 95F;
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Border.ColorAngle = 95F;
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palettePrimary.ButtonStyles.ButtonCommon.OverrideDefault.Border.Rounding = 7F;
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Back.ColorAngle = 95F;
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Border.ColorAngle = 95F;
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Border.Rounding = 7F;
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.palettePrimary.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.palettePrimary.ButtonStyles.ButtonCommon.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.palettePrimary.ButtonStyles.ButtonCommon.StateTracking.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.palettePrimary.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 25F, System.Drawing.FontStyle.Bold);
            this.palettePrimary.ThemeName = "";
            this.palettePrimary.UseKryptonFileDialogs = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(309, 239);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Palette = this.palettePrimary;
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnCancel.Size = new System.Drawing.Size(115, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Values.Text = "Annuler";
            // 
            // FormAddEditPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(468, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboService);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.textNumber);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textFirstname);
            this.Controls.Add(this.btnUpdatePersonnel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditPersonnel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86 - {0} un personnel";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comboService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnUpdatePersonnel;
        private Krypton.Toolkit.KryptonTextBox textFirstname;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonLabel labelFirstname;
        private Krypton.Toolkit.KryptonLabel labelName;
        private Krypton.Toolkit.KryptonTextBox textName;
        private Krypton.Toolkit.KryptonLabel labelNumber;
        private Krypton.Toolkit.KryptonTextBox textNumber;
        private Krypton.Toolkit.KryptonLabel labelEmail;
        private Krypton.Toolkit.KryptonTextBox textEmail;
        private Krypton.Toolkit.KryptonLabel labelService;
        private Krypton.Toolkit.KryptonCustomPaletteBase paletteSuccess;
        private Krypton.Toolkit.KryptonComboBox comboService;
        private Krypton.Toolkit.KryptonCustomPaletteBase palettePrimary;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}

