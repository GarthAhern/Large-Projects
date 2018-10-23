using System;
using System.Collections.Generic;
using System.Linq;

namespace Page_100_Exercise_Lists_and_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Employee> ex = new List<Employee>();
            Employee Bob = new Employee(0, "Bob", "Jenkins");
            ex.Add(Bob);
            Employee Charles = new Employee(1, "Charles", "Jenkins");
            ex.Add(Charles);
            Employee Sally = new Employee(2, "Sally", "Mayfield");
            ex.Add(Sally);
            Employee George = new Employee(3, "George", "Linton");
            ex.Add(George);
            Employee William = new Employee(4, "William", "Bryan");
            ex.Add(William);

            Employee Laura = new Employee(5, "Joe", "Kerns");
            ex.Add(Laura);
            Employee Sasha = new Employee(6, "Sasha", "Renkin");
            ex.Add(Sasha);
            Employee Hailie = new Employee(7, "Hailie", "Benson");
            ex.Add(Hailie);
            Employee Randolph = new Employee(8, "Joe", "Phillips");
            ex.Add(Randolph);
            Employee Rachel = new Employee(9, "Rachel", "Fields");
            ex.Add(Rachel);
            Employee Noel = new Employee(10, "Noel", "Gallagher");
            ex.Add(Noel);


            foreach (Employee e in ex)
            {

                if (e.fName == "Joe")
                {
                    e.printE();
                }
            }



            List<Employee> newList = ex.Where(x => x.fName == "Joe").ToList();
            

            foreach(Employee e in newList)
            {
                Console.WriteLine(e.fName.ToString());
            }
            Console.ReadLine();









            //string[] a = new string[] { "up", "down", "under", "between", "below", "beneath", "above", "through"};
            //Console.WriteLine("Please select an index of the array between 0 and seven");
            //int x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(a[x]);
            //Console.ReadLine();



            //int[] iarry = new int[] {10,9,8,7,6,5,4,3,2,1,0};
            //Console.WriteLine("Please select an index of the array");
            //x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(iarry[x]);
            //Console.ReadLine();

            //int[] testScores = { 72, 85, 93, 82, 66, 95, 98, 55, 42, 100 };
            //for (int x = 0; x < testScores.Length; x++)
            //{
            //    if (testScores[x] > 85) { 
            //        Console.WriteLine(testScores[x]);
            //    }
            //}
            //Console.ReadLine();


            //List<string> strList = new List<string> {"Bob","Marty","Joe",
            //    "Shirley","Harold","Haley","Mike","Jan"};
            //Console.WriteLine("Please select an index of the array between 0 and seven");
            //x = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine(strList[x]);
            //Console.ReadLine();

            


        }
    }
}
