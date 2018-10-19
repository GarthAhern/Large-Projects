using System;

namespace Exercise115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var Test1 = point.action1(4);
            var Test2 = point.action1(4, 3);
            Console.WriteLine(Test1);
            Console.WriteLine(Test2);
            Console.ReadLine();



            point.inputChoice();
            //var Test3 = 0;
            //int t2;
            ////Addition to the original submsision.
            //Console.WriteLine("Please choose a number to test.");
            //int t1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You can choose to pick a second number");
            //if (Console.ReadLine() == "")
            //{
            //    Test3 = point.action1(t1);
            //}

            //else
            //{
            //    t2 = Convert.ToInt32(Console.ReadLine());
            //    Test3 = point.action1(t1, t2);
            //}

            //Console.WriteLine(Test3);
            //Console.ReadLine();
        }
    }
}
