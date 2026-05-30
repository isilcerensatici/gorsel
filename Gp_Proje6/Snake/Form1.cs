using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rasgele = new Random();
        string yon;
        int gecenSure = 0;
        int skor = 0;
        int alinanYemSayisi = 0;

        govde[] govdeler;
        yem yeniYem;

        private void Form1_Load(object sender, EventArgs e)
        {
            //yeniOyun();
            lbMesaj.Text = "Space ile Oyunu Başlat";
            lbMesaj.ForeColor = Color.Red;

            this.BackColor = Color.DarkGray;
            panel1.BackColor = Color.Black;
        }

        public void yeniOyun()
        {
            panel1.Controls.Clear();

            govdeler = new govde[100];

            govdeler[0] = new govde();
            govdeler[0].Parent = panel1;
            govdeler[0].Location = new Point(rasgele.Next(49) * 10, rasgele.Next(49) * 10);
            govdeler[0].BackColor = Color.CadetBlue;

            yon = "sag";
            lbMesaj.Text = "";
            gecenSure = 0;
            skor = 0;
            lbSkor.Text = "0";
            alinanYemSayisi = 0;

            yeniYem = new yem();
            yemCikar();
        }

        public void yemCikar()
        {
            yeniYem.Parent = panel1;
            yeniYem.Location = new Point(rasgele.Next(49) * 10, rasgele.Next(49) * 10);
        }

        int sonrakiGovdeParcasiKonumuX, sonrakiGovdeParcasiKonumuY;

        private void timerYilan_Tick(object sender, EventArgs e)
        {
            sonrakiGovdeParcasiKonumuX = govdeler[0].Left;
            sonrakiGovdeParcasiKonumuY = govdeler[0].Top;

            for (int govdeParcaNo = alinanYemSayisi; govdeParcaNo > 0; govdeParcaNo--)
            {
                govdeler[govdeParcaNo].Location = govdeler[govdeParcaNo - 1].Location;
            }

            if (yon=="sag")
            {
                govdeler[0].Left += 10;
            }
            else if (yon == "sol")
            {
                govdeler[0].Left -= 10;
            }
            else if (yon == "alt")
            {
                govdeler[0].Top += 10;
            }
            else if (yon == "ust")
            {
                govdeler[0].Top -= 10;
            }
            konumKontrol();
            yemKontrol();
        }
        public void konumKontrol()
        {
            if ( (govdeler[0].Left < 0) || (govdeler[0].Left > 490) || (govdeler[0].Top < 0) || (govdeler[0].Top > 490) )
            {
                oyunDurdur();
            }
            for (int govdeParcaNo = 1; govdeParcaNo < alinanYemSayisi; govdeParcaNo++)
            {
                if (govdeler[0].Location == govdeler[govdeParcaNo].Location)
                {
                    oyunDurdur();
                }
            }
         }

        public void yemKontrol()
        {
            //if ( (yilanBas.Left==yem.Left) && (yilanBas.Top==yem.Top))
            if(govdeler[0].Location == yeniYem.Location)
            {
                
                alinanYemSayisi++;
                skor += 10;
                lbSkor.Text = skor.ToString();
                if (timerYilan.Interval > 50)
                {
                    timerYilan.Interval -= 10;
                }
                
                yemCikar();
                yilaniBuyut();
            }
        }

        public void yilaniBuyut()
        {
            govdeler[alinanYemSayisi] = new govde();

            govdeler[alinanYemSayisi].Parent = panel1;
            govdeler[alinanYemSayisi].Location = govdeler[0].Location;
        }

        public void oyunDurdur()
        {
            timerGecenSure.Enabled = false;
            timerYilan.Enabled = false;
            lbMesaj.Text = "OYUN BİTTİ! " + lbSure.Text + " saniye oyadınız. Skorunuz: "+skor;
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                timerYilan.Enabled = true;
                timerGecenSure.Enabled = true;
                yeniOyun();
            }

            if (e.KeyCode == Keys.Up  && yon!="alt")
            {
                yon = "ust";
            }
            else if (e.KeyCode == Keys.Down && yon!="ust")
            {
                yon = "alt";
            }
            else if (e.KeyCode == Keys.Left && yon!="sag")
            {
                yon = "sol";
            }
            else if (e.KeyCode == Keys.Right && yon!="sol")
            {
                yon = "sag";
            }
        }

        private void timerGecenSure_Tick(object sender, EventArgs e)
        {
            gecenSure++;
            
            TimeSpan zaman = TimeSpan.FromSeconds(gecenSure);

            string strSure = zaman.ToString(@"mm\:ss");

            lbSure.Text = strSure;
        }

    }
}
