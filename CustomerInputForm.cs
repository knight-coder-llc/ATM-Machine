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
using System.Text.RegularExpressions;

namespace ATM_Machine
{
    partial class CustomerInputForm : Form
    {
        Account acc;
        string ops;
        public CustomerInputForm(Account acc, string ops)
        {

            InitializeComponent();
            this.acc = acc;
            this.ops = ops;
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
            bool isDigitsOnly = Regex.IsMatch(textBox1.Text, @"^[\d,.]+$");
            if (isDigitsOnly)
            {
                double inputValue;
                if (double.TryParse(textBox1.Text, out inputValue))
                {
                    if (ops == "withdrawal")
                    {
                        int results = acc.withdrawMoney(inputValue, 100000);
                        if (results == 1) MessageBox.Show("You have reached the daily transaction limit.");
                        if (results == 2) MessageBox.Show("You withdrawal amount must not be more than the amount of $3000.00 for a daily transaction.");
                        if (results == 3) MessageBox.Show("There is not enough money in your account to with draw the amount you entered.");
                        if (results == 4) MessageBox.Show("There is not enough money in the atm to support your transaction.");
                        if (results == 0) MessageBox.Show($"You have withdrawn the amount of ${textBox1.Text} from your account. You new balance for this account is now {acc.viewBalance()}.");
                        
                        Customer currentCustomer = Account.getCustomer(acc.customerID).customer;
                        UserMenu userMenuForm = new UserMenu(currentCustomer);

                        this.Hide();
                        userMenuForm.FormClosed += (s, args) => this.Close();
                        userMenuForm.Show();
                    }
                    if (ops == "deposit")
                    {
                        int results = acc.depositMoney(inputValue, 100000);
                        if (results == 1) MessageBox.Show("You have reached the daily transaction limit.");
                        if (results == 2) MessageBox.Show("You deposit amount must not be more than the amount of $3000.00 for a daily transaction.");
                        //if (results == 3) MessageBox.Show("There is not enough money in your account to with draw the amount you entered.");
                        //if (results == 4) MessageBox.Show("There is not enough money in the atm to support your transaction.");
                        if (results == 0) MessageBox.Show($"You have deposited the amount of ${textBox1.Text} to your account. You new balance for this account is now {acc.viewBalance()}.");
                        Customer currentCustomer = Account.getCustomer(acc.customerID).customer;
                        UserMenu userMenuForm = new UserMenu(currentCustomer);

                        this.Hide();
                        userMenuForm.FormClosed += (s, args) => this.Close();
                        userMenuForm.Show();
                    }
                    if (ops == "transfer")
                    {
                        acc.transferMoney(inputValue, 100000, acc);
                        Customer currentCustomer = Account.getCustomer(acc.customerID).customer;
                        UserMenu userMenuForm = new UserMenu(currentCustomer);

                        this.Hide();
                        userMenuForm.FormClosed += (s, args) => this.Close();
                        userMenuForm.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
            else
            {
                MessageBox.Show("You need to enter valid input.");
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }
    }
}
