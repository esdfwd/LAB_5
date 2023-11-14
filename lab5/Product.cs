internal partial class ProductBuilder
{

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private static ProductBuilderBase(string name, double price, string description)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        string Name = name;
        double Price = price;
        string Description = description;
    }
}

private string? Name;
private double price;
private string? description;
