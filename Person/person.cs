using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{ 
    public class person 
    {
        public string fname {get; set;}
        public string lname {get; set;}

        public person()
        {
            fname = "";
            lname = "";

        }
        public person(string FirstName, string LastName)
        {
            fname = FirstName;
            lname = LastName;
        }
        public virtual void sayName()
        {
            Console.WriteLine("Name: " + "{0} {1}",fname, lname);
        }
        

    }
}
