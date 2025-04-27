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
              { ""text"": ""123456"" },
              { ""text"": ""123456"" },
              { ""text"": ""123456"" },
              { ""text"": ""123456"" }
            ]";

            List<DynamicBottonModel> buttonList = JsonSerializer.Deserialize<List<DynamicBottonModel>>(json);

            if (buttonList == null || buttonList.Count == 0)
            {
                MessageBox.Show("No buttons parsed from JSON.");
                return;
            }

            foreach (var btnData in buttonList)
            {
                Button btn = new Button
                {
                    Text = btnData.Text,
                    Width = 100,
                    Height = 40,
                    Margin = new Padding(10),
                    ForeColor = Color.White,
                    BackColor = Color.Blue,
                };

                btn.Click += (s, e) =>
                {
                    MessageBox.Show($"{btn.Text} Clicked!!");
                };
            }
        }
    }

    public class DynamicBottonModel
    {
        public string Text { get; set; }
    }
}
