using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _dealer = new List<Card>();
        public List<Card> Hand { get { return _dealer; } set { _dealer = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }


    }
}
