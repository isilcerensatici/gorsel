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
    public partial class frmAlisVeris : Form
    {
        public frmAlisVeris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            frmAna fAna = new frmAna();
            fAna.Show();
            this.Close();
        }

        SqlConnection baglanti = new SqlConnection();
        SqlDataAdapter dadMusteri = new SqlDataAdapter();
        SqlDataAdapter dadSiparis = new SqlDataAdapter();
        SqlDataAdapter dadSiparisDetay = new SqlDataAdapter();
        SqlDataAdapter dadUrun = new SqlDataAdapter();

        DataSet ds1 = new DataSet();
        DataSet ds2 = new DataSet();
        DataSet ds3 = new DataSet();
        DataSet ds4 = new DataSet();


        public void Bagla()
        {
            baglanti.ConnectionString = "Data Source=.; Initial Catalog=TicariVT; Integrated Security=SSPI";
            baglanti.Open();
        }

        public void KayitlariGetir()
        {
            ds1.Clear();

            dadMusteri = new SqlDataAdapter("Select * from musteriler", baglanti);
            dadMusteri.Fill(ds1);
            dgMusteriler.DataSource = ds1.Tables[0];

            baglanti.Close();
        }

        private void frmAlisVeris_Load(object sender, EventArgs e)
        {
            Bagla();
            KayitlariGetir();
        }
        string exeYolu;
        private void dgMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblMusteriId.Text = dgMusteriler.CurrentRow.Cells[0].Value.ToString();
            txtMusteriID.Text = dgMusteriler.CurrentRow.Cells[0].Value.ToString();
            txtMusteriAdi.Text = dgMusteriler.CurrentRow.Cells[1].Value.ToString();
            txtMusteriSoyadi.Text = dgMusteriler.CurrentRow.Cells[2].Value.ToString();
            txtMusteriTelefonu.Text = dgMusteriler.CurrentRow.Cells[3].Value.ToString();

            exeYolu = Application.StartupPath;
            pbMusteri.ImageLocation = exeYolu + "\\mustResimler\\" + dgMusteriler.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtMusteriID_TextChanged(object sender, EventArgs e)
        {
            ds2.Clear();
            if (txtMusteriID.Text != "") {
                if (baglanti.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                int mustID = Convert.ToInt16(txtMusteriID.Text);
                dadSiparis = new SqlDataAdapter("select * from siparisler where mustID=" + mustID + "", baglanti);
                dadSiparis.Fill(ds2);
                dgSiparisler.DataSource = ds2.Tables[0];
                baglanti.Close();
            }
        }

        private void btnYeniSiparis_Click(object sender, EventArgs e)
        {
            if ((dtpSiparisTarihi.Text != "") && (cbOdemeTuru.Text != "") ) {
                if (baglanti.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                SqlCommand komut = new SqlCommand();
                komut = new SqlCommand("insert into siparisler (siparisTarihi, mustID, odemeTuru) values (@sipTarih, @mustid, @odemeTuru)", baglanti);
                komut.Parameters.AddWithValue("@sipTarih", dtpSiparisTarihi.Value);
                komut.Parameters.AddWithValue("@mustid", txtMusteriID.Text);
                komut.Parameters.AddWithValue("@odemeTuru", cbOdemeTuru.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                txtMusteriID_TextChanged(sender, e);
            }
        }

        private void dgSiparisler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSiparisID.Text = dgSiparisler.CurrentRow.Cells[0].Value.ToString();
        }

        private void txtSiparisID_TextChanged(object sender, EventArgs e)
        {
            if (txtSiparisID.Text != "") {
                ds3.Clear();
                if (baglanti.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                int sipID = Convert.ToInt16(txtSiparisID.Text);
                dadSiparisDetay = new SqlDataAdapter("Select * from siparisDetay where siparisID=" + sipID + "", baglanti);
                dadSiparisDetay.Fill(ds3);
                dgSepet.DataSource = ds3.Tables[0];
            }
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                Bagla();
            }
            ds4.Clear();
            if (txtUrunAra.Text != "")
            {
                dadUrun = new SqlDataAdapter("Select * from urunler where urunAd like '%" + txtUrunAra.Text + "%'", baglanti);
            }
            else
            {
                dadUrun = new SqlDataAdapter("Select * from urunler", baglanti);
            }

            dadUrun.Fill(ds4);
            dgUrunler.DataSource = ds4.Tables[0];
            baglanti.Close();
        }

        private void dgUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunID.Text = dgUrunler.CurrentRow.Cells[0].Value.ToString();
            txtUrunKodu.Text = dgUrunler.CurrentRow.Cells[1].Value.ToString();
            txtUrunAdi.Text = dgUrunler.CurrentRow.Cells[2].Value.ToString();
            txtUrunAlisFiyati.Text = dgUrunler.CurrentRow.Cells[3].Value.ToString();
            txtSatisFiyati.Text = Convert.ToString(Convert.ToDouble(txtUrunAlisFiyati.Text) * 1.2);
            //txtStokMiktar.Text = dgUrunler.CurrentRow.Cells[4].Value.ToString();

            exeYolu = Application.StartupPath;
            pbUrun.ImageLocation = exeYolu + "\\urunResimler\\" + dgUrunler.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            if ( (txtSatisFiyati.Text != "") &&  (txtUrunID.Text != "") ) {
                if (baglanti.State == ConnectionState.Closed)
                {
                    Bagla();
                }
                SqlCommand komut = new SqlCommand();

                komut = new SqlCommand("insert into siparisDetay(siparisID, urunID, urunSatisFiyati) values (@sipId, @urunId, @satisFiyat)",baglanti);
                komut.Parameters.AddWithValue("@sipId", txtSiparisID.Text);
                komut.Parameters.AddWithValue("@urunId", txtUrunID.Text);
                komut.Parameters.AddWithValue("satisFiyat", txtSatisFiyati.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                txtSiparisID_TextChanged(sender, e);
            }
        }
    }
}
