using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlisVeris
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void frmAna_Load(object sender, EventArgs e)
        {
            lbSaat.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
            pnlGosterge.Left = btnGunluk.Left;
            pnlGosterge.Top = 295;

        }

        private void btnGunluk_Click(object sender, EventArgs e)
        {
            pnlGosterge.Left = btnGunluk.Left;
        }

        private void btnHaftalik_Click(object sender, EventArgs e)
        {
            pnlGosterge.Left = btnHaftalik.Left;
        }

        private void btnAylik_Click(object sender, EventArgs e)
        {
            pnlGosterge.Left = btnAylik.Left;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            frmMusteriler fMust = new frmMusteriler();
            fMust.Show();
            this.Hide();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            frmUrunler fUrun = new frmUrunler();
            fUrun.Show();
            this.Hide();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            frmAlisVeris fAv = new frmAlisVeris();
            fAv.Show();
            this.Hide();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
