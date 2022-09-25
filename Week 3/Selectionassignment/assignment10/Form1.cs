namespace assignment10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int setPrice = 12;
        private void btnCalc_Click(object sender, EventArgs e)
        {
        int age = int.Parse(txtInput.Text);
        int free = setPrice - setPrice;
        int halfPrice = setPrice / 2;

        switch (age)
            {
             case >= 0 and < 5:
                lblPriceTicketAns.Text = ($"€ {free:0.00}");
                    break;
            case >= 5 and <= 12:
                lblPriceTicketAns.Text = ($"€ {halfPrice:0.00}");
                break;
            case >= 13 and <= 54:
                lblPriceTicketAns.Text = ($"€ {setPrice:0.00}");
                break;
            case >= 55:
                lblPriceTicketAns.Text = ($"€ {free:0.00}");
                    break;
            }
        

        }
    }
}