using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class YoneticiGirisForm : Form
    {
        public YoneticiGirisForm()
        {
            InitializeComponent();
        }

        private void YoneticiGirisbutton_Click(object sender, EventArgs e)
        {
            if (YoneticiKAditextBox.Text == "yönetici" && YoneticiSifretextBox.Text == "yönetici123")
            {
                MessageBox.Show("Giriş başarılı");
                YoneticiRaporForm yrf = new YoneticiRaporForm();
                yrf.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı");
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
