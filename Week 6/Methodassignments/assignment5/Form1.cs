namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtInput1.Text);
            int secondNumber = int.Parse(txtInput2.Text);
            int answerAdd = AddCalculation(firstNumber, secondNumber);
            lblResultAns.Text = $"{answerAdd}";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtInput1.Text);
            int secondNumber = int.Parse(txtInput2.Text);
            int answerSubtract = SubtractCalculation(firstNumber, secondNumber);
            lblResultAns.Text = $"{answerSubtract}";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtInput1.Text);
            int secondNumber = int.Parse(txtInput2.Text);
            int answerMultiply = MultiplyCalculation(firstNumber, secondNumber);
            lblResultAns.Text = $"{answerMultiply}";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtInput1.Text);
            int secondNumber = int.Parse(txtInput2.Text);
            double answerDivide = DivideCalculation(firstNumber, secondNumber);
            lblResultAns.Text = $"{answerDivide}";
        }

        public int AddCalculation(int firstNumber, int secondNumber)
        {
            int answerAdd = firstNumber + secondNumber;
            return answerAdd;
        }

        public int SubtractCalculation(int firstNumber, int secondNumber)
        {
            int answerSubtract = firstNumber - secondNumber;
            return answerSubtract;
        }

        public int MultiplyCalculation(int firstNumber, int secondNumber)
        {
            int answerMultiply = firstNumber * secondNumber;
            return answerMultiply;
        }
        public double DivideCalculation(int firstNumber, int secondNumber)
        {
            double answerDivide = firstNumber / (double)secondNumber;
            return answerDivide;
        }
    }
}