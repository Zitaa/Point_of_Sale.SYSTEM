using Point_of_Sale.SYSTEM.Collection;
using Point_of_Sale.SYSTEM.Collection.Dishes;
using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM
{
    public partial class FoodMenu : Form
    {
        private List<IDish> dishOrders = new List<IDish>();
        private Dish currentDishSelected;

        public FoodMenu()
        {
            InitializeComponent();
            DishOrdersDisplay.SelectionAlignment = HorizontalAlignment.Center;
        }

        public void Init()
        {
            ChangeIngredientsButton.Visible = false;

            List<Dish> dishes = Database.allDishes;
            for (int i = 0; i < dishes.Count; i++)
            {
                AddFoodButton(dishes[i], i);
            }
        }

        private void AddFoodButton(Dish dish, int index)
        {
            Button button = new Button
            {
                Size = new Size(120, 80),
                Text = dish.Name,
                Tag = index
            };

            button.Click += new EventHandler(Button_Click);
            FoodLayoutPanel.Controls.Add(button);
        }

        public void AddDishToOrder(Dish dish)
        {
            DishOrdersDisplay.Text += string.Format("...::* {0} *::...", dish.Name) + Environment.NewLine;
            DishOrdersDisplay.Text += dish.PrintIngredients();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < Utilities.GetAmountOfDishes(); i++)
            {
                if (button.Text.ToLower().Equals(Database.allDishes[i].Name.ToLower()))
                {
                    IDish dish = Utilities.GetDishByName(button.Text);
                    IngredientDisplay.Text = dish.PrintIngredients();
                    currentDishSelected = dish as Dish;
                    ChangeIngredientsButton.Visible = true;
                }
            }
        }

        private void TerminateButton_Click_1(object sender, EventArgs e)
        {
            FoodMenu foodMenu = Program.GetFoodMenu();
            Menu mainMenu = Program.GetMainMenu();
            mainMenu.Show();
            foodMenu.Hide();
        }

        private void ChangeIngredientsButton_Click(object sender, EventArgs e)
        {
            DishEditor editor = new DishEditor();
            editor.Init(currentDishSelected, this);
        }
    }
}
