using System;

namespace Person
{
     public class Program 
    {
        static void Main(string[] args)
        {


            employee<string> z = new employee<string>(5, "dlfksjd");
            employee<int> a = new employee<int>(5, 5);
            z.Things.Add("sldkfjs");
            
            z.Things.Add("Hello");
            z.Things.ToString();

            z.Things.Add("Well, Hello there.");
            for(int x = 0; x < z.Things.Count; x++)
            {
                Console.WriteLine(z.Things[x]);
            }
            

            Console.ReadLine();

            a.Things.Add(4);
            a.Things.Add(7);

            for (int x = 0; x < a.Things.Count; x++)
            {
                Console.WriteLine(a.Things[x]);
            }

            Console.ReadLine();
            a.Print();

            //person p = new person("Bob", "Chisolm");
            //p.sayName();
            //Console.ReadLine();

            //employee e = new employee(5);

            //Console.ReadLine();
            //e.lname = "Bartlett";
            //e.fname = "Joe";
            //Console.ReadLine();




            //employee x = new employee();
            //x.fname = "Joanne";
            //x.lname = "Higgins";
            //x.sayName();
            //x.Quit();
            //x.sayName();
            //Console.ReadLine();

            //IQuitAble bob = new employee();

            //bob.Quit();
            //Console.WriteLine(bob.ToString());

            //Console.ReadLine();







        }
    }
}
