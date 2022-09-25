using System.Globalization;

namespace assignment7
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
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            double StartKm = double.Parse(txtInput1.Text);
            double EndKm = double.Parse(txtInput2.Text);
            double PriceKm = double.Parse(txtInput3.Text);

            double Price = (EndKm - StartKm) * PriceKm;
            double VAT = VatRate * Price;
            double VatPrice = VAT + Price;

            lblPriceAnt.Text = $"{Price:0.00}";
            lblVatAnt.Text = $"{VAT:0.00}";
            lblVatPriceAnt.Text = $"{VatPrice:0.00}";
            


        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
            txtInput3.Text = "";
            lblPriceAnt.Text = "0.00";
            lblVatAnt.Text = "0.00";
            lblVatPriceAnt.Text = "0.00";
        }
    }
}