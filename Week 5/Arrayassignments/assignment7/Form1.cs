using System;

namespace assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int HeadsOfDice = 7;
        const int TotalRepeats = 6000;
        private void btnThrow_Click(object sender, EventArgs e)
        {
            int[] dice = new int[HeadsOfDice];


            for (int i = 1; i < dice.Length; i++)
            {
                dice[i] = 0;
            }

                int valueOfThrows = dice[1];
                for (int j = 0; j <= TotalRepeats; j++)
                {
                    Random rnd = new Random();
                    valueOfThrows = rnd.Next(1, 7); // 1..6
                dice[valueOfThrows] = dice[valueOfThrows] + 1;

                }
                string lblThrowAmounts = "";
                for ( int i = 1; i < dice.Length; i++)
                {
                    lblThrowAmounts += $"Number of throws of value {i} = {dice[i]}\n";

                }
                lblThrows.Text = lblThrowAmounts;
        }
    }
}