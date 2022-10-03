namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int size = int.Parse(txtInput.Text);
            string pattern ="";
            for (int i = 1; i <= size; i++)
            {
                pattern += "X";
            }
            for (int i = 1; i <= size - 2; i++)
            {
                pattern += "X";
                for (int j = 1; j <= size - 2; j++)
                {
                    pattern += " ";
                }
            pattern += "X\n";
            }
            for (int i = 1; i <= size; i++)
            {
                pattern += "X";
            }
            lblX.Text = pattern;
        }
    }
}