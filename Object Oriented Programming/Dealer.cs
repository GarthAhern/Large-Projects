using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    public class Dealer
    {

        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {

            Hand.Add(Deck.Cards.First());
            
            string card = string.Format(Deck.Cards.First().ToString() + "\n");

            Console.WriteLine(card);

            using (StreamWriter file = new StreamWriter(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt", true))
            {
                file.WriteLine(card);
            }
                Deck.Cards.RemoveAt(0);

        }
    }
}
