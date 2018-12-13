using Point_of_Sale.SYSTEM.Collection.Accounts;
using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM
{
    static class Program
    {
        public static Account currentUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void Login(Account account)
        {
            currentUser = account;
        }

        public static void LogOut()
        {
            currentUser = null;
        }
    }
}
