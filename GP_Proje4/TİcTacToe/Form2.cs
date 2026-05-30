using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TİcTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static string oyuncuAdi1, oyuncuAdi2;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if ( (tbOyuncu1.Text=="") || (tbOyuncu2.Text=="") )
            {
                MessageBox.Show("Oyuncu isimlerini Giriniz", "UYARI", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
            }
            else
            {
                oyuncuAdi1 = tbOyuncu1.Text;
                oyuncuAdi2 = tbOyuncu2.Text;
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }
    }
}
