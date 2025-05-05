namespace ATM_Machine
{
    partial class AccountsList
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
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
            label1.Location = new Point(328, 8);
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
            button5.Location = new Point(598, 0);
            button5.Name = "button5";
            button5.Size = new Size(91, 36);
            button5.TabIndex = 1;
            button5.Text = "LOGOUT";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 82);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 332);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 7;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 38);
            label2.Name = "label2";
            label2.Size = new Size(224, 30);
            label2.TabIndex = 4;
            label2.Text = "Choose Your Account";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // AccountsList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AccountsList";
            Text = "AccountsList";
            WindowState = FormWindowState.Maximized;
            Load += AccountsList_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Button button1;
        private Button button5;
    }
}