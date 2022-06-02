namespace My_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        String ButtonVal = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA1_Click(object sender, EventArgs e)
        {
            if (buttonA1.Text == "")
            {
                buttonA1.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {
            if (buttonA2.Text == "")
            {
                buttonA2.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
            }
        }

        private void buttonA3_Click(object sender, EventArgs e)
        {
            if (buttonA3.Text == "")
            {
                buttonA3.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
            }
        }
    }
}