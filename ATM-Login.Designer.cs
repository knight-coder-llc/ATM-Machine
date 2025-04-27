namespace ATM_Machine
{
    partial class ATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            userIdInput = new TextBox();
            pinInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 38);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(330, 8);
            label3.Name = "label3";
            label3.Size = new Size(145, 30);
            label3.TabIndex = 0;
            label3.Text = "ATM System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 414);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 36);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 78);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 2;
            label1.Text = "USER ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 191);
            label2.Name = "label2";
            label2.Size = new Size(135, 25);
            label2.TabIndex = 3;
            label2.Text = "PIN NUMBER";
            // 
            // userIdInput
            // 
            userIdInput.Anchor = AnchorStyles.None;
            userIdInput.BackColor = Color.LightGray;
            userIdInput.BorderStyle = BorderStyle.None;
            userIdInput.Font = new Font("Tahoma", 28F);
            userIdInput.Location = new Point(205, 111);
            userIdInput.MaximumSize = new Size(500, 53);
            userIdInput.MinimumSize = new Size(373, 53);
            userIdInput.Name = "userIdInput";
            userIdInput.Size = new Size(373, 53);
            userIdInput.TabIndex = 4;
            userIdInput.TextChanged += userIdInput_TextChanged;
            // 
            // pinInput
            // 
            pinInput.Anchor = AnchorStyles.None;
            pinInput.BackColor = Color.LightGray;
            pinInput.BorderStyle = BorderStyle.None;
            pinInput.Font = new Font("Tahoma", 28F);
            pinInput.Location = new Point(205, 224);
            pinInput.MaximumSize = new Size(500, 53);
            pinInput.MinimumSize = new Size(373, 53);
            pinInput.Name = "pinInput";
            pinInput.Size = new Size(373, 53);
            pinInput.TabIndex = 5;
            pinInput.TextChanged += pinInput_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(205, 324);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 6;
            button1.Text = "CONFIRM";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(440, 324);
            button2.Name = "button2";
            button2.Size = new Size(138, 53);
            button2.TabIndex = 7;
            button2.Text = "RESET";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pinInput);
            Controls.Add(userIdInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ATM";
            ShowIcon = false;
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox userIdInput;
        private TextBox pinInput;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}
