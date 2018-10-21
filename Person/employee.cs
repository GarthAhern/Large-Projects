using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Person 
{
    public class employee<T> //: person//, IQuitAble
    {

        public int ID { get; set; }
        public List<T> Things { get; set; }
        

        public void Add(T value)
        {

        }
        public employee()
        {
            List<T> x = new List<T>();
            Things = x;
            ID = 0;
        }
        public employee(int t, T v)
        {
            List<T> x = new List<T>();
            Things = x;
            Things.Add(v);
            ID = t;
            
            

        }

        
        
        //public employee(int id)
        //{
        //    ID = id;
            
        //}
        public void Print()
        {
            for (int x = 0; x < this.Things.Count; x++)
            {
                Console.WriteLine(this.Things[x]);
            }

            Console.ReadLine();
        }
        //public void setID(int s)
        //{
        //    ID = s;
        //}
        //public int getID(employee e)
        //{
        //    return e.ID; 
        //}



        //public void Quit()
        //{
        //Console.WriteLine();
        //this.ID = 0;
        //this.fname = "";
        //this.lname = "";
        //}


        //public override bool Equals(object obj)
        //{
        //    return Math.Abs(ID - ((employee)obj).ID) <= 5;
        //}
        //public override int GetHashCode()
        //{
        //    return 0;
        //}





        //public static bool operator!= (employee a, employee b) 
        //{
        //    if (a.ID != b.ID)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
        //public static bool operator== (employee a, employee b)
        //{
        //    if (a.ID == b.ID)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}
    }
}
