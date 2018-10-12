using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool dui = true;
            Console.WriteLine("What is your age?");
            double age = Convert.ToDouble(Console.ReadLine());
            bool d = false;         
            while (d == false){
                Console.WriteLine("Have you ever had a DUI?");
                string DUI = Console.ReadLine();
                
                if (DUI == "yes")
                {
                    dui = true;
                    d = true;
                }
                else if (DUI == "no") {
                    dui = false;
                    d = true;
                }
                
            }
         
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt16(Console.ReadLine());
            if(age >= 15 && dui == false && tickets <= 3) 
            {
                Console.WriteLine("Congratulations, you qualify for car insurance!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, but you do not qualify.");
                Console.ReadLine();
            }

            //Console.WriteLine(9 > 8 && 7 < 6);
            //Console.ReadLine();
            
            //Console.WriteLine("Anonymous Income Comparison Program: \n Person 1: \nPlease enter Hourly Rate: ");
            //double hourlyRate1 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter the number of hours worked per week: ");
            //double hoursWorkedPerWeek1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("\n Person 2: \nPlease enter Hourly Rate: ");
            //double hourlyRate2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Please enter the number of hours worked per week: ");
            //double hoursWorkedPerWeek2 = Convert.ToDouble(Console.ReadLine());
            //double AnnualSalary1 = (hourlyRate1 * hoursWorkedPerWeek1 * 52);
            //double AnnualSalary2 = (hourlyRate2 * hoursWorkedPerWeek2 * 52);
            //Console.WriteLine("Annual Salary of Person 1: $" + AnnualSalary1);
            //Console.WriteLine("Annual Salary of Person 1: $" + AnnualSalary2);

            //Console.WriteLine("Does Person 1 make more than Person 2?");
            //if (AnnualSalary1 > AnnualSalary2)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");

            //}

            //Console.ReadLine();






            ////Exercise p. 66
            //Console.WriteLine("Please give me a number: ");
            //decimal x = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Your number multiplied by 50 is: " + (x * 50));
            //Console.WriteLine("Your number multiplied plus 25 is: " + (x + 25));

            //Console.WriteLine("Your number divided by 12.5 is: " + (x / 12.5m));
            //Console.WriteLine("The remainder of your number after dividing by 7 is: " + (x % 7));
            //Console.ReadLine();






            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);

            //Console.WriteLine("What is your favorite number? ");
            //string favoriteNumber = (Console.ReadLine());
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number is : " + favoriteNumber);
            //Console.ReadLine();

            //7
            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemp = -23;
            //char alpha = 'C';
            //char questionMark = '\u2103';
            //decimal moneyInBank = 100.5m;
            //double heightInCentimeters = 21.4485309489537;
            //float secondsLeft = 2.62f;


            //Console.WriteLine("The Tech Academy \n Student Daily Report \n What course are you on?");
            //string currentCourse = Console.ReadLine();
            //Console.WriteLine("What page number?");
            //int pNum = Convert.ToInt32(Console.ReadLine());
            //string backupPNum = pNum.ToString();
            //Console.WriteLine("Do you need help with anything? Please answer" +
            //    " 'true' or 'false'");
            //bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            //string posExperience = Console.ReadLine();
            //Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            //string feedback = Console.ReadLine();
            //Console.WriteLine("How many hours did you study today?");
            //float hours = float.Parse(Console.ReadLine());
            //Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            //Console.WriteLine("Course on: " + currentCourse + "\nPage Number: " + pNum + "\nNeeds help: " + needsHelp + "\nExperiences: " + posExperience
            //   + "\nFeedback: " + feedback + "\nHours studied: " + hours);
            //Console.ReadLine();





        }
    }
}








