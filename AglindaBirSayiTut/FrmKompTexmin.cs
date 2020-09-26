using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AglindaBirSayiTut
{
    public partial class FrmKompTexmin : DevExpress.XtraEditors.XtraForm
    {
        private string[] msjlar = { "Düz deyil ?", "Bu da deyil ?", "Tapdım sən öl", "Tapdığıma əminəm" };
        Random random = new Random();
        private int texmin;
        public FrmKompTexmin(int min,int max)
        {
            InitializeComponent();
            listBoxControl1.Visible = false;

            for (int i = min; i < max; i++)
            {
                listBoxControl1.Items.Add(i);
            }
            texminEt();
        }

        private void texminEt()
        {
            if (listBoxControl1.ItemCount == 0)
            {
                lblBildiris.ForeColor = Color.OrangeRed;
                lblBildiris.Text = "Məni doladın təbrik edirəm , yaxşı oğlan komputeri dolamaz";


                return;
            }
            texmin = random.Next(0, listBoxControl1.ItemCount - 1);
            lblBildiris.Text = $"{listBoxControl1.Items[texmin]} {msjlar[random.Next(0, 3)]}";
        }

        private void btnHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dogru tapdim");
        }

        private void btnYox_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Remove(listBoxControl1.Items[texmin]);
            texminEt();
        }
    }
}