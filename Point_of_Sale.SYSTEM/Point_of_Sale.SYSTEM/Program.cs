using Point_of_Sale.SYSTEM.Collection.Accounts;
using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM
{
    static class Program
    {
        public static Account currentUser;

        public delegate void OnUserChange();
        public static OnUserChange OnUserLogin;
        public static OnUserChange OnUserLogout;

        private static Menu mainMenu;
        private static FoodMenu foodMenu;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.Init();
            Utilities.GenerateDishes();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Init(new Menu());
            Application.Run(mainMenu);
        }

        private static void Init(Menu mainMenu)
        {
            Program.mainMenu = mainMenu;
            foodMenu = new FoodMenu();

            SetupWindowForms(Program.mainMenu);
            SetupWindowForms(foodMenu);
        }

        private static void SetupWindowForms(Form form)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            form.Height = height;
            form.Width = width;
        }

        public static void Login(Account account)
        {
            currentUser = account;
        }

        public static void LogOut()
        {
            currentUser = null;
        }

        public static FoodMenu GetFoodMenu()
        {
            if (foodMenu is null) return null;
            return foodMenu;
        }

        public static Menu GetMainMenu()
        {
            if (mainMenu is null) return null;
            return mainMenu;
        }
    }
}

public class DoubleBufferedPanel : Panel
{
    public DoubleBufferedPanel()
        : base()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    }
}
