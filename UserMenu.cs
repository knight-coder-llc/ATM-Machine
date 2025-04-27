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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }
        //CHECK BALANCE
        private void button1_Click(object sender, EventArgs e)
        {
            //UserMenu userMenuForm = new UserMenu();
            //this.Hide();
            //userMenuForm.FormClosed += (s, args) => this.Close();
            //userMenuForm.Show();

            AccountsList accountsList = new AccountsList();
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
        // WITHDRAW MONEY
        private void button2_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList();
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
        // DEPOSIT MONEY
        private void button3_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList();
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
        // TRANSFER MONEY
        private void button4_Click(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList();
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AccountsList accountsList = new AccountsList();
            this.Hide();
            accountsList.FormClosed += (s, args) => this.Close();
            accountsList.Show();
        }
    }
}
