﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class Card
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
         
        public string Suit{
            get;
            set;
        }
        public string Face{
            get;
            set;
        }

    }
}