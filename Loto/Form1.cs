using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int[] saylar = new int[6];

            for (int i = 0; i < saylar.Length; i++)
            {
                buraqayit:
                int texminolan = random.Next(1, 50);
                foreach (var item in saylar)
                {
                    if (item == texminolan)
                    {
                        goto buraqayit;
                    }
                }
                saylar[i] = texminolan;

            }
            Array.Sort(saylar);
            textEdit1.Text = saylar[0].ToString();
            textEdit2.Text = saylar[1].ToString();
            textEdit3.Text = saylar[2].ToString();
            textEdit4.Text = saylar[3].ToString();
            textEdit5.Text = saylar[4].ToString();
            textEdit6.Text = saylar[5].ToString();
        }
    }
}
