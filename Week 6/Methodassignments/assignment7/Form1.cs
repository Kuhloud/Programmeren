namespace assignment7
{
    public partial class cheConversion : Form
    {
        public cheConversion()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double convertedDegrees = 0;
            double degrees = double.Parse(txtInput.Text);
            if (radCel2Kel.Checked == true)
            {
                convertedDegrees = Celsius2Kelvin(degrees);
            }
            else if (radCel2Fah.Checked == true)
            {
                convertedDegrees = Celsius2Fahrenheit(degrees);
            }
            else
            {
                convertedDegrees = Fahrenheit2Celsius(degrees);
            }
            lblConvertedAns.Text = $"{convertedDegrees:0.00}";
        }
        public double Celsius2Kelvin(double degrees)
        {
            return degrees + 273;
        }

        public double Celsius2Fahrenheit(double degrees)
        {
            return degrees * 9/5 + 32;
        }
        public double Fahrenheit2Celsius(double degrees)
        {
            return (degrees - 32) * 5/9;
        }
    }
}