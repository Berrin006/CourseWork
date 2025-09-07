
using FirstAssigment;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();


        foreach (var product in products)
        {
            product.PrintInfo();
        }


        Console.WriteLine("Hi and Welcome!");

        Console.Write("Please enter the product name: ");
        string productName = Console.ReadLine();

        Console.Write("Please enter the price: ");
        int price = int.Parse(Console.ReadLine()); 

        Console.WriteLine(" Product:  " + productName + " , Price: " + price + " kr ");



    }
}