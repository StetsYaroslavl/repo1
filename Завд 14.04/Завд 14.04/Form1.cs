using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завд_14._04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();
        public bool turn = true;

        public void chek() 
        {
            if (button3.Text == button4.Text && button2.Text == button4.Text) 
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else 
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button7.Text == button4.Text && button4.Text == button10.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button5.Text == button6.Text && button6.Text == button7.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button10.Text == button9.Text && button9.Text == button8.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button2.Text == button6.Text && button6.Text == button10.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            else if (button6.Text == button4.Text && button4.Text == button8.Text)
            {
                if (turn)
                {
                    MessageBox.Show("Перемога хрестиків!");
                }
                else
                {
                    MessageBox.Show("Перемога ноликів!");
                }
            }
            turn = !turn;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Point p = new Point(r.Next(0, 500), r.Next(0, 300));
            button1.Location = p;
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
            chek();
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
            chek();
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
            chek();
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
            chek();
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
            chek();
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
            chek();
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
            chek();
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
            chek();
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
            chek();
        }
    }
}
