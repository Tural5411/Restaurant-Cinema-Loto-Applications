namespace RestorantApp
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
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowLayoutMasa = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowLayoutYemek = new System.Windows.Forms.FlowLayoutPanel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMehsulKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMehsulAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVahid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQiymet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiqdar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQiymet = new DevExpress.XtraEditors.CalcEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQiymet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.navigationPage1);
            this.navigationPane1.Controls.Add(this.navigationPage2);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(854, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowCollapseButton = false;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationPane1.RegularSize = new System.Drawing.Size(381, 725);
            this.navigationPane1.SelectedPage = this.navigationPage1;
            this.navigationPane1.Size = new System.Drawing.Size(381, 725);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "Masa";
            this.navigationPage1.Controls.Add(this.flowLayoutMasa);
            this.navigationPage1.Controls.Add(this.groupControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(274, 645);
            // 
            // flowLayoutMasa
            // 
            this.flowLayoutMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMasa.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutMasa.Name = "flowLayoutMasa";
            this.flowLayoutMasa.Size = new System.Drawing.Size(274, 481);
            this.flowLayoutMasa.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Yemək";
            this.navigationPage2.Controls.Add(this.flowLayoutYemek);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(274, 645);
            // 
            // flowLayoutYemek
            // 
            this.flowLayoutYemek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutYemek.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutYemek.Name = "flowLayoutYemek";
            this.flowLayoutYemek.Size = new System.Drawing.Size(274, 645);
            this.flowLayoutYemek.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(854, 725);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMehsulKodu,
            this.colMehsulAd,
            this.colVahid,
            this.colQiymet,
            this.colMiqdar,
            this.colToplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMehsulKodu
            // 
            this.colMehsulKodu.Caption = "Məhsul Kodu";
            this.colMehsulKodu.FieldName = "MehsulKodu";
            this.colMehsulKodu.MinWidth = 25;
            this.colMehsulKodu.Name = "colMehsulKodu";
            this.colMehsulKodu.OptionsColumn.AllowEdit = false;
            this.colMehsulKodu.Visible = true;
            this.colMehsulKodu.VisibleIndex = 0;
            this.colMehsulKodu.Width = 94;
            // 
            // colMehsulAd
            // 
            this.colMehsulAd.Caption = "Məhsul Adı";
            this.colMehsulAd.FieldName = "MehsulAdi";
            this.colMehsulAd.MinWidth = 25;
            this.colMehsulAd.Name = "colMehsulAd";
            this.colMehsulAd.OptionsColumn.AllowEdit = false;
            this.colMehsulAd.Visible = true;
            this.colMehsulAd.VisibleIndex = 1;
            this.colMehsulAd.Width = 94;
            // 
            // colVahid
            // 
            this.colVahid.Caption = "Vahidi";
            this.colVahid.FieldName = "Vahidi";
            this.colVahid.MinWidth = 25;
            this.colVahid.Name = "colVahid";
            this.colVahid.OptionsColumn.AllowEdit = false;
            this.colVahid.Visible = true;
            this.colVahid.VisibleIndex = 2;
            this.colVahid.Width = 94;
            // 
            // colQiymet
            // 
            this.colQiymet.Caption = "Qiymət";
            this.colQiymet.FieldName = "Qiymet";
            this.colQiymet.MinWidth = 25;
            this.colQiymet.Name = "colQiymet";
            this.colQiymet.Visible = true;
            this.colQiymet.VisibleIndex = 3;
            this.colQiymet.Width = 94;
            // 
            // colMiqdar
            // 
            this.colMiqdar.Caption = "Miqdarı";
            this.colMiqdar.FieldName = "Miqdar";
            this.colMiqdar.MinWidth = 25;
            this.colMiqdar.Name = "colMiqdar";
            this.colMiqdar.Visible = true;
            this.colMiqdar.VisibleIndex = 4;
            this.colMiqdar.Width = 94;
            // 
            // colToplam
            // 
            this.colToplam.Caption = "Toplam";
            this.colToplam.DisplayFormat.FormatString = "C2";
            this.colToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colToplam.FieldName = "colToplam";
            this.colToplam.MinWidth = 25;
            this.colToplam.Name = "colToplam";
            this.colToplam.OptionsColumn.AllowEdit = false;
            this.colToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colToplam", "SUM={0:C2}")});
            this.colToplam.UnboundExpression = "[Qiymet] * [Miqdar]";
            this.colToplam.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colToplam.Visible = true;
            this.colToplam.VisibleIndex = 5;
            this.colToplam.Width = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Toplam Qiymət";
            // 
            // txtQiymet
            // 
            this.txtQiymet.Location = new System.Drawing.Point(35, 60);
            this.txtQiymet.Name = "txtQiymet";
            this.txtQiymet.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtQiymet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtQiymet.Properties.Appearance.Options.UseBackColor = true;
            this.txtQiymet.Properties.Appearance.Options.UseFont = true;
            this.txtQiymet.Size = new System.Drawing.Size(195, 40);
            this.txtQiymet.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOde);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.txtQiymet);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 481);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(274, 164);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "HESAB";
            // 
            // btnOde
            // 
            this.btnOde.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOde.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Appearance.Options.UseBackColor = true;
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Location = new System.Drawing.Point(5, 106);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(264, 53);
            this.btnOde.TabIndex = 4;
            this.btnOde.Text = "Hesabı Ödə";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 725);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navigationPane1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQiymet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMasa;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutYemek;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMehsulKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colMehsulAd;
        private DevExpress.XtraGrid.Columns.GridColumn colVahid;
        private DevExpress.XtraGrid.Columns.GridColumn colQiymet;
        private DevExpress.XtraGrid.Columns.GridColumn colMiqdar;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.CalcEdit txtQiymet;
        private DevExpress.XtraGrid.Columns.GridColumn colToplam;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnOde;
    }
}

