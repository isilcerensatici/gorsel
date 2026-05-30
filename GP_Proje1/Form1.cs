using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GP_Proje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double sonuc,ilkSayi, hafiza;
        string islem;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Text ==",")
            {
                int uzunluk = ekran.TextLength;
                int var = 0;
                string metin = ekran.Text;
                for(int i = 0; i < uzunluk; i++)
                {
                    if (metin[i].ToString() == ",")
                    {
                        var = 1;break;
                    }
                }
                if (var == 0)
                {
                    if (uzunluk == 0)
                    {
                        ekran.Text = "0,";

                    }
                    else
                    {
                        ekran.Text = ekran.Text + ",";
                    }
                }
            }
            else {
                ekran.Text += (sender as Button).Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sonuc = Convert.ToDouble(ekran.Text);
            sonuc = sonuc * -1;//sonuc *= -1;
            ekran.Text = Convert.ToString(sonuc);


            //ekran.Text = Convert.ToString(Convert.ToDouble(ekran.Text)*-1);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                sonuc = ilkSayi + Convert.ToDouble(ekran.Text);
            }
            else if (islem == "-")
            {
                sonuc = ilkSayi - Convert.ToDouble(ekran.Text);
            }
            else if (islem == "*")
            {
                sonuc = ilkSayi * Convert.ToDouble(ekran.Text);
            }
            else if (islem == "/")
            {
                sonuc = ilkSayi / Convert.ToDouble(ekran.Text);
            }

            ekran.Text = Convert.ToString(sonuc);//sonuc.toString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ekran.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ekran.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hafiza = hafiza + Convert.ToDouble(ekran.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hafiza = hafiza - Convert.ToDouble(ekran.Text);
        }

        private void ekran_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            ekran.Text = hafiza.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islem = (sender as Button).Text;
            ilkSayi = Convert.ToDouble(ekran.Text);
            ekran.Text = "";
            ekran.Focus();
        }




    }
}
