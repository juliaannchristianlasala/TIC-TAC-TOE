namespace My_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        String ButtonVal = "X";
        int counter = 0;

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
                if (buttonA1.Text == "X") //horizontal A1
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonA3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA1.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonA3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonA1.Text == "X") //vertical A1
                {
                    if (buttonB1.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA1.Text == "O")
                {
                    if (buttonB1.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonA1.Text == "X") //diagonal A1
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA1.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonA2.Text == "X") //horizontal A2
                {
                    if (buttonA1.Text == "X")
                    {
                        if (buttonA3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA2.Text == "O")
                {
                    if (buttonA1.Text == "O")
                    {
                        if (buttonA3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if(buttonA2.Text == "X") //vertical A2
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonC2.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA2.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonC2.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonA3.Text == "X") //horizontal A3
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonA1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA3.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonA1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if(buttonA3.Text == "X") //vertical A3
                {
                    if (buttonB3.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonA3.Text == "O")
                {
                    if (buttonB3.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonA3.Text == "X") //diagonal A3
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter=0;
                        }
                    }
                }
                else if (buttonA3.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonA3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonB1.Text == "X") //horizontal B1
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonB3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB1.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonB3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonB1.Text == "X") //vertical B1
                {
                    if (buttonA1.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB1.Text == "O")
                {
                    if (buttonA1.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonB2.Text == "X") //horizontal B2
                {
                    if (buttonB1.Text == "X")
                    {
                        if (buttonB3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB2.Text == "O")
                {
                    if (buttonB1.Text == "O")
                    {
                        if (buttonB3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonB2.Text == "X") //vertical B2
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonC2.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB2.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonC2.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonB2.Text == "X") //diagonal B2
                {
                    if (buttonA1.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB2.Text == "O")
                {
                    if (buttonA1.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonB2.Text == "X") //diagonal B2
                {
                    if (buttonA3.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB2.Text == "O")
                {
                    if (buttonA3.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonB3.Text == "X") //horizontal B3
                {
                    if (buttonB1.Text == "X")
                    {
                        if (buttonB2.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB3.Text == "O")
                {
                    if (buttonB1.Text == "O")
                    {
                        if (buttonB2.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonB3.Text == "X") //vertical B3
                {
                    if (buttonA3.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonB3.Text == "O")
                {
                    if (buttonA3.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonB3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonC1.Text == "X") //horizontal C1
                {
                    if (buttonC2.Text == "X")
                    {
                        if (buttonC3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC1.Text == "O")
                {
                    if (buttonC2.Text == "O")
                    {
                        if (buttonC3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonC1.Text == "X") //vertical C1
                {
                    if (buttonA1.Text == "X")
                    {
                        if (buttonB1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC1.Text == "O")
                {
                    if (buttonA1.Text == "O")
                    {
                        if (buttonB1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonC1.Text == "X") //diagonal C1
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonA3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC1.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonA3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC1.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonC2.Text == "X") //horizontal C2
                {
                    if (buttonC3.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC2.Text == "O")
                {
                    if (buttonC3.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonC2.Text == "X") //vertical C2
                {
                    if (buttonA2.Text == "X")
                    {
                        if (buttonB2.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC2.Text == "O")
                {
                    if (buttonA2.Text == "O")
                    {
                        if (buttonB2.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC2.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
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
                if (buttonC3.Text == "X") //horizontal C3
                {
                    if (buttonC2.Text == "X")
                    {
                        if (buttonC1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC3.Text == "O")
                {
                    if (buttonC2.Text == "O")
                    {
                        if (buttonC1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonC3.Text == "X") //vertical C3
                {
                    if (buttonA3.Text == "X")
                    {
                        if (buttonB3.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC3.Text == "O")
                {
                    if (buttonA3.Text == "O")
                    {
                        if (buttonB3.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                if (buttonC3.Text == "X") //diagonal C3
                {
                    if (buttonB2.Text == "X")
                    {
                        if (buttonA1.Text == "X")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                else if (buttonC3.Text == "O")
                {
                    if (buttonB2.Text == "O")
                    {
                        if (buttonA1.Text == "O")
                        {
                            MessageBox.Show("Yay! You're the Winner " + buttonC3.Text);
                            buttonA1.Text = "";
                            buttonA2.Text = "";
                            buttonA3.Text = "";
                            buttonB1.Text = "";
                            buttonB2.Text = "";
                            buttonB3.Text = "";
                            buttonC1.Text = "";
                            buttonC2.Text = "";
                            buttonC3.Text = "";
                            counter = 0;
                        }
                    }
                }
                counter = counter + 1;
                if (counter == 9)
                {
                    MessageBox.Show("DRAW");
                    counter = 0;
                    buttonA1.Text = "";
                    buttonA2.Text = "";
                    buttonA3.Text = "";
                    buttonB1.Text = "";
                    buttonB2.Text = "";
                    buttonB3.Text = "";
                    buttonC1.Text = "";
                    buttonC2.Text = "";
                    buttonC3.Text = "";
                }
            }
        }
    }
}