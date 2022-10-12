namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int MaxElements = 20;
        Random element = new Random();
        int[] elementBefore = new int[MaxElements];
        int[] elementAfter = new int[MaxElements];
        private void Form1_Load(object sender, EventArgs e)
        {
            // display elements before 
            string lblElementsBefore = "";
            for (int i = 0; i < MaxElements; i++)
            {
                elementBefore[i] = element.Next(501); // randomizes numbers
                lblElementsBefore += $"Element {i:00} = {elementBefore[i]}\n"; // adds new label
            }
            // display content table before
            lblBefore.Text = lblElementsBefore; 
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            // input comparison number
            int comparisonNumber = int.Parse(txtInput.Text);
            string lblElementsAfter = "";
            btnComp.Enabled = false;

            for (int i = 0; i < MaxElements; i++)
            {
                // if comparison number is lower than the element
                if (elementBefore[i] >= comparisonNumber)
                {
                    lblElementsAfter += $"Element {i:00} = {elementBefore[i] + 10}\n"; // adds new label
                }
                // if comparison number is higher than the element
                else if (elementBefore[i] < comparisonNumber)
                {
                    lblElementsAfter += $"Element {i:00} = {elementBefore[i] - 5}\n"; // adds new label
                }
                // display content table after
                lblAfter.Text = lblElementsAfter;
            }
        }
    }
}