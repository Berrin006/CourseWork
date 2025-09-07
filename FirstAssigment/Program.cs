
using FirstAssigment;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();

        products.Add(new Product("Samsung Galaxy S20 FE", 2020 , 5000));
        products.Add(new Product("Iphone 13", 2021, 9000));
        products.Add(new Product("Xiaomi Mi 11", 2021, 6000));

        foreach(var product in products)
        {
            product.PrintInfo();
        }
    }
}