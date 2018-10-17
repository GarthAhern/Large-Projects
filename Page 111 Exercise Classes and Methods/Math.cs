using System;
using System.Collections.Generic;
using System.Text;

namespace Page_111_Exercise_Classes_and_Methods
{
    class Math
    {
        public int a { get; set; }
        public int b { get; set; }

        public Math()
        {
            a = 0;
            b = 0;

        }
        public Math(int A, int B)
        {
            a = A;
            b = B;

        }
        public void setA(int x)
        {
            this.a = x;
        }
        public void setB(int x)
        {
            this.b = x;
        }
        public int Sum()
        {
            int sum = this.a + this.b;
            return sum;
        }
        public int Product()
        {
            int product = this.a * this.b;
            return product;
        }
        public int Difference()
        {
            int diff = this.a - this.b;
            return diff;
        }
        public int Quotient()
        {
            int div = this.a / this.b;
            return div;
        }
        public void print()
        {
            Console.WriteLine("A = " + a + " B = " + b);
        }

    }
}
