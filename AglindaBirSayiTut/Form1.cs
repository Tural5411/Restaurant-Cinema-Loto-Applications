using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AglindaBirSayiTut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMenTexminEdim_Click(object sender, EventArgs e)
        {
            FrmMenTexminEdim mform = new FrmMenTexminEdim(Convert.ToInt32(txtsay1.Text), Convert.ToInt32(txtSay2.Text));
            mform.ShowDialog();
        }

        private void btnKompTexminEt_Click(object sender, EventArgs e)
        {
            FrmKompTexmin mform = new FrmKompTexmin(Convert.ToInt32(txtsay1.Text), Convert.ToInt32(txtSay2.Text));
            mform.ShowDialog();
        }
    }
}
