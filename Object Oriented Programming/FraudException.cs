using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class FraudException : Exception
    {
        public FraudException() 
            : base() { }
        public FraudException(string message)
            : base(message) { }
        

    }
}
