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

namespace RestorantApp
{
    public partial class Form1 : Form
    {
        private List<Stol> stollar = new List<Stol>();
        private List<Mehsul> mehsullar = new List<Mehsul>();
        private List<MehsulHereket> hereketler = new List<MehsulHereket>();
        private string secilenStol;

        public Form1()
        {
            InitializeComponent();

            #region mehsul 
            mehsullar.Add(new Mehsul
            {
                Id = 1,
                MehsulAdi = "Quzu Kabab",
                MehsulKodu = "1",
                Qiymet = 15,
                Vahidi = "Porsiya"

            }); mehsullar.Add(new Mehsul
            {
                Id = 2,
                MehsulAdi = "Dana Basdırma",
                MehsulKodu = "2",
                Qiymet = 18,
                Vahidi = "Porsiya"

            }); mehsullar.Add(new Mehsul
            {
                Id = 3,
                MehsulAdi = "Mərci Supu",
                MehsulKodu = "3",
                Qiymet = 2,
                Vahidi = "Porsiya"

            });
            mehsullar.Add(new Mehsul
            {
                Id = 4,
                MehsulAdi = "Antrikot",
                MehsulKodu = "4",
                Qiymet = 20,
                Vahidi = "Porsiya"

            }); mehsullar.Add(new Mehsul
            {
                Id = 5,
                MehsulAdi = "Toyuq Kababı",
                MehsulKodu = "5",
                Qiymet = 8,
                Vahidi = "Porsiya"
            });

            stollar.Add(new Stol
            {
                Id = 1,
                StolAdi = "Stol_1",
                StolKodu = "1"
            }); stollar.Add(new Stol
            {
                Id = 2,
                StolAdi = "Stol_2",
                StolKodu = "2"
            }); stollar.Add(new Stol
            {
                Id = 3,
                StolAdi = "Stol_3",
                StolKodu = "3"
            }); stollar.Add(new Stol
            {
                Id = 4,
                StolAdi = "Stol_4",
                StolKodu = "4"
            }); stollar.Add(new Stol
            {
                Id = 5,
                StolAdi = "Stol_5",
                StolKodu = "5"
            });
            #endregion
            //gridControl1.DataSource = mehsullar;
            ButonCreate();
        }
        private void ButonCreate()
        {
            foreach (var stol in stollar)
            {
                SimpleButton buton = new SimpleButton
                {
                    Name = stol.StolKodu,
                    Width = 75,
                    Height = 75,
                    Text = stol.StolAdi,
                    Appearance =
                    {
                        BackColor=Color.LightGreen,
                    }
                };
                flowLayoutMasa.Controls.Add(buton);
                buton.Click += Buton_Click;
            }

            foreach (var mehsul in mehsullar)
            {
                SimpleButton mehsulButon = new SimpleButton
                {
                    Name = mehsul.MehsulKodu,
                    Text = mehsul.MehsulAdi,
                    Width = 85,
                    Height = 75,
                    ButtonStyle = BorderStyles.Flat,
                    Appearance =
                    {
                        BackColor=Color.Beige,
                    }
                };
                flowLayoutYemek.Controls.Add(mehsulButon);
                mehsulButon.Click += MehsulButon_Click;
            }

        }

        private void Buton_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            Stol stol = stollar.SingleOrDefault(x => x.StolKodu == buton.Name);
            if (stol.Hereketleri == null)
            {
                stol.Hereketleri = new List<MehsulHereket>();
            }
            secilenStol = stol.StolKodu;
            gridControl1.DataSource = stol.Hereketleri;
            gridView1.RefreshData();
            if (buton.Appearance.BackColor == Color.LightGreen)
            {
                buton.Appearance.BackColor = Color.Orange;
            }else if (buton.Appearance.BackColor == Color.Red){
                MessageBox.Show("Bu Stol Doludur");
            }
            else
            {
                buton.Appearance.BackColor = Color.LightGreen;
            }
            txtQiymet.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);
        }

        private void MehsulButon_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            var mehsul = mehsullar.SingleOrDefault(x => x.MehsulKodu == buton.Name);
            stollar.SingleOrDefault(x => x.StolKodu == secilenStol).Hereketleri.Add(new MehsulHereket
            {
                MehsulAdi=mehsul.MehsulAdi,
                MehsulKodu=mehsul.MehsulKodu,
                Miqdar=1,
                Qiymet=mehsul.Qiymet,
                Vahidi=mehsul.Vahidi
            });
            gridView1.RefreshData();
            SimpleButton butonSecili = (SimpleButton)flowLayoutMasa.Controls.Find(secilenStol, false).SingleOrDefault();
            if (butonSecili!=null)
            {
                butonSecili.Appearance.BackColor = Color.Red;
            }
            txtQiymet.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);   
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)flowLayoutMasa.Controls.Find(secilenStol, true).SingleOrDefault();
            buton.Appearance.BackColor = Color.YellowGreen;
            var stol = stollar.SingleOrDefault(x => x.StolKodu == buton.Name);
            stol.Hereketleri = new List<MehsulHereket>();
            gridControl1.DataSource = stol.Hereketleri;
            txtQiymet.Value = 0;
        }
    }
}
