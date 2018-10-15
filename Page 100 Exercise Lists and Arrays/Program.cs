using System;
using System.Collections.Generic;

namespace Page_100_Exercise_Lists_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] a = new string[] { "up", "down", "under", "between", "below", "beneath", "above", "through"};
            Console.WriteLine("Please select an index of the array between 0 and seven");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(a[x]);
            Console.ReadLine();



            int[] iarry = new int[] {10,9,8,7,6,5,4,3,2,1,0};
            Console.WriteLine("Please select an index of the array");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(iarry[x]);
            Console.ReadLine();

            for (x = 0;x>iarray.length;int++)
            {

            }



            List<string> strList = new List<string> {"Bob","Marty","Joe",
                "Shirley","Harold","Haley","Mike","Jan"};
            Console.WriteLine("Please select an index of the array between 0 and seven");
            x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(strList[x]);
            Console.ReadLine();

            


        }
    }
}
