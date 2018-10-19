using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public abstract class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void playGame();

        public virtual void ListPlayers()
        {
            foreach( string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
