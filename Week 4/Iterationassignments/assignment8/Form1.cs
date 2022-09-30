namespace assignment8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // input number
            int n = int.Parse(txtInput.Text);

            // formula 1
            int sum1 = 0;
            for (int i = 1; i <= n; i++)
            {
                sum1 += i;
                lblFormula1Ans.Text = $"{sum1}";
            }       
                
            // formula 2
            int sum2 = n * (n + 1) / 2;
            lblFormula2Ans.Text = $"{sum2}";


            if (sum1 == sum2)
            {
                lblCheck.Text = "The sum and formula are equal.";
            }
            else
            {
                lblCheck.Text = "The sum and formula are not equal.";
            }
        }   
    }
}