using System;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            person p = new person("Bob", "Chisolm");
            p.sayName();
            Console.ReadLine();

            employee e = new employee(5);
            
            Console.ReadLine();
            e.lname = "Bartlett";
            e.fname = "Joe";
            Console.ReadLine();

        }
    }
}
