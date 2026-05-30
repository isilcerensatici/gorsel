using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taksitlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Label[] taksitler; //label dizisi
        int taksitSayisi = 0;
        double sepetTutari = 0, taksitMiktari = 0, pesinat = 0;


        private void nudTaksitSayısı_ValueChanged(object sender, EventArgs e)
        {
            for (int taksitNo = 0; taksitNo < taksitSayisi; taksitNo++)
            {
                taksitler[taksitNo].Dispose();
            }


            taksitSayisi = Convert.ToInt32(nudTaksitSayısı.Value);
            taksitler = new Label[taksitSayisi];
            sepetTutari = Convert.ToDouble(txSepetTutari.Text);
            pesinat = Convert.ToDouble(txPesinat.Text);
            taksitMiktari = Math.Floor((sepetTutari - pesinat) / taksitSayisi);
            for (int taksitNo = 0; taksitNo < taksitSayisi; taksitNo++)
            {
                taksitler[taksitNo] = new Label();
                taksitler[taksitNo].Parent = this;
                taksitler[taksitNo].Location = new Point(750, taksitNo * 25 + 30);

                if (taksitNo < taksitSayisi-1)
                {
                    taksitler[taksitNo].Text = "Taksit:" + (taksitNo + 1) + " :" + taksitMiktari.ToString();
                }
                else
                {
                    taksitler[taksitNo].Text = "Taksit:" + (taksitNo + 1) + " :" + (sepetTutari - pesinat - (taksitSayisi - 1) * taksitMiktari).ToString();
                }
            }
        }
    }
}
