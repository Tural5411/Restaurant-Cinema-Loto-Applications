namespace AglindaBirSayiTut
{
    partial class FrmMenTexminEdim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBildiris = new DevExpress.XtraEditors.LabelControl();
            this.txtMenTexmin = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenTexmin.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBildiris
            // 
            this.lblBildiris.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBildiris.Appearance.Options.UseFont = true;
            this.lblBildiris.Appearance.Options.UseTextOptions = true;
            this.lblBildiris.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBildiris.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBildiris.Location = new System.Drawing.Point(104, 92);
            this.lblBildiris.Name = "lblBildiris";
            this.lblBildiris.Size = new System.Drawing.Size(489, 99);
            this.lblBildiris.TabIndex = 2;
            this.lblBildiris.Text = "Ağlında bir sayı tut oyunu";
            this.lblBildiris.Visible = false;
            // 
            // txtMenTexmin
            // 
            this.txtMenTexmin.Location = new System.Drawing.Point(12, 40);
            this.txtMenTexmin.Name = "txtMenTexmin";
            this.txtMenTexmin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMenTexmin.Properties.Appearance.Options.UseFont = true;
            this.txtMenTexmin.Size = new System.Drawing.Size(683, 46);
            this.txtMenTexmin.TabIndex = 3;
            this.txtMenTexmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMenTexmin_KeyDown);
            // 
            // FrmMenTexminEdim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 264);
            this.Controls.Add(this.txtMenTexmin);
            this.Controls.Add(this.lblBildiris);
            this.Name = "FrmMenTexminEdim";
            this.Text = "FrmMenTexminEdim";
            ((System.ComponentModel.ISupportInitialize)(this.txtMenTexmin.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBildiris;
        private DevExpress.XtraEditors.TextEdit txtMenTexmin;
    }
}