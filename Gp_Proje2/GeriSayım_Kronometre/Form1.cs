using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeriSayım_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sls, sn, dk, sa;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sls++;

            if (sls == 10)
            {
                sls = 0;
                sn++;
                

                if (sn == 60)
                {
                    sn = 0;
                    dk++;

                    if (dk == 60)
                    {
                        dk = 0;
                        sa++;

                        lblsa.Text = sa.ToString();
                    }


                    lbldk.Text = dk.ToString();

                }
                lblsn.Text = sn.ToString();
            }
            lblsls.Text = sls.ToString();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
                button1.Text = "DURAKLAT";
            }
            else
            {
                timer1.Enabled = false;
                button1.Text = "BAŞLA";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(lblsa.Text+":"+ lbldk.Text +":"+ lblsn.Text +":"+ lblsls.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifirla();
            timer1.Enabled = false;
            listBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sifirla();
        }

        public void sifirla()
        {
            sls = 0;
            sn = 0;
            dk = 0;
            sa = 0;
            lblsls.Text = "00";
            lblsn.Text = "00";
            lbldk.Text = "00";
            lblsa.Text = "00";
        }
    }
}
