namespace assignment6
{
    public partial class Form1 : Form
    {
        const double AnnualInterestRate = 1.05;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double startAmount = double.Parse(txtInput.Text);
            double finalCapital = startAmount * Math.Pow(AnnualInterestRate, 5);
            lblFinalCapitalAns.Text = $"€{finalCapital:0.00}";
        }
    }
}