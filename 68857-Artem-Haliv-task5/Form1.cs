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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int min_num = Convert.ToInt32(textBox1.Text);
                int max_num = Convert.ToInt32(textBox2.Text);
                StatClass.guessed_num = rnd.Next(min_num, max_num);
                string items = comboBox1.SelectedItem.ToString();
                switch (items)
                {
                    case "Easy":
                        StatClass.counter = 70000;
                        break;
                    case "Medium":
                        StatClass.counter = 60000;
                        break;
                    case "Hard":
                        StatClass.counter = 40000;
                        break;
                    case "GOD MODE":
                        StatClass.counter = 25000;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
