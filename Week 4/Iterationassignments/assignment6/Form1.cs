namespace assignment6
{
    public partial class Form1 : Form
    {
        const double AnnualInterestRate = 0.05;
        const int Years = 5;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double startAmount = double.Parse(txtInput.Text);
            double annualInterest = AnnualInterestRate + 1;
            double finalCapital = startAmount;
            lblFinalCapitalAns.Text = $"€{finalCapital:0.00}";
            for (int i = 0; 1 <= Years; i++)
            {
                startAmount = startAmount * annualInterest;
            }
        }
    }
}