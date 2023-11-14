using Microsoft.Build.Tasks.Deployment.Bootstrapper;
internal class Program
{
    private static void Main(string[] args)
    {
        {
            static void DisplayProducts(List<Product> products)
            {
                if (products.Count == 0)
                {
                    Console.WriteLine("Товари не знайдені.");
                    return;
                }

                Console.WriteLine("Знайдені товари:");
                foreach (var product in products)
                {
                    Console.WriteLine($"Назва: {product.Name}");
                    Console.WriteLine($"Ціна: {product.Price:C}");
                    Console.WriteLine(value: $"Опис: {product.Description}");
                    Console.WriteLine();
                }
            }
        }
    }
}