using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int notu = 75;

            if (notu > 44) MessageBox.Show("Geçer");

            else if (notu > 54) MessageBox.Show("Orta");

            else if (notu > 64) MessageBox.Show("Yüksek");
        }
    }
}
