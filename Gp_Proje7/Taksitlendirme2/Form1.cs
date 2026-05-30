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
        double sepetTutari, taksitTutari, pesinat;

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToDecimal((sender as Button).Text);
        }

        int taksitSayisi;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            taksitSayisi = Convert.ToInt16(numericUpDown1.Value);
            sepetTutari = Convert.ToDouble(textBox1.Text);
            pesinat = Convert.ToDouble(textBox2.Text);

            if (pesinat <= sepetTutari)
            {
                if (textBox1.Text != "")//sepet tutarı
                {
                    if (textBox2.Text == "") { textBox2.Text = "0"; } //peşinat
                    if (numericUpDown1.Value.ToString() == "0") //taksit sayısı
                    {
                        if (pesinat == sepetTutari)
                        {
                            listBox1.Items.Add("Peşin ödendi, Taksit Yok!");
                        }
                        else
                        {
                            listBox1.Items.Add("Taksit Sayısını seçin!");
                        }
                    }
                    else
                    {

                        taksitTutari = Math.Floor((sepetTutari - pesinat) / taksitSayisi);
                        for (int i = 1; i < taksitSayisi; i++)
                        {
                            listBox1.Items.Add("Taksit " + i + ": " + taksitTutari.ToString());
                        }
                        listBox1.Items.Add("Taksit " + taksitSayisi + ": " + (sepetTutari - (taksitSayisi - 1) * taksitTutari - pesinat).ToString());
                    }
                }

            }
            else
            {
                listBox1.Items.Add("Peşinat tutarını doğru GİR!");
            }
        }
    }
}
