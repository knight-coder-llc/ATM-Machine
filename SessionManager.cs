// SessionManager.cs
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ATM_Machine
{
    class SessionManager
    {
        private static int fromAccount;
        private static int toAccount;

        public static int GetFromAccount()
        {
            return fromAccount;
        }

        public static void SetFromAccount(int value)
        {
            fromAccount = value;
        }

        public static int GetToAccount()
        {
            return toAccount;
        }

        public static void SetToAccount(int value)
        {
            toAccount = value;
        }
        public static Customer? CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;

            // Close all open forms except the login form
            foreach (Form form in Application.OpenForms)
            {
                if (!(form is ATM))
                    form.Hide();    
            }

            
            ATM loginForm = new ATM();
            loginForm.Show();
        }
    }
}
