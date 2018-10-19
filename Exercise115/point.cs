using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise115
{
    class point
    {
        public static int action1(int firstInt, int secondInt = 0, string str = "")
        {
            firstInt = firstInt * 10 + 7;
            secondInt = secondInt - 2 * 3;
            int i = firstInt + secondInt;

            return i;
        }

        public static void inputChoice()
            {
            int Test3 = 0;
        int t2;
        //Addition to the original submsision.
        Console.WriteLine("Please choose a number to test.");
            int t1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You can choose to pick a second number");
            string s = Console.ReadLine();
            if(s == "")
            {
                 Test3 = point.action1(t1);
            }

            else 
            {
                 t2 = Convert.ToInt32(s);
                Test3 = point.action1(t1, t2);
            }

            Console.WriteLine(Test3);
            Console.ReadLine();
            }
    }
}
