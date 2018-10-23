using System;
using System.Collections.Generic;
using System.Text;

namespace Page_100_Exercise_Lists_and_Arrays
{
    public class Employee
    {
        public int ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }




        public Employee()
        {
            ID = 0;
            fName = "";
            lName = "";
        }

        public Employee(int id, string FirstName, string LastName)
        {
            ID = id;
            fName = FirstName;
            lName = LastName;
        }

        public void printE()
        {
            Console.WriteLine(this.ID.ToString());
            Console.WriteLine(this.fName.ToString());

            Console.WriteLine(this.lName.ToString());

        }
    }

    
}
