using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AlisVeris
{
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter dad = new SqlDataAdapter();
        DataSet ds = new DataSet();

        String exeYolu;
        String islem;

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAna fAna = new frmAna();
            fAna.Show();
            this.Close();
        }

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            Bagla();
            KayitlariGetir();
            modGezinti();
        }

        public void Bagla()
        {
            baglanti.ConnectionString ="Data Source=.; Initial Catalog=TicariVT; Integrated Security=SSPI";
            baglanti.Open();
        }

        public void KayitlariGetir()
        {
            ds.Clear();

            dad = new SqlDataAdapter("Select * from musteriler", baglanti);
            dad.Fill(ds);
            dgMusteriler.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void dgMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMusteriId.Text = dgMusteriler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dgMusteriler.CurrentRow.Cells[3].Value.ToString();

            exeYolu = Application.StartupPath;
            pbFoto.ImageLocation = exeYolu + "\\mustResimler\\" + dgMusteriler.CurrentRow.Cells[4].Value.ToString();
        }

        public void temizle()
        {
            lblMusteriId.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            pbFoto.ImageLocation = "";
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            temizle();
            txtAd.Focus();
            modDuzenle();
            islem = "yeni";
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            islem = "duzenle";
            modDuzenle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Bagla();
            SqlCommand komut = new SqlCommand();

            if (islem == "yeni")
            {
                komut = new SqlCommand("insert into musteriler (mustAd, mustSoyad, mustTel, mustFoto) values (@ad, @soyad, @tel, @foto)", baglanti);

                
            }
            else if (islem == "duzenle")
            {
                komut = new SqlCommand("update musteriler set mustAd=@ad, mustSoyad=@soyad, mustTel=@tel, mustFoto=@foto where mustID=@mID", baglanti);
                komut.Parameters.AddWithValue("@mId", lblMusteriId.Text);
            }

            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@foto", ofd.SafeFileName);
            komut.ExecuteNonQuery();

            KayitlariGetir();
            baglanti.Close();

            modGezinti();
        }

        public void modDuzenle()
        {
            btnYeni.Enabled = false;
            btnDuzenle.Enabled = false;
            btnKaydet.Enabled = true;
            btnSil.Enabled = false;
            btnKapat.Enabled = false;

            txtAd.Enabled = true;
            txtSoyad.Enabled = true;
            txtTelefon.Enabled = true;
            pbFoto.Enabled = true;
        }

        public void modGezinti()
        {
            btnYeni.Enabled = true;
            btnDuzenle.Enabled = true;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            btnKapat.Enabled = true;

            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtTelefon.Enabled = false;
            pbFoto.Enabled = false;
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            pbFoto.ImageLocation = ofd.FileName;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Seçilen kayıt silinecek! Emin misiniz?","UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                Bagla();
                SqlCommand komut = new SqlCommand();
                komut = new SqlCommand("delete from musteriler where mustID=@mID", baglanti);
                komut.Parameters.AddWithValue("@mId", lblMusteriId.Text);
                komut.ExecuteNonQuery();
                KayitlariGetir();
                baglanti.Close();
                temizle();
            }
            modGezinti();
        }

        public void aquaYap(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Aqua;
        }

        
        public void beyazYap(object sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
        }

        private void txtAd_Enter(object sender, EventArgs e)
        {
            aquaYap(sender, e);
        }

        private void txtAd_Leave(object sender, EventArgs e)
        {
            beyazYap(sender, e);
        }
    }
}
