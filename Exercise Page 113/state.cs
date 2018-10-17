using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Page_113
{
    public class state
    {
        public int a { get; set; }
        public int b { get; set; }

        public state()
        {
            a = 0;
            b = 0;

        }
        public state(int A, int B)
        {
            a = A;
            b = B;

        }
        public static void Operation(int x, int y)
        {
            x = x * 9;
            Console.WriteLine(y);
            Console.ReadLine();
        }
        public void Operation(state s)
        {
            s.a = s.a * 9;
            Console.WriteLine(s.b);
            Console.ReadLine();
        }

    }
}
