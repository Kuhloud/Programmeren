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
            int numberInput = int.Parse(txtInput.Text);

            // sum
            int sum = 0;
            for (int i = 1; i <= numberInput; i++)
            {
                sum += i;
                lblFormula1Ans.Text = $"{sum}";
            }       
                
            // formula 
            int formula = numberInput * (numberInput + 1) / 2;
            lblFormula2Ans.Text = $"{formula}";


            if (sum == formula)
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