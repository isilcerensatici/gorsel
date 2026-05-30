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
    public partial class frmUrunler : Form
    {
        public frmUrunler()
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

        public void Bagla()
        {
            baglanti.ConnectionString = "Data Source=.; Initial Catalog=TicariVT; Integrated Security=SSPI";
            baglanti.Open();
        }

        public void KayitlariGetir()
        {
            ds.Clear();

            dad = new SqlDataAdapter("Select * from urunler", baglanti);
            dad.Fill(ds);
            dgUrunler.DataSource = ds.Tables[0];

            baglanti.Close();
        }

        private void dgUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblUrunID.Text = dgUrunler.CurrentRow.Cells[0].Value.ToString();
            txtKod.Text = dgUrunler.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgUrunler.CurrentRow.Cells[2].Value.ToString();
            txtAlisFiyat.Text = dgUrunler.CurrentRow.Cells[3].Value.ToString();
            txtStokMiktar.Text = dgUrunler.CurrentRow.Cells[4].Value.ToString();

            exeYolu = Application.StartupPath;
            pbFoto.ImageLocation = exeYolu + "\\urunResimler\\" + dgUrunler.CurrentRow.Cells[5].Value.ToString();
        }

        public void temizle()
        {
            lblUrunID.Text = "";
            txtAd.Text = "";
            txtKod.Text = "";
            txtAlisFiyat.Text = "";
            txtStokMiktar.Text = "";
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
                komut = new SqlCommand("insert into urunler (urunKod, urunAd, urunAlisFiyat, urunStokAdet, urunFoto) values (@kod, @ad, @fiyat, @stok, @foto)", baglanti);


            }
            else if (islem == "duzenle")
            {
                komut = new SqlCommand("update urunler set  urunKod=@kod, urunAd=@ad, urunAlisFiyat=@fiyat, urunStokAdet=@stok, urunFoto=@foto where urunID=@uID", baglanti);
                komut.Parameters.AddWithValue("@uId", lblUrunID.Text);
            }

            komut.Parameters.AddWithValue("@kod", txtKod.Text);
            komut.Parameters.AddWithValue("@ad", txtAd.Text);
            komut.Parameters.AddWithValue("@fiyat", txtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@stok", txtStokMiktar.Text);
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

            txtKod.Enabled = true;
            txtAd.Enabled = true;
            txtAlisFiyat.Enabled = true;
            txtStokMiktar.Enabled = true;
            pbFoto.Enabled = true;
        }

        public void modGezinti()
        {
            btnYeni.Enabled = true;
            btnDuzenle.Enabled = true;
            btnKaydet.Enabled = false;
            btnSil.Enabled = true;
            btnKapat.Enabled = true;

            txtKod.Enabled = false;
            txtAd.Enabled = false;
            txtAlisFiyat.Enabled = false;
            txtStokMiktar.Enabled = false;
            pbFoto.Enabled = false;
        }

        private void ofd_FileOk(object sender, CancelEventArgs e)
        {
            pbFoto.ImageLocation = ofd.FileName;
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            ofd.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Seçilen kayıt silinecek! Emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                Bagla();
                SqlCommand komut = new SqlCommand();
                komut = new SqlCommand("delete from urunler where urunID=@uID", baglanti);
                komut.Parameters.AddWithValue("@uId", lblUrunID.Text);
                komut.ExecuteNonQuery();
                KayitlariGetir();
                baglanti.Close();
                temizle();
            }
            modGezinti();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            Bagla();
            KayitlariGetir();
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

        private void txtKod_Enter(object sender, EventArgs e)
        {
            aquaYap(sender, e);
        }

        private void txtKod_Leave(object sender, EventArgs e)
        {
            beyazYap(sender, e);
        }
    }
}
