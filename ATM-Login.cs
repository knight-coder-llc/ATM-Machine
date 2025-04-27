namespace ATM_Machine
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }


        // LOGIN CONFIRM
        private void button1_Click(object sender, EventArgs e)
        {
            // dummy login validation
            if (userIdInput.Text == "admin" && pinInput.Text == "1234")
            {
                UserMenu userMenuForm = new UserMenu();
                this.Hide();
                userMenuForm.FormClosed += (s, args) => this.Close();
                userMenuForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // USERID
        private void userIdInput_TextChanged(object sender, EventArgs e)
        {

        }
        // PIN NUMBER
        private void pinInput_TextChanged(object sender, EventArgs e)
        {

        }
        // Reset button
        private void button2_Click(object sender, EventArgs e)
        {
            userIdInput.Text = "";
            pinInput.Text = "";
        }
    }
}
