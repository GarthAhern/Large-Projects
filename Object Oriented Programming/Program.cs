using System;
using System.Collections.Generic;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            //d = Shuffle(d);
            d = Shuffle(d, 4);
            d.printDeck();
            Console.WriteLine("-----------------------------------------------");
            Shuffle(d);
            d.printDeck();


            //foreach(Card card in d.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);

            //}
            //Console.WriteLine(d.Cards.Count);


            




            //d.Cards = new List<Card>();

            //Card cardOne = new Card();
            //d.Cards.Add(cardOne);

            //Console.WriteLine(d.Cards[0].Face + " of " + d.Cards[0].Suit);

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, int times = 1)//optional variable times
        {


            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random r = new Random();
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = r.Next(0, deck.Cards.Count);
                    tempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = tempList;
            }
            return deck;
        }
        //public static Deck Shuffle(Deck deck, int nums)
        //{
        //    for(int i = 0; i < nums; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }

        //    return deck;
        //}

    }
}
