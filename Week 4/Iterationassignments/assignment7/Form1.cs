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
            for (int i = 0; i <= size; i++)
            {
                pattern += "X";
            } lblX.Text = pattern;
        }   
    }
}