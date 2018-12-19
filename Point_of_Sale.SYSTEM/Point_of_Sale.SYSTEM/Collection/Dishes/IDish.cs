using System.Collections.Generic;

namespace Point_of_Sale.SYSTEM.Collection.Dishes
{
    internal interface IDish
    {
        string Name { get; set; }
        uint Cost { get; set; }
        List<Ingredient> Ingredients { get; set; }
        List<uint> Quantities { get; set; }

        string PrintIngredients();
    }
}
