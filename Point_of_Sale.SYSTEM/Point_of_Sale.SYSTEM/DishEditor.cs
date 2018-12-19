using Point_of_Sale.SYSTEM.Collection;
using Point_of_Sale.SYSTEM.Collection.Dishes;
using Point_of_Sale.SYSTEM.Collection.Ingredients;
using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM
{
    public partial class DishEditor : Form
    {
        private Dictionary<Ingredient, uint> dishIngredients = new Dictionary<Ingredient, uint>();
        private Ingredient currentIngredientSelected;
        private Dish originalDish;
        private FoodMenu foodMenu;

        public DishEditor()
        {
            InitializeComponent();
        }

        public void Init(Dish dish, FoodMenu foodMenu)
        {
            this.Show();
            this.foodMenu = foodMenu;
            originalDish = dish;

            for (int i = 0; i < dish.Ingredients.Count; i++)
            {
                dishIngredients.Add(dish.Ingredients[i], dish.Quantities[i]);
            }
            IngredientDisplay.Text = Dish.PrintIngredients(dishIngredients);

            List<Ingredient> allIngredients = Database.allIngredients;
            for (int i = 0; i < allIngredients.Count; i++)
            {
                AddIngredientButton(allIngredients[i], i);
            }
        }

        private void AddIngredientButton(Ingredient ingredient, int index)
        {
            Button button = new Button
            {
                Size = new Size(120, 80),
                Text = ingredient.Name,
                Tag = index
            };

            button.Click += new EventHandler(Button_Click);
            IngredientFlowPanel.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            for (int i = 0; i < Utilities.GetAmountOfIngredients(); i++)
            {
                if (button.Text.ToLower().Equals(Database.allIngredients[i].Name.ToLower()))
                {
                    IIngredient ingredient = Utilities.GetIngredientByName(button.Text);
                    currentIngredientSelected = ingredient as Ingredient;
                }
            }
        }

        private void TerminateButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddIngredient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dishIngredients.Count; i++)
            {
                if (dishIngredients.ElementAt(i).Key.Name.ToLower().Equals(currentIngredientSelected.Name.ToLower()))
                {
                    dishIngredients[dishIngredients.ElementAt(i).Key]++;
                    IngredientDisplay.Text = Dish.PrintIngredients(dishIngredients);
                    return;
                }
            }
            dishIngredients.Add(currentIngredientSelected, 1);
            IngredientDisplay.Text = Dish.PrintIngredients(dishIngredients);

        }

        private void RemoveIngredient_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dishIngredients.Count; i++)
            {
                if (dishIngredients.ElementAt(i).Key.Name.ToLower().Equals(currentIngredientSelected.Name.ToLower()))
                {
                    if (dishIngredients.ElementAt(i).Value > 1)
                    {
                        dishIngredients[dishIngredients.ElementAt(i).Key]--;
                        IngredientDisplay.Text = Dish.PrintIngredients(dishIngredients);
                    }
                    else
                    {
                        dishIngredients.Remove(dishIngredients.ElementAt(i).Key);
                        IngredientDisplay.Text = Dish.PrintIngredients(dishIngredients);
                    }
                    return;
                }
            }
        }

        private void FinishDish_Click(object sender, EventArgs e)
        {
            uint totalExtraCost = 0;
            bool ingredientFromOriginal;

            for (int i = 0; i < dishIngredients.Count; i++)
            {
                ingredientFromOriginal = false;

                for (int x = 0; x < originalDish.Ingredients.Count; x++)
                {
                    if (originalDish.Ingredients[x].Name.ToLower().Equals(dishIngredients.ElementAt(i).Key.Name.ToLower()))
                    {
                        ingredientFromOriginal = true;
                        if (originalDish.Quantities[x] < dishIngredients.ElementAt(i).Value)
                        {

                            totalExtraCost += dishIngredients.ElementAt(i).Key.ExtraCost;
                            break;
                        }
                    }
                }
                
                if (!ingredientFromOriginal)
                {
                    totalExtraCost += dishIngredients.ElementAt(i).Key.ExtraCost;
                }
            }

            originalDish.Ingredients = new List<Ingredient>();
            originalDish.Quantities = new List<uint>();
            foreach (KeyValuePair<Ingredient, uint> ingredient in dishIngredients)
            {
                originalDish.Ingredients.Add(ingredient.Key);
                if (ingredient.Value > 1)
                {
                    originalDish.Quantities.Add(ingredient.Value);
                }
                else originalDish.Quantities.Add(1);
            }
            foodMenu.AddDishToOrder(originalDish);
        }
    }
}
