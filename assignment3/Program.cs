namespace assignment3
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
            Console.Write("Enter car make: ");
            string make = Console.ReadLine();

            Console.Write("Enter model: ");
            string model = Console.ReadLine();

            Console.Write("Enter car year: ");
            int year = int.Parse(Console.ReadLine());


            //This is an object
            Car car = new Car(make, model, year);
            Console.WriteLine();
            Console.WriteLine("Car details:");
            Console.WriteLine($"Car: {car.Make}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Year: {car.Year}");
        }
        class Car
        {
            private string _make;
            private string _model;
            private int _year;

            //this is the constructor
            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }
            //public property
            public string Make
            {
                get { return _make; }
                set { _make = value; }
            }
            //public property
            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }
            //public property but integer bc of number handling
            public int Year
            {
                get { return _year; }
                set { _year = value; }
            }

        }
    }
}