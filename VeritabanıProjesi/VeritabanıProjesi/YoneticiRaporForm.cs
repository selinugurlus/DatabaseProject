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
    public partial class YoneticiRaporForm : Form
    {
        public YoneticiRaporForm()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-CS90DTMS\\MSSQL;Initial Catalog=OtelOtomasyonu;Integrated Security=True";
        SqlConnection baglan = new SqlConnection(constring);

   
       
        private void BeklenenDolulukLİstelebutton_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("select *  From BeklenenDoluluk ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglan.Close();
            SqlCommand cmd = new SqlCommand("select count(*) from BeklenenDoluluk", baglan);
            baglan.Open();
            int kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            textBox1.Text = kayitSayisi.ToString();
            baglan.Close();
        }

        private void BeklenenGelirbutton_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("select *  From BeklenenGelir ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand kmt = new SqlCommand("select sum([odenecek_tutar])as toplam from [BeklenenGelir]", baglan);
            BeklenenGelirtextBox.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

            SqlCommand kmt2 = new SqlCommand("select avg([odenecek_tutar])as toplam from [BeklenenGelir]", baglan);
            BeklenenORtGElirtextBox.Text = kmt2.ExecuteScalar().ToString();
            kmt2.ExecuteNonQuery();

            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();

            SqlCommand komut = new SqlCommand("select *  From TesvikRaporu2 ", baglan);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand kmt = new SqlCommand("select sum([odenecek_tutar]/4)as toplam from [TesvikRaporu2]", baglan);
            TesviktextBox.Text = kmt.ExecuteScalar().ToString();
            kmt.ExecuteNonQuery();

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

        private void button2_Click(object sender, EventArgs e)
        {
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }
    }
}
