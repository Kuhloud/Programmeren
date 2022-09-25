using System.Globalization;

namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double VatRate = 0.21;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            

            int Tshirt = int.Parse(txtInput1.Text);
            int Jeans = int.Parse(txtInput2.Text);

            double Price = (Tshirt * 30.00) + (Jeans * 100.00);
            double Vat = VatRate * Price;
            double VatPrice = Vat + Price;

            lblPriceAnt.Text = $"€ {Price:0.00}";
            lblVatAnt.Text = $"€ {Vat:0.00}";
            lblTotalAnt.Text = $"€ {VatPrice:0.00}";
            lblNiks1.Text = "";
            lblNiks2.Text = "";

            DateTime Date = DateTime.Now;
            lblDateAnt.Text = Date.ToString();


        }
    }
}