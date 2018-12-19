using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Point_of_Sale.SYSTEM.Collection.Accounts;

namespace Point_of_Sale.SYSTEM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Init();

            Program.OnUserLogin += OnLogIn;
            Program.OnUserLogin += ClearLoginInput;
            Program.OnUserLogin += EnableButtons;

            Program.OnUserLogout += OnLogOut;
            Program.OnUserLogout += DisableButtons;
        }

        public void Init()
        {
            Image MenuPanel = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                "\\Collection\\Menu_Collum_Image.png");
            Image foodIcon = Image.FromFile(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + 
                "\\Collection\\Food_Icon.png");
            
            FoodButton.Image = new Bitmap(foodIcon, new Size(64, 64)) as Image;
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

        private void OnLogIn()
        {
            UsernameInputTextBox.Visible = false;
            PasswordInputTextBox.Visible = false;
            Loginbutton.Visible = false;
            RegisterButton.Visible = false;
            LogOutButton.Visible = true;
        }

        private void OnLogOut()
        {
            UsernameInputTextBox.Visible = true;
            PasswordInputTextBox.Visible = true;
            Loginbutton.Visible = true;
            RegisterButton.Visible = true;
            LogOutButton.Visible = false;
        }

        private void EnableButtons()
        {
            FoodButton.Enabled = true;
        }

        private void DisableButtons()
        {
            FoodButton.Enabled = false;
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

            Account account = Accounts.GetOrCreateAccount(username, password, AccountSecurity.NORMAL);
            if (account != null)
            {
                if (account.Password.Equals(password))
                {
                    Program.Login(account);
                    string security = (account.Security == AccountSecurity.ADMIN) ? "[Admin]" : string.Empty;
                    LoggedInUser.Text = string.Format("Logged in as: {0} {1}", account.Username, security);
                    Program.OnUserLogin.Invoke();
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

                Accounts.GetOrCreateAccount(username, password, AccountSecurity.NORMAL);
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

            Program.OnUserLogout.Invoke();
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = Program.GetFoodMenu();
            Menu mainMenu = Program.GetMainMenu();
            foodMenu.Init();
            foodMenu.Show();
            mainMenu.Hide();
        }
    }
}
