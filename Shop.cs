public class Shop
{
    public List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        Products.Remove(product);
    }

    public void PrintProductList()
    {
        if (Products.Count == 0)
        {
            Console.WriteLine("В магазине нет товаров.");
            return;
        }

        foreach (Product product in Products)
        {
            product.PrintInfo();
        }
    }
}