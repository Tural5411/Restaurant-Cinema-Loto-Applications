namespace AglindaBirSayiTut
{
    partial class Form1
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
            this.btnMenTexminEdim = new DevExpress.XtraEditors.SimpleButton();
            this.btnKompTexminEt = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtsay1 = new DevExpress.XtraEditors.TextEdit();
            this.txtSay2 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtsay1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSay2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenTexminEdim
            // 
            this.btnMenTexminEdim.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenTexminEdim.Appearance.Options.UseFont = true;
            this.btnMenTexminEdim.Appearance.Options.UseTextOptions = true;
            this.btnMenTexminEdim.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnMenTexminEdim.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnMenTexminEdim.Location = new System.Drawing.Point(73, 144);
            this.btnMenTexminEdim.Name = "btnMenTexminEdim";
            this.btnMenTexminEdim.Size = new System.Drawing.Size(254, 193);
            this.btnMenTexminEdim.TabIndex = 0;
            this.btnMenTexminEdim.Text = "Mən Təxmin\r\nEdim";
            this.btnMenTexminEdim.Click += new System.EventHandler(this.btnMenTexminEdim_Click);
            // 
            // btnKompTexminEt
            // 
            this.btnKompTexminEt.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKompTexminEt.Appearance.Options.UseFont = true;
            this.btnKompTexminEt.Appearance.Options.UseTextOptions = true;
            this.btnKompTexminEt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.btnKompTexminEt.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.btnKompTexminEt.Location = new System.Drawing.Point(439, 144);
            this.btnKompTexminEt.Name = "btnKompTexminEt";
            this.btnKompTexminEt.Size = new System.Drawing.Size(254, 193);
            this.btnKompTexminEt.TabIndex = 0;
            this.btnKompTexminEt.Text = "Komputer Təxmin\r\nEtsin";
            this.btnKompTexminEt.Click += new System.EventHandler(this.btnKompTexminEt_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(152, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(489, 99);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ağlında bir sayı tut oyunu";
            // 
            // txtsay1
            // 
            this.txtsay1.Location = new System.Drawing.Point(73, 378);
            this.txtsay1.Name = "txtsay1";
            this.txtsay1.Properties.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.txtsay1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsay1.Properties.Appearance.Options.UseBackColor = true;
            this.txtsay1.Properties.Appearance.Options.UseFont = true;
            this.txtsay1.Properties.Mask.EditMask = "n0";
            this.txtsay1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtsay1.Size = new System.Drawing.Size(254, 40);
            this.txtsay1.TabIndex = 2;
            // 
            // txtSay2
            // 
            this.txtSay2.Location = new System.Drawing.Point(439, 378);
            this.txtSay2.Name = "txtSay2";
            this.txtSay2.Properties.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.txtSay2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSay2.Properties.Appearance.Options.UseBackColor = true;
            this.txtSay2.Properties.Appearance.Options.UseFont = true;
            this.txtSay2.Properties.Mask.EditMask = "n0";
            this.txtSay2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSay2.Size = new System.Drawing.Size(254, 40);
            this.txtSay2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(362, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "ilə";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSay2);
            this.Controls.Add(this.txtsay1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnKompTexminEt);
            this.Controls.Add(this.btnMenTexminEdim);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txtsay1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSay2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnMenTexminEdim;
        private DevExpress.XtraEditors.SimpleButton btnKompTexminEt;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtsay1;
        private DevExpress.XtraEditors.TextEdit txtSay2;
        private System.Windows.Forms.Label label1;
    }
}

