namespace assignment4
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
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());

            //object
            Circle circle = new Circle(radius);

            circle.DisplayInfo();
        }
        class Circle
        {
            private double _radius;
            public Circle(double radius)
            {
                _radius = radius;
            }

            //do the maths
            public double Area
            {
                get { return Math.PI * _radius * _radius; }
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Radius: {_radius}");
                Console.Write($"Area: {Area}");
            }
        }
    }
}