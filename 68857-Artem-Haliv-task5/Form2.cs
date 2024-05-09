using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _68857_Artem_Haliv_task5
{
    public partial class Form2 : Form
    {
        private int remainingTime = 0;
        bool isGameRunning = false;

        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remainingTime = StatClass.counter / 1000;
            if (!isGameRunning)
            {
                button1.Text = "Guess !";
                timer1.Start();
                isGameRunning = true;
            }
            int number = Convert.ToInt32(textBox1.Text);
            if (number < StatClass.guessed_num)
            {
                lblguess.Text = "Guess Higher !";
            }
            else if (number > StatClass.guessed_num)
            {
                lblguess.Text = "Guess Lower !";
            }
            else if (number == StatClass.guessed_num)
            {
                timer1.Stop();
                MessageBox.Show("You Won!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToMenu();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime--;
            label1.Text = "Time:  " + remainingTime.ToString();

            if (remainingTime <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToMenu();
            }
        }
        private void BackToMenu()
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
     