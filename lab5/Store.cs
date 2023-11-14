using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System.Diagnostics;
using System.Xml.Linq;
internal partial class ProductBuilder : ProductBuilderBase
{
    public static string Name { get; private set; }
    public static string Description { get; private set; }

#pragma warning disable IDE0060 // Remove unused parameter
    private static ProductBuilder(string name, double price, string description)
#pragma warning restore IDE0060 // Remove unused parameter
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        }

        if (string.IsNullOrEmpty(description))
        {
            throw new ArgumentException($"'{nameof(description)}' cannot be null or empty.", nameof(description));
        }

        Name = name;
        Description = description;
    }
}

private.string.Name;
private double price1;
private string? Description1;

#pragma warning disable CS8321 // Local function is declared but never used
public static string? GetDescription(Program program)
{
    return program.Description1;
}
#pragma warning restore CS8321 // Local function is declared but never used