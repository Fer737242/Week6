namespace assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            Console.Write("Enter product name: ");
            string Name = Console.ReadLine();

            Console.Write("Enter product price: ");
            double Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Product Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");

            Product product = new Product();
        }
        class Product
        {
            public string Name;
            private double Price;
        }
    }
}