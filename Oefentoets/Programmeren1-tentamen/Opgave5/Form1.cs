namespace Opgave5
{
    public partial class Form1 : Form
    {
        const string SpeedAnswer = "Snelheid (km/uur)";
        const int SecondsInHours = 3600;
        const int SecondsInMinutes = 60;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int distanceInKilometers;

            if(rad5km.Checked)
            {
                distanceInKilometers = 5;
            }
            else if (rad10km.Checked)
            {
                distanceInKilometers = 10;
            }
            else
            {
                distanceInKilometers = 21;
            }

            int totalSeconds = (int.Parse(txtHours.Text) * SecondsInHours) + (int.Parse(txtMinutes.Text) * SecondsInMinutes + (int.Parse(txtSeconds.Text))

                double hoursWalked = (double)totalSeconds / SecondsInHours;

            double speed = distanceInKilometers / hoursWalked;

            speedAnswerLabel.Text = $"{S}
        }   

    }
}