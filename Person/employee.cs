using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class employee : person
    {

        int ID { get; set; }

        

        public employee()
        {
            fname = "";
            lname = "";
            ID = 0;
        }
        public employee(int id)
        {
            ID = id;
            
        }
        public employee(string FirstName, string LastName, int id)
        {
            fname = FirstName;
            lname = LastName;
            ID = id;
        }
    }
}
