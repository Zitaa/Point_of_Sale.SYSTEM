using Point_of_Sale.SYSTEM.Collection.Ingredients;

namespace Point_of_Sale.SYSTEM.Collection
{
    public class Ingredient : IIngredient
    {
        public string Name { get; set; }
        public uint ExtraCost { get; set; }

        public override string ToString() { return Name; }
    }
}
