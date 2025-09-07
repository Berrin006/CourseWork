namespace FirstAssigment
{
    class Product
    {
        public string Mobile { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }


        public Product(string mobile, int year, int price)
        {
            Mobile = mobile;
            Year = year;
            Price = price;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Telefon: " + Mobile + ", År: " + Year + ", Pris: " + Price + " Kr");

        }

    }
}