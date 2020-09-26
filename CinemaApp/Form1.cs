using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Form1 : Form
    {
        int oturacaqSayi = 54;
        public Form1()
        {

            InitializeComponent();
            for (int i = 0; i < 54; i++)
            {
                SimpleButton buton = new SimpleButton
                {
                    Name = "buton" + i,
                    Text = (i + 1).ToString(),
                    Width = 75,
                    Height = 75,
                    Appearance = { BackColor = Color.LightGoldenrodYellow },
                    ButtonStyle = BorderStyles.Flat
                };
                buton.Click += Oturacaq_Click;
                flowLayoutOturacaq.Controls.Add(buton);
            }
        }

        private void Oturacaq_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            if (buton.Appearance.BackColor == Color.LightGoldenrodYellow)
            {
                buton.Appearance.BackColor = Color.Orange;
                listBoxOturacaq.Items.Add(buton.Text + "\tNömrəli Oturacaq");
            }
            else if(buton.Appearance.BackColor==Color.Red)
            {
                MessageBox.Show("Bu Oturacaq Artıq Satılmışdır");
            }
            else
            {
                buton.Appearance.BackColor = Color.LightGoldenrodYellow;
                listBoxOturacaq.Items.Remove(buton.Text + "\tNömrəli Oturacaq");
            }
            Hesabla();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBoxOturacaq.Items.Clear();
            foreach (SimpleButton item in flowLayoutOturacaq.Controls)
            {
                if (item.Appearance.BackColor == Color.Orange)
                {
                    item.Appearance.BackColor = Color.LightGoldenrodYellow;
                }
            }
            Hesabla();
        }

        private void btnSat_Click(object sender, EventArgs e)
        {
            listBoxOturacaq.Items.Clear();
            foreach (SimpleButton item in flowLayoutOturacaq.Controls)
            {
                if (item.Appearance.BackColor == Color.Orange)
                {
                    item.Appearance.BackColor = Color.Red;
                    oturacaqSayi--;
                    txtRezerv.Value = listBoxOturacaq.ItemCount;
                }
            }
            Hesabla();

        }

        void Hesabla()
        {
            txtRezerv.Value = listBoxOturacaq.ItemCount;
            txtSatilan.Value = 54 - oturacaqSayi;
            txtQalan.Value = oturacaqSayi;
        }
    }
}
