using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class MusteriKayitForm : Form
    {
        public MusteriKayitForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=OtelOtomasyonu;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
       



        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string mail = GirisMailtextBox.Text;
            string sifre = GirisSifretextBox.Text;
            SqlCommand komut = new SqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "Select*from Musteri_Bilgileri where musteri_mail='" + GirisMailtextBox.Text+"'And musteri_sifre='"+GirisSifretextBox.Text+"'";
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                MessageBox.Show("Giriş başarılı.");
                RezKullanıcıGirişiForm rezkgiris = new RezKullanıcıGirişiForm();
                rezkgiris.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı mail veya sifre");
            }
            baglan.Close();
            
            
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    string Rez = "insert into Musteri_Bilgileri (musteri_tc,musteri_adsoyad,musteri_mail,musteri_telno,musteri_sifre)values(@musteri_tc,@musteri_adsoyad,@musteri_mail,@musteri_telno,@musteri_sifre)";

                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@musteri_tc", TCNOtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_adsoyad",UyeOlAdSoyadtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_mail",UyeOlMailtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_telno",UyeOlTelNotextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_sifre", UyeOlSifretextBox.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Kaydınız yapılmıştır.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
            RezKullanıcıGirişiForm rezkgiris = new RezKullanıcıGirişiForm();
            rezkgiris.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }
    }
}
