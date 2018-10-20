using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void playGame();

        public virtual void ListPlayers()
        {
            foreach( Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
