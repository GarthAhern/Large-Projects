﻿using System;

namespace Exercise_Page_113
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            state x = new state();
            x.Operation(x);

            state.Operation(3, 4);
        }
    }
}
