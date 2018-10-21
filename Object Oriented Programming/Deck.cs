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

            for (int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.face = (Card.Face)i;
                    card.suit = (Card.Suit)j;
                    Cards.Add(card);
                }
            }
            

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

        //public void printDeck()
        //{
        //    foreach (Card card in this.Cards)
        //    {
        //        Console.WriteLine(card.Face + " of " + card.Suit);

        //    }
        //    Console.WriteLine(this.Cards.Count);
        //}

    }
}








//List<string> Suits = new List<string>() {
//                "Clubs", "Hearts", "Diamonds", "Spades"
//            };
//List<string> Faces = new List<string>()
//            {
//                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
//            };

//            foreach(string face in Faces)
//            {
//                foreach(string suit in Suits)
//                {
//                    Card c = new Card();
//c.Suit = suit;
//                    c.Face = face;
//                    Cards.Add(c);
                
//                }
//            }
//            //Cards = new List<Card>();
//            //Card cardOne = new Card();
//            //cardOne.Face = "Two";
//            //cardOne.Suit = "Hearts";
//            //Cards.Add(cardOne);
