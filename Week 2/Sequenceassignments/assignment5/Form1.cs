using System.Globalization;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //set culture
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // initialize input
            double Number1 = double.Parse(txtInput1.Text);
            double Number2 = double.Parse(txtInput2.Text);
            double Number3 = double.Parse(txtInput3.Text);

            // read average
            double Average = (Number1 + Number2 + Number3) / 3;

            lblAverageAnt.Text = $"{Average:0.000}";
        }
    }
}