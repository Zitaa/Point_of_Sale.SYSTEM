using Point_of_Sale.SYSTEM.Collection;
using Point_of_Sale.SYSTEM.Collection.Accounts;
using Point_of_Sale.SYSTEM.Collection.Dishes;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM.Utility
{
    public static class Utilities
    {
        public static void GenerateDishes()
        {
            new Hamburger();
            new Cheeseburger();
            new DoubleCheeseburger();
            new BigMac();
            new McFeast();
            new QuarterPounder();
            new DoubleQuarterPounder();
        }

        public static Dish GetDishByName(string name)
        {
            foreach (Dish dish in Database.allDishes)
            {
                if (dish.Name.ToLower().Equals(name.ToLower())) return dish;
            }
            return null;
        }

        public static int GetAmountOfDishes()
        {
            return Database.allDishes.Count;
        }

        public static Ingredient GetIngredientByName(string name)
        {
            foreach (Ingredient ingredient in Database.allIngredients)
            {
                if (ingredient.Name.ToLower().Equals(name.ToLower())) return ingredient;
            }
            return null;
        }

        public static int GetAmountOfIngredients()
        {
            return Database.allIngredients.Count;
        }
    }
}
