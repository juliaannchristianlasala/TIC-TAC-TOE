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
                if (buttonA1.Text == "X") //horizontal
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonA3.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonA1.Text);
                    }
                }
                else if (buttonA1.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonA3.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonA1.Text);
                    }
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
                if (buttonA2.Text == "X") //horizontal
                {
                    if (buttonA1.Text == "X")
                    {
                        if (buttonA3.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonA2.Text);
                    }
                }
                else if (buttonA2.Text == "O")
                {
                    if (buttonA1.Text == "O")
                    {
                        if (buttonA3.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonA2.Text);
                    }
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
                if (buttonA3.Text == "X") //horizontal
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonA1.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonA3.Text);
                    }
                }
                else if (buttonA3.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonA1.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonA3.Text);
                    }
                }
            }
        }

        private void buttonB1_Click(object sender, EventArgs e)
        {
            if (buttonB1.Text == "")
            {
                buttonB1.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonB1.Text == "X") //horizontal
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonB3.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonB1.Text);
                    }
                }
                else if (buttonB1.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonB3.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonB1.Text);
                    }
                }
            }
        }

        private void buttonB2_Click(object sender, EventArgs e)
        {
            if (buttonB2.Text == "")
            {
                buttonB2.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonB2.Text == "X") //horizontal
                {
                    if (buttonB1.Text == "X")
                    {
                        if (buttonB3.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonB2.Text);
                    }
                }
                else if (buttonB2.Text == "O")
                {
                    if (buttonB1.Text == "O")
                    {
                        if (buttonB3.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonB2.Text);
                    }
                }
            }
        }

        private void buttonB3_Click(object sender, EventArgs e)
        {
            if (buttonB3.Text == "")
            {
                buttonB3.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonB3.Text == "X") //horizontal
                {
                    if (buttonB1.Text == "X")
                    {
                        if (buttonB2.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonB3.Text);
                    }
                }
                else if (buttonB3.Text == "O")
                {
                    if (buttonB1.Text == "O")
                    {
                        if (buttonB2.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonB3.Text);
                    }
                }
            }
        }

        private void buttonC1_Click(object sender, EventArgs e)
        {
            if (buttonC1.Text == "")
            {
                buttonC1.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonC1.Text == "X") //horizontal
                {
                    if (buttonC2.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonB3.Text);
                    }
                }
                else if (buttonC1.Text == "O")
                {
                    if (buttonC2.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonC1.Text);
                    }
                }
            }
        }

        private void buttonC2_Click(object sender, EventArgs e)
        {
            if (buttonC2.Text == "")
            {
                buttonC2.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonC2.Text == "X") //horizontal
                {
                    if (buttonC3.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        MessageBox.Show("You're the Winner " + buttonC2.Text);
                    }
                }
                else if (buttonC2.Text == "O")
                {
                    if (buttonC3.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        MessageBox.Show("You're the Winner " + buttonC2.Text);
                    }
                }
            }
        }

        private void buttonC3_Click(object sender, EventArgs e)
        {
            if (buttonC3.Text == "")
            {
                buttonC3.Text = ButtonVal;
                if (ButtonVal == "X")
                {
                    ButtonVal = "O";
                }
                else
                {
                    ButtonVal = "X";
                }
                if (buttonC3.Text == "X") //horizontal
                {
                    if (buttonC2.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                            MessageBox.Show("You're the Winner " + buttonC3.Text);
                    }
                }
                else if (buttonC3.Text == "O")
                {
                    if (buttonC2.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                            MessageBox.Show("You're the Winner " + buttonC3.Text);
                    }
                }
            }
        }
    }
}