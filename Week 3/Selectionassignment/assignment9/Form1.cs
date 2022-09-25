namespace assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {;
            // input sport
            int age = int.Parse(txtInput1.Text);
            int membershipDuration = int.Parse(txtInput2.Text);
            int price = 0;

            // determine value of radioboxes
            if (radFootball.Checked == true)
            {
                price = 175;
            }
            else if (radHandball.Checked == true)
            {
                price = 225;
            }
            else
            {
                price = 0;
            }

            // add discount
            if (age >= 40 || radHandball.Checked == true & radFootball.Checked == true)
            {
                price -= 25;
            }
            if (membershipDuration >= 10 || radHandball.Checked == true & radFootball.Checked == true)
            {
                price -= 20;
            }

            // display fee
            lblFeeAns.Text = $"€ {price:0.00}";



        }
    }
}