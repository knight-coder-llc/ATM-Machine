using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM_Machine
{
    public partial class CustomerInputForm : Form
    {
        public CustomerInputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Withdrawing $" + $"{textBox1.Text} from your account");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
