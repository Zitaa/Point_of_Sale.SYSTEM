using System;
using System.Windows.Forms;
using Point_of_Sale.SYSTEM.Collection.Accounts;

namespace Point_of_Sale.SYSTEM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Hamburger hb = new Hamburger();
            Cheeseburger chb = new Cheeseburger();
            BigMac bm = new BigMac();
        }

        private void ClearUsernameInput()
        {
            UsernameInputTextBox.Text = string.Empty;
        }

        private void ClearPasswordInput()
        {
            PasswordInputTextBox.Text = string.Empty;
        }

        private void ClearLoginInput()
        {
            UsernameInputTextBox.Text = string.Empty;
            PasswordInputTextBox.Text = string.Empty;
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            string username = UsernameInputTextBox.Text;
            string password = PasswordInputTextBox.Text;

            string stringID = username.Replace(" ", string.Empty);
            stringID = stringID.ToLower();

            Account account = Accounts.GetOrCreateAccount(username, password, AccountSecurity.Normal);
            if (account != null)
            {
                if (account.Password.Equals(password))
                {
                    Program.Login(account);
                    LoggedInUser.Text = string.Format("Logged in as: {0}", account.Username);
                    ClearLoginInput();
                }
                else
                {
                    MessageBox.Show("Wrong password!");
                    ClearPasswordInput();
                }
            }
            else
            {
                MessageBox.Show("No user by that name was found!");
                ClearLoginInput();
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UsernameInputTextBox.Text != "" && PasswordInputTextBox.Text != "")
            {
                string username = UsernameInputTextBox.Text;
                string password = PasswordInputTextBox.Text;

                Accounts.GetOrCreateAccount(username, password, AccountSecurity.Normal);
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You're about to log out. Are you sure?", 
                "Log Out", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            switch (result)
            {
                case DialogResult.Yes:
                    Program.LogOut();
                    LoggedInUser.Text = string.Empty;
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
