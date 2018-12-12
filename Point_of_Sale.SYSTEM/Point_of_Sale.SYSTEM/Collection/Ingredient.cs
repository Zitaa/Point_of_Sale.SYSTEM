
namespace Point_of_Sale.SYSTEM.Collection
{
    internal interface IIngredient
    {
        string Name { get; set; }
        uint ExtraCost { get; set; }
    }

    public class Ingredient : IIngredient
    {
        public string Name { get; set; }
        public uint ExtraCost { get; set; }

        public Ingredient(string name, uint extraCost)
        {
            Name = name;
            ExtraCost = extraCost;
        }

        public override string ToString() { return Name; }
    }
}
