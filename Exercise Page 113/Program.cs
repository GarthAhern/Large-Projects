using System;

namespace Exercise_Page_113
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            state x = new state();
            x.Operation(x);

            state y = new state(4, 5);

            state.Operation(3, 4);

            state state2 = new state(5, 7);

            //Here is the addition I made since the last submission:
            state.Operation(x: state2.a, y: state2.b);

            

        }
    }
}
