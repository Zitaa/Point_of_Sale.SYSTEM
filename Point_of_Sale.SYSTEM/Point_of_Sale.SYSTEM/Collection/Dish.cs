using System.Collections.Generic;

namespace Point_of_Sale.SYSTEM.Collection
{
    internal interface IDish
    {
        string Name { get; set; }
        uint Cost { get; set; }

        Dictionary<Ingredient, uint> Ingredients { get; set; }

        KeyValuePair<Ingredient, uint> GetOrCreateIngredient(string name);
        Ingredient CreateIngredient(string name);
    }

    public class Dish : IDish
    {
        public string Name { get; set; }
        public uint Cost { get; set; }

        public Dictionary<Ingredient, uint> Ingredients { get; set; }

        public Dish(string name, uint cost)
        {
            Name = name;
            Cost = cost;
        }

        public KeyValuePair<Ingredient, uint> GetOrCreateIngredient(string name)
        {
            throw new System.Exception();
        }

        public Ingredient CreateIngredient(string name)
        {
            return null;
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

        }
    }

    public class CheeseBurger : Dish
    {
        public CheeseBurger()
            : base("Cheeseburger", 13)
        {

        }
    }
}
