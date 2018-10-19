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
            
            ID = 0;
        }
        public employee(int id)
        {
            ID = id;
            
        }
        public void setID(int s)
        {
            ID = s;
        }
        public int getID(employee e)
        {
            return e.ID; 
        }
         

    }
}
