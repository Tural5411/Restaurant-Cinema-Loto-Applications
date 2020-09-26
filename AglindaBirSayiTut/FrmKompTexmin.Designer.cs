namespace AglindaBirSayiTut
{
    partial class FrmKompTexmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKompTexmin));
            this.btnHe = new DevExpress.XtraEditors.SimpleButton();
            this.btnYox = new DevExpress.XtraEditors.SimpleButton();
            this.lblBildiris = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHe
            // 
            this.btnHe.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHe.Appearance.Options.UseFont = true;
            this.btnHe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnHe.Location = new System.Drawing.Point(111, 141);
            this.btnHe.Name = "btnHe";
            this.btnHe.Size = new System.Drawing.Size(199, 136);
            this.btnHe.TabIndex = 0;
            this.btnHe.Text = "HƏ";
            this.btnHe.Click += new System.EventHandler(this.btnHe_Click);
            // 
            // btnYox
            // 
            this.btnYox.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYox.Appearance.Options.UseFont = true;
            this.btnYox.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnYox.Location = new System.Drawing.Point(386, 141);
            this.btnYox.Name = "btnYox";
            this.btnYox.Size = new System.Drawing.Size(199, 136);
            this.btnYox.TabIndex = 0;
            this.btnYox.Text = "YOX";
            this.btnYox.Click += new System.EventHandler(this.btnYox_Click);
            // 
            // lblBildiris
            // 
            this.lblBildiris.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBildiris.Appearance.Options.UseFont = true;
            this.lblBildiris.Appearance.Options.UseTextOptions = true;
            this.lblBildiris.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBildiris.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblBildiris.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBildiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBildiris.Location = new System.Drawing.Point(0, 0);
            this.lblBildiris.Name = "lblBildiris";
            this.lblBildiris.Size = new System.Drawing.Size(691, 119);
            this.lblBildiris.TabIndex = 1;
            this.lblBildiris.Text = "labelControl1";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(230, 300);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(258, 104);
            this.listBoxControl1.TabIndex = 2;
            // 
            // FrmKompTexmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 430);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.lblBildiris);
            this.Controls.Add(this.btnYox);
            this.Controls.Add(this.btnHe);
            this.Name = "FrmKompTexmin";
            this.Text = "FrmKompTexmin";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnHe;
        private DevExpress.XtraEditors.SimpleButton btnYox;
        private DevExpress.XtraEditors.LabelControl lblBildiris;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}