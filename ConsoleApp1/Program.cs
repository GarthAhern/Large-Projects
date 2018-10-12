using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);

            //Console.WriteLine("What is your favorite number? ");
            //string favoriteNumber = (Console.ReadLine());
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number is : " + favoriteNumber);
            //Console.ReadLine();


            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char alpha = 'C';
            //char questionMark = '\u2103';
            //decimal moneyInBank = 100.5m;
            //double heightInCentimeters = 21.4485309489537;
            //float secondsLeft = 2.62f;


            Console.WriteLine("The Tech Academy \n Student Daily Report \n What course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pNum = Convert.ToInt32(Console.ReadLine());
            string backupPNum = pNum.ToString();
            Console.WriteLine("Do you need help with anything? Please answer" +
                " 'true' or 'false'");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string posExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            float hours = float.Parse(Console.ReadLine());
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.WriteLine("Course on: " + currentCourse + "\nPage Number: " + pNum + "\nNeeds help: " + needsHelp + "\nExperiences: " + posExperience
               + "\nFeedback: " + feedback + "\nHours studied: " + hours);
            Console.ReadLine();





        }
    }
}








