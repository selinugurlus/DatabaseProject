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
    public partial class AnaMenuForm : Form
    {
        public AnaMenuForm()
        {
            InitializeComponent();
        }

        private void YoneticiGirisButton_Click(object sender, EventArgs e)
        {
            YoneticiGiris yonetici = new YoneticiGiris();
            yonetici.Show();
            this.Hide();

        }

        private void CalisanGirisButton_Click(object sender, EventArgs e)
        {
            CalisanGiris calisan = new CalisanGiris();
            calisan.Show();
            this.Hide();
        }

        private void RezOlusturButton_Click(object sender, EventArgs e)
        {
            RezOlusturma RezOlustur = new RezOlusturma();
            RezOlustur.Show();
            this.Hide();
        }

        private void btnmüşteri_Click(object sender, EventArgs e)
        {

        }
    }
}
