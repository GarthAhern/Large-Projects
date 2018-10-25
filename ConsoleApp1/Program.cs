using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {

        



        static void Main(string[] args) {


            Console.WriteLine("Please provide us with a number: ");
            string s = Console.ReadLine();
            File.WriteAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt", s);
            Console.WriteLine(File.ReadAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt"));
            Console.ReadLine();
           



            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt", text);

            //string text2 = File.ReadAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt");
            //Console.WriteLine(text2);
            //Console.ReadLine();






            //int x = 0;
            //bool speed = false;
            //while (speed == false)
            //{
            //    switch (x)
            //   {

            //            case 1:

            //        Console.WriteLine("Sorry, but no.");
            //        break;


            //    case 2:
            //        Console.WriteLine("Sorry, but no.");
            //        break;

            //    case 3:
            //        Console.WriteLine("Sorry, but no.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Sorry, but no.");
            //        break;
            //    case 5:
            //        Console.WriteLine("Sorry, but no.");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sorry, but no.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sorry, but no.");
            //        break;

            //    case 8:
            //        Console.WriteLine("Sorry, but no.");
            //        break;
            //    case 9:
            //        Console.WriteLine("Congrats.");
            //            speed = true;
            //            break;

            //    default:
            //        Console.WriteLine("You are wrong");
                        
            //            break;
            //    }
            //    x++;
            //}
            //Console.ReadLine();



            //int y = 0;
            //bool choice = true;
            
            //    do
            //{
            //    switch (y)
            //    {

            //        case 1:

            //            Console.WriteLine("Sorry, but no.");
            //            break;


            //        case 2:
            //            Console.WriteLine("Sorry, but no.");
            //            break;

            //        case 3:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 5:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sorry, but no.");
            //            break;

            //        case 8:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 9:
            //            Console.WriteLine("Congrats.");
                        
            //            break;

            //        default:
            //            Console.WriteLine("You are wrong");
            //            choice = true;
            //                break;
            //    }
            //}
            //while (choice == false);
            //Console.ReadLine();











            //bool bob = false;
            //while (!bob)
            //{

            //}

            //bool isGuessed = false;
            //while (!isGuessed)
            //{
            //    Console.WriteLine("Please guess a number between 1 and 10.");
            //    int number = Convert.ToInt16(Console.ReadLine());
            //    switch (number)
            //    {

            //        case 1:

            //            Console.WriteLine("Sorry, but no.");
            //            break;


            //        case 2:
            //            Console.WriteLine("Sorry, but no.");
            //            break;

            //        case 3:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 4:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 5:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sorry, but no.");
            //            break;

            //        case 8:
            //            Console.WriteLine("Sorry, but no.");
            //            break;
            //        case 9:
            //            Console.WriteLine("Congrats.");
            //            isGuessed = true;
            //            break;

            //        default:
            //            Console.WriteLine("You are wrong");
            //            break;
            //    }

            //}


            //Console.Read();




            //Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            //Console.WriteLine("Please sir, what is the package weight?");
            //double wght = Convert.ToDouble(Console.ReadLine());

            //if (wght > 50)
            //{

            //    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            //    Console.ReadLine();

            //    return;

            //}

            //Console.WriteLine("Please sir, what is the width?");
            //double width = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please sir, what is the height?");
            //double height = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Please sir, what is the length?");
            //double length = Convert.ToDouble(Console.ReadLine());

            //Console.ReadLine();


            //double total = length + height + width;
            //if (total > 50)
            //{
            //    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
            //    Console.ReadLine();
            //    return;

            //}
            //double quote = (total * wght) / 100;
            //Console.WriteLine("Your estimated total for shipping this package is: $" + quote);

            //Console.ReadLine();







            //int roomTemperature = 70;
            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine


            //int currentTemp = 80;
            //int roomTemp = 80;
            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //bool dui = true;
            //Console.WriteLine("What is your age?");
            //double age = Convert.ToDouble(Console.ReadLine());
            //bool d = false;         
            //while (d == false){
            //    Console.WriteLine("Have you ever had a DUI?");
            //    string DUI = Console.ReadLine();

            //    if (DUI == "yes")
            //    {
            //        dui = true;
            //        d = true;
            //    }
            //    else if (DUI == "no") {
            //        dui = false;
            //        d = true;
            //    }

            //}

            //Console.WriteLine("How many speeding tickets do you have?");
            //int tickets = Convert.ToInt16(Console.ReadLine());
            //if(age >= 15 && dui == false && tickets <= 3) 
            //{
            //    Console.WriteLine("Congratulations, you qualify for car insurance!");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Sorry, but you do not qualify.");
            //    Console.ReadLine();
            //}

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








