using System;

namespace Balatro_Project
{
    public class Card
    {
        public Ranks Rank { get; }
        public Suits Suit { get; }

        public Card(Ranks rank, Suits suit)
        {
            Rank = rank;
            Suit = suit;
        }

        public void PrintMe()     
        {
            Console.WriteLine($"{Rank} of {Suit}");
        }
    }
}
