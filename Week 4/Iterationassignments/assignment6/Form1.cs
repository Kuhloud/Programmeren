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
            for (int i = 0; i < Years; i++)
            {
                startAmount = startAmount * annualInterest;
            }
            lblFinalCapitalAns.Text = $"€{startAmount:0.00}";
        }

    }
}