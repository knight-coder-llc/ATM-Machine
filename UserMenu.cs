using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Machine
{
    partial class UserMenu : Form
    {
        Customer customer;
        public UserMenu(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }
        // WITHDRAW MONEY
        private void button2_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList("withdrawal", customer);
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
        // DEPOSIT MONEY
        private void button3_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList("transfer", customer);
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
        // TRANSFER MONEY
        private void button4_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList("deposit", customer);
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList("check_balance", customer);
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
    }
}
