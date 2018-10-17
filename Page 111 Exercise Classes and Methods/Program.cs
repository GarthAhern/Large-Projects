using System;

namespace Page_111_Exercise_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            greetUser();

            Console.WriteLine("Please choose the first number you would like to do Math operations on: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please choose the second number you would like to do Math operations on: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Math a = new Math(x,y);

            Console.WriteLine("Adding them together: ");
            Console.WriteLine(a.Sum());

            Console.WriteLine("Subtracting them: ");
            Console.WriteLine(a.Difference());

            Console.WriteLine("Dividing them: ");
            Console.WriteLine(a.Quotient());

            Console.WriteLine("Multiplying them: ");
            Console.WriteLine(a.Product());


            a.print();
            Console.ReadKey();


            int c = new int();
           
        }

        public static void greetUser()
        {
            Console.WriteLine("Hello World");
            
        }
    }
}
