using System;

namespace Exercise_Page_114
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Class1.Op1(5));

            Class1 e = new Class1(3, 55.23423525m, "20");
            Console.WriteLine(Class1.Op1(e.ClassInt));

            Console.WriteLine(Class1.Op1(e.ClassDecimal));

            Console.WriteLine(Class1.Op1(e.ClassString));
            Console.ReadLine();
        }
    }
}
