using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Int32> nums = new List<Int32>();
                nums.Add(5);
                nums.Add(8);
                nums.Add(7);
                nums.Add(12);
                nums.Add(15);
                nums.Add(20);
                nums.Add(17);
                nums.Add(42);
                nums.Add(66);

                Console.WriteLine("Please provide a number to divide by.");
                int y = Convert.ToInt32(Console.ReadLine());
                for (int x = 0; x < nums.Count; x++)
                {
                    nums[x] = (nums[x] / y);
                    Console.WriteLine(nums[x]);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("No errors detected.");
            Console.ReadLine();








            //try
            //{
            //    console.writeline("pick a number.");
            //    int numberone = convert.toint32(console.readline());
            //    console.writeline("pick a second number.");
            //    int numbertwo = convert.toint32(console.readline());
            //    console.writeline("dividing the two....");
            //    int numberthree = numberone / numbertwo;
            //    console.writeline("the answer is " + numberthree);

            //}
            //catch (formatexception ex)
            //{
            //    console.writeline(ex.message);
            //    return;
            //}
            //catch (dividebyzeroexception ex)
            //{
            //    console.writeline("please don't divide by zero.");

            //}
            //catch (exception e)
            //{
            //    console.writeline(e.message);
            //}
            //finally
            //{
            //    console.readline();
            //}
            //console.readline();
        }
    }
}



