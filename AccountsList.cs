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

namespace ATM_Machine
{
    public partial class AccountsList : Form
    {
        public AccountsList()
        {
            InitializeComponent();
        }

        private void AccountsList_Load(object sender, EventArgs e)
        {
                    string json = @"[
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" },
                          { ""Text"": ""123456"" }
                        ]";

            List<DynamicBottonModel> buttonList = JsonSerializer.Deserialize<List<DynamicBottonModel>>(json);

            if (buttonList == null || buttonList.Count == 0)
            {
                MessageBox.Show("No buttons parsed from JSON.");
                return;
            }

            int yOffset = 10; // vertical spacing between buttons

            foreach (var btnData in buttonList)
            {
                Button btn = new Button
                {
                    Text = btnData.Text,
                    Width = 150,
                    Height = 50,
                    Top = yOffset,
                    Left = 10,
                    ForeColor = Color.White,
                    BackColor = Color.Blue,
                    Font = new Font("Segoe UI", 16, FontStyle.Bold),
                };

                string Operation = "withdrawal";
                CustomerInputForm customerInputForm = new CustomerInputForm();

                switch (Operation)
                {
                    case "check_balance":
                        btn.Click += (s, args) =>
                        {
                            //MessageBox.Show($"{btn.Text} Clicked!!");
                            MessageBox.Show("$5,000.00");
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
                    default:
                        MessageBox.Show("Invalid operation.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                
                flowLayoutPanel1.Controls.Add(btn);

                //this.Controls.Add(btn);

                yOffset += btn.Height + 10; // move next button down
            }
        }
    }

    public class DynamicBottonModel
    {
        public string Text { get; set; }
    }
}
