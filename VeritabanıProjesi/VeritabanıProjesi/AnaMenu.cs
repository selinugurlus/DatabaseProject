using System;
using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnmüşteri_Click(object sender, EventArgs e)
        {
            MusteriKayitForm mkf = new MusteriKayitForm();
            mkf.ShowDialog();
            this.Hide();
        }

        private void btncalisan_Click(object sender, EventArgs e)
        {
            Form1 gkf = new Form1();
            gkf.ShowDialog();
            this.Hide();
        }

        private void Faturabutton_Click(object sender, EventArgs e)
        {
            FaturaForm ff = new FaturaForm();
            ff.ShowDialog();
            this.Hide();
        }
    }
}
