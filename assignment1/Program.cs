namespace assignment1
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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            //This is an object
            Person person = new Person(name, age);

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
        }
        class Person
        {
            private string _name;
            private int _age;

            //this is the constructor
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            //public property
            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            //public property
            public int Age
            {
                get { return _age; }
                set { _age = value; }
            }

        }
    }
}