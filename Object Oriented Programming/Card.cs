﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public struct Card
    {
        public Suit suit{get;set;}
        public Face face{
            get;
            set;
        }
        //public Card()
        //{
        //    Suit = suit.Diamonds;
        //    Face = "Two";
        //}

        public enum Suit{
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }
         public enum Face
        {
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen, 
            King,
            Ace
        }
        

    }
}
