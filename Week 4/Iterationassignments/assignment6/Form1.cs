namespace assignment6
{
    public partial class Form1 : Form
    {
        const double AnnualInterestRate = 0.05;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            double startAmount = double.Parse(txtInput.Text);
            double annualInterest = 1.05;
            for (double n = 0; n <= 5; n++);
            double finalCapital = startAmount * annualInterest;
            lblFinalCapitalAns.Text = $"€{finalCapital:0.00}";
        }
    }
}