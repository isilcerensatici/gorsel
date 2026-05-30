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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string siraKimde;
        int adimSayisi;
        int skorOyuncu1, skorOyuncu2;

        public void temizle()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
        }

        public void pasifYap()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
        }
        public void aktifYap()
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOyuncu1Skor.Text = "0";
            lblOyuncu2Skor.Text = "0";
            temizle();
            pasifYap();
            btnBasla.Enabled = true;
            lblOyuncu1Isim.Text = Form2.oyuncuAdi1;
            lblOyuncu2Isim.Text = Form2.oyuncuAdi2;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            (sender as Button).Text = siraKimde;
            (sender as Button).Enabled = false;
            adimSayisi++;
            kontrolEt();
            ilerle();
            
        }

        public void kontrolEt()
        {
            if ( 
                ((btn1.Text == btn2.Text) && (btn1.Text == btn3.Text) && (btn1.Text != "")) ||
                ((btn4.Text == btn5.Text) && (btn4.Text == btn6.Text) && (btn4.Text != "")) ||
                ((btn7.Text == btn8.Text) && (btn7.Text == btn9.Text) && (btn7.Text != "")) ||
                ((btn1.Text == btn4.Text) && (btn1.Text == btn7.Text) && (btn1.Text != "")) ||
                ((btn2.Text == btn5.Text) && (btn2.Text == btn8.Text) && (btn2.Text != "")) ||
                ((btn3.Text == btn6.Text) && (btn3.Text == btn9.Text) && (btn3.Text != "")) ||
                ((btn1.Text == btn5.Text) && (btn1.Text == btn9.Text) && (btn1.Text != "")) ||
                ((btn3.Text == btn5.Text) && (btn3.Text == btn7.Text) && (btn3.Text != "")) 
                )
            {
                if (siraKimde == "X") { 
                    skorOyuncu1++;                 
                    lblOyuncu1Skor.Text = skorOyuncu1.ToString();
                    lblBilgi.Text = lblOyuncu1Isim.Text + " kazandı!";

                }
                else { 
                    skorOyuncu2++;                
                    lblOyuncu2Skor.Text = skorOyuncu2.ToString();
                    lblBilgi.Text = lblOyuncu2Isim.Text + " kazandı!";
                }
                btnBasla.Enabled = true;
                pasifYap();

            }
            else
            {
                if (adimSayisi == 9)
                {
                    lblBilgi.Text = "BERABERLİK!";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            siraKimde = "X";
            adimSayisi = 0;
            temizle();
            aktifYap();
            btnBasla.Enabled = false;
            lblBilgi.Text = "";
        }

        public void ilerle()
        {
            if (siraKimde == "X")
            {
                siraKimde = "O";
            }
            else
            {
                siraKimde = "X";
            }
        }
    }
}
