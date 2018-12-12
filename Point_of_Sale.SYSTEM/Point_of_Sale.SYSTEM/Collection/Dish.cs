using Point_of_Sale.SYSTEM.Utility;
using System.Collections.Generic;

namespace Point_of_Sale.SYSTEM.Collection
{
    internal interface IDish
    {
        string Name { get; set; }
        uint Cost { get; set; }

        KeyValuePair<Ingredient, uint> GetOrCreateIngredient(string name, uint quantity);
        Ingredient CreateIngredient(string name);
    }

    public class Dish : IDish
    {
        public string Name { get; set; }
        public uint Cost { get; set; }

        public List<Ingredient> ingredients = new List<Ingredient>();

        public Dish(string name, uint cost)
        {
            Name = name;
            Cost = cost;
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

        }
    }

    public class Hamburger : Dish
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
        }
    }
}
