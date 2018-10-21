using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_134
{
    public class DaysOfTheWeek
    {

        public Day day { get; set; }



        public enum Day{ 
            Monday = 0,
            Tuesday = 1,
            Wednesday = 2,
            Thursday = 3,
            Friday = 4,
            Saturday = 5,
            Sunday = 6
        }

        
        public void setDay(Day d)
        {
            day = d;
        }

    }
}
