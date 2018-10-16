using System;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 0;
            bool speed = false;
            while (speed == false)
            {
                switch (x)
                {

                    case 1:

                        Console.WriteLine("Sorry, but no.");
                        break;


                    case 2:
                        Console.WriteLine("Sorry, but no.");
                        break;

                    case 3:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 4:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 5:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 6:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 7:
                        Console.WriteLine("Sorry, but no.");
                        break;

                    case 8:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 9:
                        Console.WriteLine("Congrats.");
                        speed = true;
                        break;

                    default:
                        Console.WriteLine("You are wrong");

                        break;
                }
                x++;
            }
            Console.ReadLine();



            int y = 0;
            bool choice = true;

            do
            {
                switch (y)
                {

                    case 1:

                        Console.WriteLine("Sorry, but no.");
                        break;


                    case 2:
                        Console.WriteLine("Sorry, but no.");
                        break;

                    case 3:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 4:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 5:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 6:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 7:
                        Console.WriteLine("Sorry, but no.");
                        break;

                    case 8:
                        Console.WriteLine("Sorry, but no.");
                        break;
                    case 9:
                        Console.WriteLine("Congrats.");

                        break;

                    default:
                        Console.WriteLine("You are wrong");
                        choice = true;
                        break;
                }
            }
            while (choice == false);
            Console.ReadLine();








            //int[] numArray = new int[15];
            //numArray[0] = 5;
            //numArray[1] = 10;

            //numArray[2] = 42;

            //numArray[3] = 55;
            //numArray[4] = 66;
            //numArray[5] = 77;
            //numArray[6] = 88;
            //Console.WriteLine(numArray[0]);
            //Console.ReadLine();

            //int[] numar = new int[] { 5, 6, 4, 3, 2, 5, 76, 77, 4, 3, 36, 7 };


            //int[] narr = { 4, 74, 35, 67, 3, 5, 6, 7, 99 };


        }
    }
}