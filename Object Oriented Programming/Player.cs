using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }



    }
}
