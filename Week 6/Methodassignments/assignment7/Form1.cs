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
            else if (radFah2Cel.Checked == true)
            {
                convertedDegrees = Fahrenheit2Celsius(degrees);
            }
            lblConvertedAns.Text = $"{convertedDegrees:0.00}";
        }
        public double Celsius2Kelvin(double degrees)
        {
            double convertedDegrees = degrees + 273;
            return convertedDegrees;
        }

        public double Celsius2Fahrenheit(double degrees)
        {
            double convertedDegrees = degrees * 9/5 + 32;
            return convertedDegrees;
        }
        public double Fahrenheit2Celsius(double degrees)
        {
            double convertedDegrees = (degrees - 32) * 5 / 9;
            return convertedDegrees;
        }
    }
}