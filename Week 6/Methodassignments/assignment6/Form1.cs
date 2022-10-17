namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSquareByReference_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            SquareByReference(ref number);
            lblResultAns.Text = $"{number}";

        }
        static void SquareByReference(ref int number)
        {
            number = number * number;
        }


        private void btnSquareByReferenceOut_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            int square;
            SquareByReferenceOut(number, out square);
            lblResultAns.Text = $"{square}";
        }
        static void SquareByReferenceOut(int number, out int square)
        {
            square = number * number;
        }


        private void btnSquareByValue_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtInput.Text);
            number = SquareByValue(number);
            lblResultAns.Text = $"{number}";
        }
        static int SquareByValue(int number)
        {
            number = number * number;
            return number;
        }
    }
}