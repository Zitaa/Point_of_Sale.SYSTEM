using Point_of_Sale.SYSTEM.Collection.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Point_of_Sale.SYSTEM.Collection
{
    public class Dish : IDish
    {
        public string Name { get; set; }
        public uint Cost { get; set; }

        public List<Ingredient> Ingredients { get; set; }
        public List<uint> Quantities { get; set; }

        public Dish()
        {
            Ingredients = new List<Ingredient>();
            Quantities = new List<uint>();
        }

        public string PrintIngredients()
        {
            string ingredientsToReturn = string.Empty;
            for (int i = 0; i < Ingredients.Count; i++)
            {
                ingredientsToReturn += (Quantities[i] > 1) ?
                    string.Format("{0} [x{1}]", Ingredients[i].Name, Quantities[i]) : Ingredients[i].Name;
                ingredientsToReturn += Environment.NewLine;
            }
            return ingredientsToReturn;
        }

        public static string PrintIngredients(Dictionary<Ingredient, uint> dishIngredients)
        {
            string ingredientsToReturn = string.Empty;
            for (int i = 0; i < dishIngredients.Count; i++)
            {
                ingredientsToReturn += (dishIngredients.ElementAt(i).Value > 1) ?
                    string.Format("{0} [x{1}]", dishIngredients.ElementAt(i).Key.Name,
                    dishIngredients.ElementAt(i).Value) : 
                    dishIngredients.ElementAt(i).Key.Name;
                ingredientsToReturn += Environment.NewLine;
            }
            return ingredientsToReturn;
        }

        /*public string Name { get; set; }
        public uint Cost { get; set; }

        public List<Ingredient> ingredients = new List<Ingredient>();
        public List<uint> quantities = new List<uint>();

        public Dish(string name, uint cost)
        {
            Name = name;
            Cost = cost;
        }

        public string PrintIngredients()
        {
            string ingredientsToReturn = string.Empty;
            for (int i = 0; i < ingredients.Count; i++)
            {
                ingredientsToReturn += (quantities[i] > 1) ? 
                    string.Format("{0} | {1}", quantities[i], ingredients[i].Name) : ingredients[i].Name;
                ingredientsToReturn += Environment.NewLine;
            }
            return ingredientsToReturn;
        }

        public KeyValuePair<Ingredient, uint> GetOrCreateIngredient(string name, uint quantity)
        {
            foreach (Ingredient ingredient in Database.allIngredients)
            {
                if (ingredient.Name.ToLower().Equals(name.ToLower()))
                    return new KeyValuePair<Ingredient, uint>(ingredient, quantity);
            }
            return new KeyValuePair<Ingredient, uint>(CreateIngredient(name), quantity);
        }

        public Ingredient CreateIngredient(string name)
        {
            Ingredient newIngredient = new Ingredient(name, 3);
            Database.allIngredients.Add(newIngredient);
            Database.SaveIngredients(Database.allIngredients, Database.INGREDIENT_PATH);
            return newIngredient;
        }

        public override string ToString() { return Name; }

        ~Dish()
        {

        }*/
    }

    /*public class Hamburger : Dish
    {
        public Hamburger()
            : base("Hamburger", 10)
        {
            KeyValuePair<Ingredient, uint> _1 = GetOrCreateIngredient("Ketchup", 1);
            KeyValuePair<Ingredient, uint> _2 = GetOrCreateIngredient("Senap", 1);
            KeyValuePair<Ingredient, uint> _3 = GetOrCreateIngredient("Frystorkad Lök", 1);
            KeyValuePair<Ingredient, uint> _4 = GetOrCreateIngredient("Gurka", 1);

            ingredients.Add(_1.Key);
            ingredients.Add(_2.Key);
            ingredients.Add(_3.Key);
            ingredients.Add(_4.Key);

            quantities.Add(_1.Value);
            quantities.Add(_2.Value);
            quantities.Add(_3.Value);
            quantities.Add(_4.Value);
        }
    }

    public class CheeseBurger : Dish
    {
        public CheeseBurger()
            : base("Cheeseburger", 13)
        {
            KeyValuePair<Ingredient, uint> _1 = GetOrCreateIngredient("Ketchup", 1);
            KeyValuePair<Ingredient, uint> _2 = GetOrCreateIngredient("Senap", 1);
            KeyValuePair<Ingredient, uint> _3 = GetOrCreateIngredient("Frystorkad Lök", 1);
            KeyValuePair<Ingredient, uint> _4 = GetOrCreateIngredient("Gurka", 1);
            KeyValuePair<Ingredient, uint> _5 = GetOrCreateIngredient("Ost", 1);

            ingredients.Add(_1.Key);
            ingredients.Add(_2.Key);
            ingredients.Add(_3.Key);
            ingredients.Add(_4.Key);
            ingredients.Add(_5.Key);

            quantities.Add(_1.Value);
            quantities.Add(_2.Value);
            quantities.Add(_3.Value);
            quantities.Add(_4.Value);
            quantities.Add(_5.Value);
        }
    }*/
}
