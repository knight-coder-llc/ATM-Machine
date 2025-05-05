namespace ATM_Machine
{
    partial class UserMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(331, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 30);
            label1.TabIndex = 1;
            label1.Text = "ATM System";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(630, -23);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 0;
            label3.Text = "ATM System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(button5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 414);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 36);
            panel2.TabIndex = 2;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Blue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F);
            button5.ForeColor = SystemColors.Control;
            button5.Location = new Point(600, 0);
            button5.Name = "button5";
            button5.Size = new Size(91, 36);
            button5.TabIndex = 0;
            button5.Text = "LOGOUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(91, 190);
            button1.Name = "button1";
            button1.Size = new Size(223, 53);
            button1.TabIndex = 7;
            button1.Text = "CHECK BALANCE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(468, 190);
            button2.Name = "button2";
            button2.Size = new Size(223, 53);
            button2.TabIndex = 8;
            button2.Text = "WITHDRAW MONEY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(91, 275);
            button3.Name = "button3";
            button3.Size = new Size(223, 53);
            button3.TabIndex = 9;
            button3.Text = "DEPOSIT MONEY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(468, 275);
            button4.Name = "button4";
            button4.Size = new Size(223, 53);
            button4.TabIndex = 10;
            button4.Text = "TRANSFER MONEY";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserMenu";
            Text = "UserMenu";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}