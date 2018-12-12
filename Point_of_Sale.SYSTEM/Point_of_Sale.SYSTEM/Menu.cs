using System;
using System.Windows.Forms;
using Point_of_Sale.SYSTEM.Utility;
using Point_of_Sale.SYSTEM.Collection;

namespace Point_of_Sale.SYSTEM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            IDish dish = Utilities.GetDishByName(TestButton.Text);
        }
    }
}
