using System.Globalization;

namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // input
            int Seconds = int.Parse(txtInput.Text);

            // bereken tijd
            int uren = Seconds / 3600;
            int urenrest = Seconds % 3600;

            int minuten = urenrest / 60;
            int seconden = urenrest % 60;

            lblTimeAnt.Text = $"{uren:00}:{minuten:00}:{seconden:00}";
        }
    }
}