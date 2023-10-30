using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmldoc = new XmlDocument();
            xmldoc.Load(today);
            string usdbuy = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblusdb.Text = usdbuy;
            string usdsell = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblusds.Text = usdsell;
            string eurbuy = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lbleurb.Text = eurbuy;
            string eursell = xmldoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lbleurs.Text = eursell;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnub_Click(object sender, EventArgs e)
        {
            txtrate.Text = lblusdb.Text;
        }

        private void btnus_Click(object sender, EventArgs e)
        {
            txtrate.Text = lblusds.Text;
        }

        private void btneb_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbleurb.Text;
        }

        private void btnes_Click(object sender, EventArgs e)
        {
            txtrate.Text = lbleurs.Text;
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            double rate, amount, exchanged;
            rate = Convert.ToDouble(txtrate.Text);
            amount = Convert.ToDouble(txtamount.Text);
            exchanged = amount * rate;
            txtqu.Text = exchanged.ToString();

        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rate, amount, exchanged;
            rate = Convert.ToDouble(txtrate.Text);
            amount = Convert.ToDouble(txtamount.Text);
            exchanged = amount / rate;
            txtqu.Text = exchanged.ToString();
        }
    }
}