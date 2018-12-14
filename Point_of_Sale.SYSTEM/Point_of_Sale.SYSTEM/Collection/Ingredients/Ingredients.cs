using Point_of_Sale.SYSTEM.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_of_Sale.SYSTEM.Collection.Ingredients
{
    public static class Ingredients
    {
        private static List<Ingredient> ingredients;

        static Ingredients()
        {
            if (File.Exists(Database.INGREDIENT_PATH))
            {
                ingredients = Database.LoadIngredients(Database.INGREDIENT_PATH).ToList();
            }
            else
            {
                ingredients = new List<Ingredient>();
            }
        }

        public static void SaveIngredients()
        {
            Database.SaveIngredients(ingredients, Database.INGREDIENT_PATH);
        }

        public static Ingredient GetOrCreateIngredient(string name, uint extraCost)
        {
            IEnumerable<Ingredient> result = from _ingredient in ingredients
                                             where _ingredient.Name == name
                                             select _ingredient;

            Ingredient ingredient = result.FirstOrDefault();
            if (ingredient is null) return CreateIngredient(name, extraCost);
            return ingredient;
        }

        public static Ingredient CreateIngredient(string name, uint extraCost)
        {
            Ingredient newIngredient = new Ingredient()
            {
                Name = name,
                ExtraCost = extraCost
            };
            ingredients.Add(newIngredient);
            SaveIngredients();
            return newIngredient;
        }
    }
}
