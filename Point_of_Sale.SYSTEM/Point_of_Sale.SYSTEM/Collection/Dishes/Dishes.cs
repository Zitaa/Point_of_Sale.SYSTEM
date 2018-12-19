using Point_of_Sale.SYSTEM.Utility;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Point_of_Sale.SYSTEM.Collection.Accounts
{
    public static class Dishes
    {
        private static List<Dish> dishes;

        static Dishes()
        {
            if (File.Exists(Database.DISH_PATH))
            {
                dishes = Database.LoadDishes(Database.DISH_PATH).ToList();
            }
            else
            {
                dishes = new List<Dish>();
            }
        }

        public static void SaveDishes()
        {
            Database.SaveDishes(dishes, Database.DISH_PATH);
        }

        public static Dish GetOrCreateDish(string name, uint cost, List<Ingredient> ingredients, List<uint> quantities)
        {
            IEnumerable<Dish> result = from _dish in dishes
                                       where _dish.Name == name
                                       select _dish;

            Dish dish = result.FirstOrDefault();
            if (dish is null) return CreateDish(name, cost, ingredients, quantities);
            return dish;
        }

        public static Dish CreateDish(string name, uint cost, List<Ingredient> ingredients, List<uint> quantities)
        {
            Dish newDish = new Dish()
            {
                Name = name,
                Cost = cost,
                Ingredients = ingredients,
                Quantities = quantities
            };
            dishes.Add(newDish);
            SaveDishes();
            return newDish;
        }
    }

    public class Hamburger : Dish
    {
        public Hamburger()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ketchup", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Senap", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Frystorkad Lök", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);

            Dishes.GetOrCreateDish("Hamburger", 10, Ingredients, Quantities);
        }
    }

    public class Cheeseburger : Dish
    {
        public Cheeseburger()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ketchup", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Senap", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Frystorkad Lök", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);

            Dishes.GetOrCreateDish("Cheeseburger", 13, Ingredients, Quantities);
        }
    }

    public class DoubleCheeseburger : Dish
    {
        public DoubleCheeseburger()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ketchup", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Senap", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Frystorkad Lök", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(2);

            Dishes.GetOrCreateDish("Double Cheeseburger", 13, Ingredients, Quantities);
        }
    }

    public class BigMac : Dish
    {
        public BigMac()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Bic Mac Sås", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Frystorkad Lök", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Sallad", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);

            Dishes.GetOrCreateDish("Big Mac", 50, Ingredients, Quantities);
        }
    }

    public class McFeast : Dish
    {
        public McFeast()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Majonnäs", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Färsk Lök", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Sallad", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Tomat", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);

            Dishes.GetOrCreateDish("McFeast", 60, Ingredients, Quantities);
        }
    }

    public class QuarterPounder : Dish
    {
        public QuarterPounder()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ketchup", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Senap", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Färsk Lök", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(2);

            Dishes.GetOrCreateDish("Quarter Pounder", 60, Ingredients, Quantities);
        }
    }

    public class DoubleQuarterPounder : Dish
    {
        public DoubleQuarterPounder()
            : base()
        {
            Ingredient _1 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ketchup", 3);
            Ingredient _2 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Senap", 3);
            Ingredient _3 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Färsk Lök", 3);
            Ingredient _4 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Gurka", 3);
            Ingredient _5 = Collection.Ingredients.Ingredients.GetOrCreateIngredient("Ost", 3);

            Ingredients.Add(_1);
            Ingredients.Add(_2);
            Ingredients.Add(_3);
            Ingredients.Add(_4);
            Ingredients.Add(_5);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(1);
            Quantities.Add(2);

            Dishes.GetOrCreateDish("Double Quarter Pounder", 60, Ingredients, Quantities);
        }
    }
}
