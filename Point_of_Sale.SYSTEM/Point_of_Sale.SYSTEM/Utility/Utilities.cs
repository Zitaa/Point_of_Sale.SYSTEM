using Point_of_Sale.SYSTEM.Collection;
using Point_of_Sale.SYSTEM.Collection.Accounts;
using Point_of_Sale.SYSTEM.Collection.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Point_of_Sale.SYSTEM.Utility
{
    public static class Utilities
    {
        public static void GenerateDishes(RichTextBox display)
        {
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == "Point_of_Sale.SYSTEM.Collection"
                    select t;

            List<IDish> dishes = new List<IDish>();
            foreach (var _class in q)
            {
                switch (_class.Name)
                {
                    case "Hamburger":
                        dishes.Add(new Hamburger() as IDish);
                        continue;
                    case "Cheeseburger":
                        dishes.Add(new Cheeseburger() as IDish);
                        continue;
                }
            }

            Database.allDishes = dishes.ConvertAll(x => (Dish)x);
            Database.SaveDishes(Database.allDishes, Database.DISH_PATH);
        }

        public static Dish GetDishByName(string name)
        {
            foreach (Dish dish in Database.allDishes)
            {
                if (dish.Name.ToLower().Equals(name.ToLower())) return dish;
            }
            return null;
        }

        public static Ingredient GetIngredientByName(string name)
        {
            foreach (Ingredient ingredient in Database.allIngredients)
            {
                if (ingredient.Name.ToLower().Equals(name.ToLower())) return ingredient;
            }
            return null;
        }
    }
}
