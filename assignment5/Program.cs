namespace InClassExercise
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
            Console.Write("Original value: ");
            int value = int.Parse(Console.ReadLine());
            
            //this is how you call the method, otherwise it won't show
            ModifyByValue(value);
            Console.WriteLine($"Value after ModifyByValue: {value}");

            //call the method
            ModifyByReference(ref value);
        
            Console.WriteLine($"Value after ModifyByReference: {value}");
        }
        static void ModifyByValue(int value)
        {
            value = 20;
        }
        static void ModifyByReference(ref int value)
        {
            value = 20;
        }


    }
}