﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Page_114
{
    class Class1
    {
        public int ClassInt { get; set; }
        public decimal ClassDecimal { get; set; }
        public string ClassString { get; set; }


        public Class1()
        {
            ClassInt = 0;
            ClassDecimal = 0;
            ClassString = "zero";
        }
        public Class1(int x, decimal z, string y)
        {
            ClassInt = x;
            ClassDecimal = z;
            ClassString = y;
        }

     

        public static int Op1(int x)
        {
            x = (((x * 9)*100)/2);
            return x;

        }

        public static int Op1(Decimal d)
        {
            Random r = new Random();
            d = d * r.Next(1 * 100);
            return Convert.ToInt32(d);
        }

        public static int Op1(string m)
        {
            int temp = Convert.ToInt32(m);
            temp = temp % 2;
            return temp;
        }

    }
}
