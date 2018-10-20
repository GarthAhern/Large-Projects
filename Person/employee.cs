using System;
using System.Collections.Generic;
using System.Text;

namespace Person 
{
    public class employee : person, IQuitAble
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
         

        public void Quit()
        {
            Console.WriteLine();
            //this.ID = 0;
            //this.fname = "";
            //this.lname = "";
        }


        public override bool Equals(object obj)
        {
            return Math.Abs(ID - ((employee)obj).ID) <= 5;
        }
        public override int GetHashCode()
        {
            return 0;
        }





        public static bool operator!= (employee a, employee b) 
        {
            if (a.ID != b.ID)
            {
                return true;
            }
            else return false;
        }
        public static bool operator== (employee a, employee b)
        {
            if (a.ID == b.ID)
            {
                return true;
            }
            else return false;
        }
    }
}
