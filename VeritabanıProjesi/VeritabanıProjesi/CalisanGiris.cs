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
    public partial class CalisanGiris : Form
    {
        public CalisanGiris()
        {
            InitializeComponent();
        }

        private void CalisanGİrisbutton_Click(object sender, EventArgs e)
        {
            if(CalisanKAditextBox.Text=="çalışan" && CalisanSİfretextBox.Text=="çalışan123")
            {    MessageBox.Show("Giriş başarılı");
                CalisanRaporForm crf = new CalisanRaporForm();
                crf.ShowDialog();
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
