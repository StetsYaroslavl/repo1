namespace WinFormsAppYo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            Point p = new Point(r.Next(0, this.ClientSize.Width - button1.Width), r.Next(0, this.ClientSize.Height - button1.Height));
            button1.Location = p;
        }

        bool turn = true;

        public void check()
        {
            turn = !turn;
            if (button2.Text == button3.Text && button2.Text == button4.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button5.Text == button6.Text && button6.Text == button7.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button8.Text == button9.Text && button8.Text == button10.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button2.Text == button6.Text && button2.Text == button10.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button6.Text == button8.Text && button8.Text == button4.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button6.Text == button3.Text && button6.Text == button9.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
            else if (button7.Text == button10.Text && button7.Text == button4.Text)
            {
                MessageBox.Show("win"); turn = !turn;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button2.Text = "X";
            }
            else
            {
                button2.Text = "O";
            }
            check();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button3.Text = "X";
            }
            else
            {
                button3.Text = "O";
            }
            check();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button4.Text = "X";
            }
            else
            {
                button4.Text = "O";
            }
            check();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button5.Text = "X";
            }
            else
            {
                button5.Text = "O";
            }
            check();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button6.Text = "X";
            }
            else
            {
                button6.Text = "O";
            }
            check();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button7.Text = "X";
            }
            else
            {
                button7.Text = "O";
            }
            check();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button8.Text = "X";
            }
            else
            {
                button8.Text = "O";
            }
            check();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button9.Text = "X";
            }
            else
            {
                button9.Text = "O";
            }
            check();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                button10.Text = "X";
            }
            else
            {
                button10.Text = "O";
            }
            check();
        }

        bool r = true;
    }
}
