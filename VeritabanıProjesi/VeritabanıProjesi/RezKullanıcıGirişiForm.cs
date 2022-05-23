using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class RezKullanıcıGirişiForm : Form
    {
        public RezKullanıcıGirişiForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=OtelOtomasyonu;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);
        public int kapasite = 100;
        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void Button2_Click(object sender, System.EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();

                    string Rez = "insert into RezBilgileri (musteri_tc,musteri_mail,sezon,rez_tipi,giris_tarihi,cikis_tarihi,odenecek_tutar,oda_no)values(@musteri_tc,@musteri_mail,@sezon,@rez_tipi,@giris_tarihi,@cikis_tarihi,@odenecek_tutar,@oda_no)";
                    SqlCommand komut = new SqlCommand(Rez, baglan);
                    komut.Parameters.AddWithValue("@musteri_tc", TCNOtextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_mail", RezMailtextBox.Text);
                    komut.Parameters.AddWithValue("@rez_tipi", RezSeceneklericomboBox.Text);
                    komut.Parameters.AddWithValue("@sezon", SezoncomboBox.Text);
                    komut.Parameters.AddWithValue("@giris_tarihi", GirisTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@cikis_tarihi", CikisTarihidateTimePicker.Value);
                    komut.Parameters.AddWithValue("@odenecek_tutar", OdenecektutartextBox.Text);
                    komut.Parameters.AddWithValue("@oda_no", kapasite);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Rezervasyonunuz yapılmıştır.");
                    kapasite--;
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }

            OdemeForm odeme = new OdemeForm();
            odeme.ShowDialog();

        }

        public void UcretHesapla()
        {
            if (RezSeceneklericomboBox.Text == "Standart rezervasyon")
            {
                if (SezoncomboBox.Text == "Kış")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 100;
                    OdenecektutartextBox.Text = ucret.ToString();
                }
                if (SezoncomboBox.Text == "Yaz")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 200;
                    OdenecektutartextBox.Text = ucret.ToString();
                }
            }
            else if (RezSeceneklericomboBox.Text == "Ön ödemeli rezervasyon")
            {
                if (SezoncomboBox.Text == "Kış")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 75;
                    OdenecektutartextBox.Text = ucret.ToString();
                }

                if (SezoncomboBox.Text == "Yaz")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 140;
                    OdenecektutartextBox.Text = ucret.ToString();
                }
            }
            else if (RezSeceneklericomboBox.Text == "60  gün  önceden  rezervasyon")
            {
                if (SezoncomboBox.Text == "Kış")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 85;
                    OdenecektutartextBox.Text = ucret.ToString();

                }

                if (SezoncomboBox.Text == "Yaz")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 170;
                    OdenecektutartextBox.Text = ucret.ToString();
                }
            }
            else if (RezSeceneklericomboBox.Text == "Teşvik rezervasyon" && kapasite <= 60)
            {
                if (SezoncomboBox.Text == "Kış")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 80;
                    OdenecektutartextBox.Text = ucret.ToString();
                }

                if (SezoncomboBox.Text == "Yaz")
                {
                    int ucret;
                    DateTime giristarihi = Convert.ToDateTime(GirisTarihidateTimePicker.Text);
                    DateTime cikistarihi = Convert.ToDateTime(CikisTarihidateTimePicker.Text);
                    TimeSpan kalınangun = cikistarihi - giristarihi;
                    gunTextbox.Text = kalınangun.TotalDays.ToString();
                    ucret = Convert.ToInt32(gunTextbox.Text) * 160;
                    OdenecektutartextBox.Text = ucret.ToString();
                }
            }
        }
        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void Hesaplabutton_Click(object sender, EventArgs e)
        {
            UcretHesapla();
        }

        private void RezBulButton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * From RezBilgileri Where musteri_tc='" + RezGetirTCtextBox.Text + "'", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void RezİptalEtbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("delete from RezBilgileri  Where musteri_tc='" + RezGetirTCtextBox.Text + "'", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("REZERVASYONUNUZ İPTAL EDİLMİŞTİR!");
        }
        public void UcretGuncelle()
        {
            if (RezTipiGuncelcomboBox.Text == "Standart rezervasyon")
            {
                if (RezGuncelleSezoncomboBox.Text == "Kış")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 100;
                    YeniUcrettextBox.Text = ucret1.ToString();
                }
                if (RezGuncelleSezoncomboBox.Text == "Yaz")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 200;
                    YeniUcrettextBox.Text = ucret1.ToString();
                }
            }
            if (RezTipiGuncelcomboBox.Text == "Ön ödemeli rezervasyon")
            {
                if (RezGuncelleSezoncomboBox.Text == "Kış")
                {
                    int ucret1;
                    DateTime giristarihi1= Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 75+10;
                    YeniUcrettextBox.Text = ucret1.ToString();
                    MessageBox.Show("Bilgilendirme:Güncellenme sebebiyle %10 Oranında ek ücret eklenmiştir.");
                }

                if (RezGuncelleSezoncomboBox.Text == "Yaz")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 140+20;
                    YeniUcrettextBox.Text = ucret1.ToString();
                    MessageBox.Show("Bilgilendirme:Güncellenme sebebiyle %10 Oranında ek ücret eklenmiştir.");
                }
            }
             if (RezTipiGuncelcomboBox.Text == "60  gün  önceden  rezervasyon")
            {
                if (RezGuncelleSezoncomboBox.Text == "Kış")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1= cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 85+10;
                    YeniUcrettextBox.Text = ucret1.ToString();
                    MessageBox.Show("Bilgilendirme:Güncellenme sebebiyle %10 Oranında ek ücret eklenmiştir.");

                }

                if (RezGuncelleSezoncomboBox.Text == "Yaz")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 170+20;
                    YeniUcrettextBox.Text = ucret1.ToString();
                    MessageBox.Show("Bilgilendirme:Güncellenme sebebiyle %10 Oranında ek ücret eklenmiştir.");
                }
            }
            if (RezTipiGuncelcomboBox.Text == "Teşvik rezervasyon" && kapasite <= 60)
            {
                if (RezGuncelleSezoncomboBox.Text == "Kış")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 80;
                    YeniUcrettextBox.Text = ucret1.ToString();
                }

                if (RezGuncelleSezoncomboBox.Text == "Yaz")
                {
                    int ucret1;
                    DateTime giristarihi1 = Convert.ToDateTime(GuncelleGİRİSdateTimePicker.Text);
                    DateTime cikistarihi1 = Convert.ToDateTime(GuncelleCİKİSdateTimePicker.Text);
                    TimeSpan kalınangun1 = cikistarihi1 - giristarihi1;
                    YeniGuntextBox.Text = kalınangun1.TotalDays.ToString();
                    ucret1 = Convert.ToInt32(YeniGuntextBox.Text) * 160;
                    YeniUcrettextBox.Text = ucret1.ToString();
                }
            }
        }
        private void RezGuncelleUcretbutton_Click(object sender, EventArgs e)
        {
            UcretGuncelle();
        }
        private void RezGuncellebutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                    SqlCommand komut = new SqlCommand("Update RezBilgileri  set giris_tarihi=@giris_tarihi,cikis_tarihi=@cikis_tarihi,odenecek_tutar=@odenecek_tutar Where musteri_tc=@musteri_tc", baglan);
                    komut.Parameters.AddWithValue("@giris_tarihi", GuncelleGİRİSdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@cikis_tarihi", GuncelleCİKİSdateTimePicker.Value);
                    komut.Parameters.AddWithValue("@odenecek_tutar", YeniUcrettextBox.Text);
                    komut.Parameters.AddWithValue("@musteri_tc", RezGetirTCtextBox.Text);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("REZERVASYONUNUZ GÜNCELLENMİŞTİR.");

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("hata" + hata.Message);

            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }
    }
}
