using System;

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


        }
    }
}
