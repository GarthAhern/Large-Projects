using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class Deck
    {
       
        public Deck()
        {

            Cards = new List<Card>();

            List<string> Suits = new List<string>() {
                "Clubs", "Hearts", "Diamonds", "Spades"
            };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach(string face in Faces)
            {
                foreach(string suit in Suits)
                {
                    Card c = new Card();
                    c.Suit = suit;
                    c.Face = face;
                    Cards.Add(c);
                
                }
            }
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);


        }

        public List<Card> Cards
        {
            get;
            set;
        }

        public void Shuffle(int times = 1)//optional variable times
        {

            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random r = new Random();
                while (Cards.Count > 0)
                {
                    int randomIndex = r.Next(0, Cards.Count);
                    tempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = tempList;
            }
        }

        public void printDeck()
        {
            foreach (Card card in this.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);

            }
            Console.WriteLine(this.Cards.Count);
        }

    }
}
