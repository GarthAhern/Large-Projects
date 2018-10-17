using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise115
{
    class point
    {
        public static int action1(int firstInt, int secondInt = 0, string str = "")
        {
            firstInt = firstInt * 10 + 7;
            secondInt = secondInt - 2 * 3;
            int i = firstInt + secondInt;

            return i;
        }

    }
}
