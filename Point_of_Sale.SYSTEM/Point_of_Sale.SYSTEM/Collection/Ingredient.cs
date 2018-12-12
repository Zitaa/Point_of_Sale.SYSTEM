
namespace Point_of_Sale.SYSTEM.Collection
{
    internal interface IIngredient
    {
        string Name { get; set; }
        uint ExtraCost { get; set; }
        uint Quantity { get; set; }
    }

    public class Ingredient : IIngredient
    {
        public string Name { get; set; }
        public uint ExtraCost { get; set; }
        public uint Quantity { get; set; }

        public override string ToString() { return Name; }
    }
}
