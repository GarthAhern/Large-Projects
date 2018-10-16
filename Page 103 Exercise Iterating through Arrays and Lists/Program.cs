using System;
using System.Collections.Generic;
using System.Collections;

namespace Page_103_Exercise_Iterating_through_Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.
            string[] zep = {"hello", "rotten", "clandestine",
                "phenotype", "regolith", "polychete", "ophiolite",
                "phenocryst", "topological",
            "extrusive", "ignimbright"};
            Console.WriteLine("please write some text to append to each value in the array.");
            string data = Console.ReadLine();
            for (int x = 0; x < zep.Length; x++)
            {
                zep[x] = zep[x] + data;
                Console.WriteLine(zep[x]);

            }
            Console.ReadLine();

            //2.
            //this is the infinite loop, which will never stop because
            //y is never decremented. i've commented it out, so that it doesn't 
            //run.
            //int y = 10;
            //while (y > 0)
            //{ Console.WriteLine("minimum value has not been reached."); }

            //3.
            //this is the fixed version of the infinite loop above.
             int y = 10;
            while (y > 0)
            { Console.WriteLine("minimum value has not been reached."); y--; }


            //4.
            Console.WriteLine("\npick a number between 1 and 30");
            int b = Convert.ToInt16(Console.ReadLine());
            while (b < 30)
            {
                Console.WriteLine(b);
                b++;
            }
            Console.ReadLine();


            //5.
            int n = 1;
            while (n <= 1000)
            {
                n = n * 3;
                Console.WriteLine(n);
            }
            Console.ReadLine();


            //6.
            string[] str = { "a", "b", "c", "d", "e", "f",
                "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r",
                "s","t","u","v","w","x","y","z"};
            Console.WriteLine("Please pick a letter to determine where it is in " +
                "the alphabet.");
            string d = Console.ReadLine();
            int total = 0;
            for (int x = 0; x < str.Length; x++)
            {
                
                if (str[x] == d)
                {
                    
                    Console.WriteLine("Letter: " + d + "\nIndex: " + x);
                    total++;
                    
                }
                //8.
                if (total != 0)
                {
                    break;
                }
                
            }
            //7.
            if (total == 0)
            {
                Console.WriteLine("I'm sorry, but there was no match. The string you chose is not in the array.");
            }
            Console.ReadLine();


            //9.
            string[] strArry = { "a", "b", "c", "d", "e", "a",
                "g", "h", "i", "j", "k", "l", "b", "n", "o", "p", "q", "r",
                "s","t","u","v","c","x","y","c"};
            Console.WriteLine("Please pick a letter to determine where it is in " +
                "the alphabet.");
            string e = Console.ReadLine();
            bool dup = false;
            int tot = 0;
            for (int x = 0; x < strArry.Length; x++)
            {
                for (int l = 0; l < strArry.Length; l++)
                {
                    if (e == strArry[x])
                    {

                        if (strArry[x] == strArry[l] && x != l)
                        {
                            Console.WriteLine("\nThere was a match for a duplicate: " + e + "\nAt index: " + x);
                            tot++;
                            dup = true;
                            break;

                        }
                        else if (strArry[x] == strArry[l] && x == l)
                        {
                            Console.WriteLine("Letter: " + e + "\nIndex: " + x);
                            tot++;
                            break;
                        }
                        
                    }     
                }
                
            }
            //10.
            if ((dup == false) && (tot == 0))
            {
                Console.WriteLine("You entered a string that was not in the array.");
            }
            Console.WriteLine("There were " + (tot-1) + " duplicates.");
             
            Console.ReadLine();


            //9.
            List<string> fruits = new List<string>();
            fruits.Add("pears");
            fruits.Add("apples");
            fruits.Add("bananas");
            fruits.Add("apples");
            fruits.Add("oranges");
            fruits.Add("mango");
            fruits.Add("pears");

            int count = 0;
            foreach(string val in fruits){
                foreach (string v in fruits){
                    if ((val == v)&&(fruits.IndexOf(val)!=fruits.LastIndexOf(v))&&((fruits.IndexOf(val)< fruits.LastIndexOf(v))))
                        
                    
                    {
                        Console.WriteLine("\n" + val);
                        Console.Write("\nThis duplicate string appears at: " + fruits.IndexOf(v) + " and: " + fruits.LastIndexOf(v));
                        count++;
                        break;
                        
                        
                    }
                    
                    
                }
                

            }
            Console.WriteLine("\nThere were " + (count / 2) + " duplicates.");
            Console.ReadLine();
        }
    }
}



