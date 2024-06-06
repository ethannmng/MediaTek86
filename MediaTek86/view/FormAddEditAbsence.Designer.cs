
namespace MediaTek86
{
    partial class FormAddEditAbsence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEditAbsence));
            this.btnUpdateAbsences = new Krypton.Toolkit.KryptonButton();
            this.paletteSuccess = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.labelDateStart = new Krypton.Toolkit.KryptonLabel();
            this.labelDateEnd = new Krypton.Toolkit.KryptonLabel();
            this.labelMotif = new Krypton.Toolkit.KryptonLabel();
            this.palettePrimary = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            this.dtpDateStart = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpDateEnd = new Krypton.Toolkit.KryptonDateTimePicker();
            this.comboMotif = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUpdateAbsences
            // 
            this.btnUpdateAbsences.Location = new System.Drawing.Point(36, 190);
            this.btnUpdateAbsences.Name = "btnUpdateAbsences";
            this.btnUpdateAbsences.Palette = this.paletteSuccess;
            this.btnUpdateAbsences.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnUpdateAbsences.Size = new System.Drawing.Size(267, 26);
            this.btnUpdateAbsences.TabIndex = 0;
            this.btnUpdateAbsences.Values.Text = "{0} une absence";
            this.btnUpdateAbsences.Click += new System.EventHandler(this.btnUpdateAbsences_Click);
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
            this.labelTitle.Values.Text = "{0} une absence pour {1}";
            // 
            // labelDateStart
            // 
            this.labelDateStart.Location = new System.Drawing.Point(36, 57);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(102, 21);
            this.labelDateStart.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelDateStart.TabIndex = 5;
            this.labelDateStart.Values.Text = "Date de début:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.Location = new System.Drawing.Point(233, 57);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(80, 21);
            this.labelDateEnd.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelDateEnd.TabIndex = 6;
            this.labelDateEnd.Values.Text = "Date de fin:";
            // 
            // labelMotif
            // 
            this.labelMotif.Location = new System.Drawing.Point(36, 121);
            this.labelMotif.Name = "labelMotif";
            this.labelMotif.Size = new System.Drawing.Size(125, 21);
            this.labelMotif.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins", 9F);
            this.labelMotif.TabIndex = 12;
            this.labelMotif.Values.Text = "Motif de l\'absence:";
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
            this.btnCancel.Location = new System.Drawing.Point(309, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Palette = this.palettePrimary;
            this.btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.btnCancel.Size = new System.Drawing.Size(115, 26);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Values.Text = "Annuler";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(36, 79);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(191, 31);
            this.dtpDateStart.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDateStart.StateCommon.Border.Rounding = 16F;
            this.dtpDateStart.StateCommon.Border.Width = 0;
            this.dtpDateStart.TabIndex = 15;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(233, 79);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(191, 31);
            this.dtpDateEnd.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpDateEnd.StateCommon.Border.Rounding = 16F;
            this.dtpDateEnd.StateCommon.Border.Width = 0;
            this.dtpDateEnd.TabIndex = 16;
            // 
            // comboMotif
            // 
            this.comboMotif.FormattingEnabled = true;
            this.comboMotif.Location = new System.Drawing.Point(36, 149);
            this.comboMotif.Name = "comboMotif";
            this.comboMotif.Size = new System.Drawing.Size(388, 21);
            this.comboMotif.TabIndex = 17;
            // 
            // FormAddEditAbsence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(468, 240);
            this.Controls.Add(this.comboMotif);
            this.Controls.Add(this.dtpDateEnd);
            this.Controls.Add(this.dtpDateStart);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelMotif);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnUpdateAbsences);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEditAbsence";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86 - {0} une absence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnUpdateAbsences;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonLabel labelDateStart;
        private Krypton.Toolkit.KryptonLabel labelDateEnd;
        private Krypton.Toolkit.KryptonLabel labelMotif;
        private Krypton.Toolkit.KryptonCustomPaletteBase paletteSuccess;
        private Krypton.Toolkit.KryptonCustomPaletteBase palettePrimary;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDateStart;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDateEnd;
        private System.Windows.Forms.ComboBox comboMotif;
    }
}

