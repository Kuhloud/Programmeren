using System.Diagnostics;
using System.Globalization;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {
            const double VatRate = 0.21;
           
            //set culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // input price
            double Prijs = double.Parse(txtInput.Text);

            
            
            double VatPrijs = Prijs * VatRate;

            double Totaal = VatPrijs + Prijs;

            lblPrijsAnt.Text = $"{Prijs:0.00}";
            lblVATAnt.Text = $"{VatPrijs:0.00}";
            lblTotaalAnt.Text = $"{Totaal:0.00}";
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}