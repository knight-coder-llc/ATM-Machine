using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Common;
//using Newtonsoft.Json;

namespace ATM_Machine
{
    partial class AccountsList : Form
    {
        string Operation;
        Customer customer;
        int fromAccount;
        int toAccount;

        public AccountsList(string ops, Customer customer)
        {
            this.Operation = ops;
            this.customer = customer;
            this.fromAccount = -1;
            this.toAccount = -1;
            InitializeComponent();
        }

        private void AccountsList_Load(object sender, EventArgs e)
        {
            ArrayList accounts = Account.retrieveAccounts(customer.getID());

            if (accounts == null || accounts.Count == 0)
            {
                MessageBox.Show("No Existing Accounts.");

                UserMenu userMenuForm = new UserMenu(customer);

                this.Hide();
                userMenuForm.FormClosed += (s, args) => this.Close();
                userMenuForm.Show();
                return;
            }

            int yOffset = 10; // vertical spacing between buttons

            foreach (var btnData in accounts)
            {
                Account acc = (Account)btnData;
                Button btn = new Button
                {
                    Text = acc.getAccountNum().ToString(),
                    Width = 150,
                    Height = 50,
                    Top = yOffset,
                    Left = 10,
                    ForeColor = Color.White,
                    BackColor = Color.Blue,
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                };

                CustomerInputForm customerInputForm = new CustomerInputForm(acc, this.Operation);

                switch (this.Operation)
                {
                    case "check_balance":
                        btn.Click += (s, args) =>
                        {
                            MessageBox.Show($"In account {btn.Text} you have ${acc.viewBalance().ToString()}.");
                        };
                        break;
                    case "withdrawal":
                        btn.Click += (s, args) =>
                        {
                            this.Hide();
                            customerInputForm.FormClosed += (s, args) => this.Close();
                            customerInputForm.Show();
                        };
                        break;
                    case "deposit":
                        btn.Click += (s, args) =>
                        {
                            this.Hide();
                            customerInputForm.FormClosed += (s, args) => this.Close();
                            customerInputForm.Show();
                        };
                        break;
                    case "transfer":
                        int account1 = -1;
                        int account2 = -1;
                        btn.Click += (s, args) =>
                        {
                            if(account1 == -1)
                            {
                                account1 = Convert.ToInt32(btn.Text);
                            }
                            if(account2 == -1)
                            {
                                MessageBox.Show("Choose the account transfer destination.");
                                account2 = Convert.ToInt32(btn.Text);
                            }

                            if (account1 > -1 && account2 > -1 && account1 != account2)
                            {
                                SessionManager.SetFromAccount(account1);
                                SessionManager.SetFromAccount(account2);

                                this.Hide();
                                customerInputForm.FormClosed += (s, args) => this.Close();
                                customerInputForm.Show();
                            }

                        };
                        break;
                    default:
                        MessageBox.Show("Invalid operation.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                flowLayoutPanel1.Controls.Add(btn);

                yOffset += btn.Height + 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenuForm = new UserMenu(customer);
            this.Hide();
            userMenuForm.FormClosed += (s, args) => this.Close();
            userMenuForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SessionManager.Logout();
        }
    }
}
