using System;
using System.Collections.Generic;
using System.Text;

namespace Page_97_Exercise_Modifying_Strings
{
    class Atom
    {

        public string Name { get; set; }
        public int AtomicNumber { get; set; }
        public decimal AtomicWeight { get; set; }
        public Atom(string name, int atomicnumber, decimal atomicweight)
        {
            Name = name;
            AtomicNumber = atomicnumber;
            AtomicWeight = atomicweight;

        }

        public Atom(string name) : this(name, 1, 1.008m)
        {

        }
        public Atom(int atomicnumber) : this("Hydrogen", atomicnumber, 1.008m)
        {

        }
        public Atom(decimal atomicweight) : this("Hydrogen", 1, atomicweight)
        {

        }
        public Atom()
        {
            Name = "Hydrogen";
            AtomicNumber = 1;
            AtomicWeight = 1.008m;
        }

        //Used the var keyword to instantiate a decimal variable.
        public static void setX()
        {
            var x = 44.32355m;

        }
        //Used the keyword Constant
        const string specificHeatofWater = "4.186m joule/gram °C ";
        const int y = 5;



        

    }

}
