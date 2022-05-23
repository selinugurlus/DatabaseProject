using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class CalisanRaporForm : Form
    {
        public CalisanRaporForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=OtelOtomasyonu;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);

        private void Bugungeleceklerlistelebutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * From BugunGelecekler order by musteri_adsoyad", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void GunlukDolulukbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select * From GunlukDoluluk order by oda_no", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
        }

        private void CiktiKaydetbutton_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\Ekran_Resimleri");
            var frm = Form.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(@"C:\Ekran_Resimleri\ekrangoruntusu2.png");
            }
            MessageBox.Show("Rapor Ekran_Resimleri klasöründe kaydedildi. Çıktı alabilirsiniz");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }
    }
}
