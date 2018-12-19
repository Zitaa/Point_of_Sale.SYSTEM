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
        private List<Dish> dishOrders = new List<Dish>();
        private Dish currentDishSelected;

        private uint OrderCost;

        public FoodMenu()
        {
            InitializeComponent();
        }

        public void Init()
        {
            List<Dish> dishes = Database.allDishes;
            for (int i = 0; i < dishes.Count; i++)
            {
                FoodLayoutPanel.Controls.Add(AddFoodButton(dishes[i]));
            }
        }

        private Button AddFoodButton(Dish dish, string text = null, int width = 120, int height = 80)
        {
            if (text is null) text = dish.Name;

            Button button = new Button
            {
                Size = new Size(width, height),
                Text = text,
                Tag = dish
            };

            button.Click += new EventHandler(Button_Click);
            return button;
        }

        public void AddDishToOrder(Dish dish)
        {
            if (!dish.ExistingOrder)
            {
                dishOrders.Add(dish);
                dish.ExistingOrder = true;
                dish.ID = (uint)dishOrders.Count - 1;

                DishOrdersDisplay.Text += string.Format("{0} ({1}Kr)", dish.Name.ToUpper(), dish.Cost) + Environment.NewLine;
                foreach (KeyValuePair<Ingredient, uint> ingredient in dish.ExtraIngredients)
                {
                    if (ingredient.Value > 1)
                    {
                        DishOrdersDisplay.Text += string.Format("        EXTRA {0} [x{1}]",
                        ingredient.Key.Name,
                        ingredient.Value) + Environment.NewLine;
                    }
                    else
                    {
                        DishOrdersDisplay.Text += string.Format("        EXTRA {0}",
                        ingredient.Key.Name) + Environment.NewLine;
                    }
                }

                OrderCost += dish.Cost;
                CostDisplay.Text = string.Format("{0}Kr ", OrderCost);

                if (dish.ExtraIngredients.Count > 0) OrdersLayoutPanel.Controls.Add
                        (AddFoodButton(dish, string.Format("{0}\n GRILL ORDER", dish.Name)));
                else OrdersLayoutPanel.Controls.Add(AddFoodButton(dish));
            }
            else
            {
                DishOrdersDisplay.Text = string.Empty;
                dishOrders[(int)dish.ID] = dish;
                OrderCost = 0;
                
                for (int i = 0; i < dishOrders.Count; i++)
                {
                    DishOrdersDisplay.Text += string.Format("{0} ({1}Kr)", dishOrders[i].Name.ToUpper(),
                        dishOrders[i].Cost) + Environment.NewLine;
                    foreach (KeyValuePair<Ingredient, uint> ingredient in dishOrders[i].ExtraIngredients)
                    {
                        if (ingredient.Value > 1)
                        {
                            DishOrdersDisplay.Text += string.Format("        EXTRA {0} [x{1}]",
                            ingredient.Key.Name,
                            ingredient.Value) + Environment.NewLine;
                        }
                        else
                        {
                            DishOrdersDisplay.Text += string.Format("        EXTRA {0}",
                            ingredient.Key.Name) + Environment.NewLine;
                        }
                    }

                    if (dishOrders[i].ExtraIngredients.Count > 0)
                        OrdersLayoutPanel.Controls[(int)dish.ID].Text = string.Format("{0}\n GRILL ORDER", dishOrders[i].Name);

                    OrderCost += dishOrders[i].Cost;
                    CostDisplay.Text = string.Format("{0}Kr ", OrderCost);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Dish dish = button.Tag as Dish;
            
            currentDishSelected = dish;

            DishEditor editor = new DishEditor();
            editor.Init(currentDishSelected, this, dish.ExistingOrder);

            /*for (int i = 0; i < Utilities.GetAmountOfDishes(); i++)
            {
                if (button.Text.ToLower().Equals(Database.allDishes[i].Name.ToLower()))
                {
                    Dish dish = Utilities.GetDishByName(button.Text);
                    currentDishSelected = dish;
                    DishEditor editor = new DishEditor();
                    editor.Init(currentDishSelected, this);
                }
            }*/
        }

        private void TerminateButton_Click_1(object sender, EventArgs e)
        {
            FoodMenu foodMenu = Program.GetFoodMenu();
            Menu mainMenu = Program.GetMainMenu();
            mainMenu.Show();
            foodMenu.Hide();
        }
    }
}
