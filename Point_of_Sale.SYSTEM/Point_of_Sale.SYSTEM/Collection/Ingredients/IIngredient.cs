namespace Point_of_Sale.SYSTEM.Collection.Ingredients
{
    internal interface IIngredient
    {
        string Name { get; set; }
        uint ExtraCost { get; set; }

        string ToString();
    }
}
