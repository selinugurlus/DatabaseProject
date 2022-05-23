using System.Windows.Forms;

namespace VeritabanıProjesi
{
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }

        private void btnOde_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Kredi kartı bilginiz onaylanmıştır. İYİ TATİLLER.");
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AnaMenu a = new AnaMenu();
            a.ShowDialog();
            this.Hide();
        }
    }
}
