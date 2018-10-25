using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Object_Oriented_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt", text);

            //string text2 = File.ReadAllText(@"C:\Users\TechAcademyStudent\Desktop\Text\log.txt");
            //Console.WriteLine(text2);
            //Console.ReadLine();



            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling us your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring to spend?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new _21Game();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.playGame();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();

















            
            //Deck deck = new Deck();
            //int counter = 0;
            //foreach(Card card in deck.Cards){
            //    if (card.face == Card.Face.Ace)
            //    {
            //        counter++;
            //    }
            //    Console.WriteLine(counter);
            //}


            ////Lambda function 
            //int c = deck.Cards.Count(x => x.face == Card.Face.Ace);


            //List<Card> newList = deck.Cards.Where(x => x.face == Card.Face.Eight).ToList();
            



            //Card card1 = new Card();
            //Card card2 = card1;
            //card1.face = Card.Face.Four;
            //card2.face = Card.Face.Jack;

            //Console.WriteLine(card1.face);
            //Console.ReadLine();




            //Deck deck = new Deck();
            //deck.Shuffle(3);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.face + " of " + card.suit);
            //}

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();

            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();






            //Game g = new _21Game();
            //g.Players = new List<Player>();
            //Player pb = new Player();
            //pb.Name = "Friedrich";

            //g.ListPlayers();
            //g = g + pb;
            //g.ListPlayers();
            //g = g - pb;

            //g.ListPlayers();


            //Deck d = new Deck();
            ////d = Shuffle(d);
            //d = Shuffle(d, 4);
            //d.printDeck();
            //Console.WriteLine("-----------------------------------------------");
            //Shuffle(d);
            //d.printDeck();



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
