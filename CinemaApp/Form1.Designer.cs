namespace CinemaApp
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
            this.flowLayoutOturacaq = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControlOturacaq = new DevExpress.XtraEditors.GroupControl();
            this.listBoxOturacaq = new DevExpress.XtraEditors.ListBoxControl();
            this.btnSat = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRezerv = new DevExpress.XtraEditors.CalcEdit();
            this.txtSatilan = new DevExpress.XtraEditors.CalcEdit();
            this.txtQalan = new DevExpress.XtraEditors.CalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOturacaq)).BeginInit();
            this.groupControlOturacaq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxOturacaq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRezerv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatilan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQalan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutOturacaq
            // 
            this.flowLayoutOturacaq.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutOturacaq.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutOturacaq.Name = "flowLayoutOturacaq";
            this.flowLayoutOturacaq.Size = new System.Drawing.Size(1005, 743);
            this.flowLayoutOturacaq.TabIndex = 0;
            // 
            // groupControlOturacaq
            // 
            this.groupControlOturacaq.Controls.Add(this.txtQalan);
            this.groupControlOturacaq.Controls.Add(this.txtSatilan);
            this.groupControlOturacaq.Controls.Add(this.txtRezerv);
            this.groupControlOturacaq.Controls.Add(this.label3);
            this.groupControlOturacaq.Controls.Add(this.label2);
            this.groupControlOturacaq.Controls.Add(this.label1);
            this.groupControlOturacaq.Controls.Add(this.btnTemizle);
            this.groupControlOturacaq.Controls.Add(this.btnSat);
            this.groupControlOturacaq.Controls.Add(this.listBoxOturacaq);
            this.groupControlOturacaq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlOturacaq.Location = new System.Drawing.Point(1005, 0);
            this.groupControlOturacaq.Name = "groupControlOturacaq";
            this.groupControlOturacaq.Size = new System.Drawing.Size(335, 743);
            this.groupControlOturacaq.TabIndex = 1;
            this.groupControlOturacaq.Text = "Menu";
            // 
            // listBoxOturacaq
            // 
            this.listBoxOturacaq.Location = new System.Drawing.Point(12, 40);
            this.listBoxOturacaq.Name = "listBoxOturacaq";
            this.listBoxOturacaq.Size = new System.Drawing.Size(318, 198);
            this.listBoxOturacaq.TabIndex = 0;
            // 
            // btnSat
            // 
            this.btnSat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSat.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSat.Appearance.Options.UseBackColor = true;
            this.btnSat.Appearance.Options.UseFont = true;
            this.btnSat.Appearance.Options.UseForeColor = true;
            this.btnSat.Location = new System.Drawing.Point(12, 260);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(154, 59);
            this.btnSat.TabIndex = 1;
            this.btnSat.Text = "SAT";
            this.btnSat.Click += new System.EventHandler(this.btnSat_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Location = new System.Drawing.Point(176, 260);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(154, 59);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TƏMİZLƏ";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 644);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rezerv Edilən";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 676);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Satılan Oturacaq Sayı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 710);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qalan Oturacaq Sayı";
            // 
            // txtRezerv
            // 
            this.txtRezerv.Location = new System.Drawing.Point(235, 639);
            this.txtRezerv.Name = "txtRezerv";
            this.txtRezerv.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRezerv.Properties.Appearance.Options.UseFont = true;
            this.txtRezerv.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtRezerv.Properties.Precision = 0;
            this.txtRezerv.Properties.ReadOnly = true;
            this.txtRezerv.Size = new System.Drawing.Size(95, 24);
            this.txtRezerv.TabIndex = 3;
            // 
            // txtSatilan
            // 
            this.txtSatilan.Location = new System.Drawing.Point(235, 673);
            this.txtSatilan.Name = "txtSatilan";
            this.txtSatilan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatilan.Properties.Appearance.Options.UseFont = true;
            this.txtSatilan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSatilan.Properties.Precision = 0;
            this.txtSatilan.Properties.ReadOnly = true;
            this.txtSatilan.Size = new System.Drawing.Size(95, 24);
            this.txtSatilan.TabIndex = 3;
            // 
            // txtQalan
            // 
            this.txtQalan.Location = new System.Drawing.Point(235, 707);
            this.txtQalan.Name = "txtQalan";
            this.txtQalan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQalan.Properties.Appearance.Options.UseFont = true;
            this.txtQalan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQalan.Properties.Precision = 0;
            this.txtQalan.Properties.ReadOnly = true;
            this.txtQalan.Size = new System.Drawing.Size(95, 24);
            this.txtQalan.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 743);
            this.Controls.Add(this.groupControlOturacaq);
            this.Controls.Add(this.flowLayoutOturacaq);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.groupControlOturacaq)).EndInit();
            this.groupControlOturacaq.ResumeLayout(false);
            this.groupControlOturacaq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxOturacaq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRezerv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatilan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQalan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutOturacaq;
        private DevExpress.XtraEditors.GroupControl groupControlOturacaq;
        private DevExpress.XtraEditors.CalcEdit txtQalan;
        private DevExpress.XtraEditors.CalcEdit txtSatilan;
        private DevExpress.XtraEditors.CalcEdit txtRezerv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraEditors.SimpleButton btnSat;
        private DevExpress.XtraEditors.ListBoxControl listBoxOturacaq;
    }
}

