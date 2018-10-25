﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented_Programming
{
    public class Player
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set {_hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }
        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet of that size");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }


        public Player(string name, int beginningBalance)
            
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        //Overloaded Methods:

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }


    }
}
