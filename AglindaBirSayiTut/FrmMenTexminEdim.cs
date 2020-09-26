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
    public partial class FrmMenTexminEdim : DevExpress.XtraEditors.XtraForm
    {
        private int texminEt;
        Random random = new Random();
        private string[] msjlar =
        {
            "Düz tapmadın!!! ", "Tupoysane Yetim", "Bu qədər asand bir rəqəm tutaram heç?",
            "Doğru Deyil"
        };
        public FrmMenTexminEdim(int min,int max)
        {
            InitializeComponent();
            texminEt = random.Next(min, max);
            lblBildiris.Visible = true;
            lblBildiris.Text = $"Sənin üçün {min} ilə {max} arasında bir sayı tutdum görüm tapa biləcəksən?";
        }

        private void txtMenTexmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToInt32(txtMenTexmin.Text) == texminEt)
                {
                    lblBildiris.Visible = true;
                    lblBildiris.ForeColor = Color.Green;
                    lblBildiris.Text = "****Təbriklər****";
                    MessageBox.Show("Təbriklər qazandınız", MessageBeepSound.Question.ToString());
                    this.Close();
                }
                else
                {
                    lblBildiris.Visible = true;
                    
                    lblBildiris.ForeColor = Color.Red;
                    lblBildiris.Text = msjlar[random.Next(0, msjlar.Length
                        )];
                }
            }
        }
    }
}