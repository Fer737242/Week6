namespace assignment2
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
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            // Object
            Book book = new Book(title, author);

            Console.WriteLine("Book details: ");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"Author: {book.Author}");
        }

        class Book
        {
            // These are the automated properties 
            public string Title { get; set; }
            public string Author { get; set; }

            // Constructor to initialize them
            public Book(string title, string author)
            {
                Title = title;
                Author = author;
            }
        }
    }
}
