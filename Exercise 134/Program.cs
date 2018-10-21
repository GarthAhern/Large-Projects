using System;

namespace Exercise_134
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please write a day of the week: ");
                string a = Console.ReadLine();
                int trueVal = 0;

                switch (a)
                {
                    case "Monday":
                        trueVal = 0;
                        break;
                    case "Tuesday":
                        trueVal = 1;
                        break;
                    case "Wednesday":
                        trueVal = 2;
                        break;
                    case "Thursday":
                        trueVal = 3;
                        break;
                    case "Friday":
                        trueVal = 4;
                        break;
                    case "Saturday":
                        trueVal = 5;
                        break;
                    case "Sunday":
                        trueVal = 6;
                        break;
                    default:
                        Console.WriteLine("Please pick an actual day of the week");
                        break;
                }

                DaysOfTheWeek d = new DaysOfTheWeek();
                d.day = (DaysOfTheWeek.Day)trueVal;


                Console.WriteLine(d.day);
                Console.WriteLine(d.GetType());
                Console.ReadLine();
                d.setDay(DaysOfTheWeek.Day.Monday);
            }catch(Exception e)
            {
                Console.WriteLine("Error: Please pick an actual day of the week");
            }
            Console.ReadLine();
        }
    }
}
