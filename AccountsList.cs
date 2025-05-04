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
        public AccountsList(string ops, Customer customer)
        {
            this.Operation = ops;
            this.customer = customer;
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
                        btn.Click += (s, args) =>
                        {
                            this.Hide();
                            customerInputForm.FormClosed += (s, args) => this.Close();
                            customerInputForm.Show();
                        };
                        break;
                    default:
                        MessageBox.Show("Invalid operation.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        UserMenu userMenuForm = new UserMenu(customer);
                        this.Hide();
                        userMenuForm.FormClosed += (s, args) => this.Close();
                        userMenuForm.Show();
                        break;
                }

                flowLayoutPanel1.Controls.Add(btn);

                yOffset += btn.Height + 10;
            }
        }
    }
}
