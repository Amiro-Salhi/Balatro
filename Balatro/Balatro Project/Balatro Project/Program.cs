using Balatro_Project;

namespace BalatroProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Balatro Project!");
            Console.WriteLine("Balatro game is running...");

            var deck = new Deck();
            var hand = deck.Deal(5);

            Console.WriteLine($"Cards in deck after dealing: {deck.Count}");
            Console.WriteLine("Your hand:");

            foreach (var card in hand)
            {
                Console.WriteLine($"- {card.Rank} of {card.Suit}");
            }

            var sampleCard = new Card(Ranks.King, Suits.Hearts);
            sampleCard.PrintMe();
        }
    }
}
