using System.Globalization;
using System.Resources;

namespace Lokalisierung
{
    public partial class Form1 : Form
    {
        private ResourceManager rm = new ResourceManager("Lokalisierung.MeineTexte", typeof(Form1).Assembly);

        public Form1()
        {
            /* Thread.CurrentThread.CurrentUICulture = new CultureInfo("de"); */
            /* Thread.CurrentThread.CurrentUICulture = new CultureInfo("en"); */
            /* Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr"); */
            InitializeComponent();
        }

        private void BtnEins_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungEins"));
        }

        private void BtnZwei_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("meldungZwei"));
        }
    }
}