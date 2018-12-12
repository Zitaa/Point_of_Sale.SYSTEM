using System;
using System.Windows.Forms;
using Point_of_Sale.SYSTEM.Utility;
using Point_of_Sale.SYSTEM.Collection;
using System.IO;

namespace Point_of_Sale.SYSTEM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (File.Exists(Database.DISH_PATH)) Database.LoadDishes(Database.DISH_PATH);
            else Utilities.GenerateDishes(LogDisplay);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            IDish dish = Utilities.GetDishByName(TestButton.Text);
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
