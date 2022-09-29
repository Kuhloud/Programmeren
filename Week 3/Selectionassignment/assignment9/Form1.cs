namespace assignment9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalc_Click(object sender, EventArgs e)
        {
            // input sport
            int age = int.Parse(txtInput1.Text);
            int membershipDuration = int.Parse(txtInput2.Text);
            double fee = 0;

            // determine value of radioboxes
            if (radFootball.Checked == true)
            {
                fee = 175;
            }
            else if (radHandball.Checked == true)
            {
                fee = 225;
            }
            
            // add discount
            if (radHandball.Checked == true | radFootball.Checked == true && age > 40)
            {
                fee -= 25;
            }

            if (radHandball.Checked == true | radFootball.Checked == true && membershipDuration > 10 )
            {
                fee -= 20;
            }

            // display fee
            lblFeeAns.Text = $"€ {fee:0.00}";



        }
    }
}