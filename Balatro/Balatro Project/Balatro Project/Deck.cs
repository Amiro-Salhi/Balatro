namespace Balatro_Project;

public class Deck
{
    private readonly List<Card> _cards;

    public Deck()
    {
        _cards = GenerateDeck();
        Shuffle();
    }

    public int Count => _cards.Count;

    public void Shuffle()
    {
        var random = new Random();
        _cards.Sort((a, b) => random.Next(-1, 2));
    }

    public Card? DrawCard()
    {
        if (_cards.Count == 0)
        {
            return null;
        }

        var card = _cards[0];
        _cards.RemoveAt(0);
        return card;
    }

    public List<Card> Deal(int count)
    {
        var hand = new List<Card>();

        for (int i = 0; i < count; i++)
        {
            var card = DrawCard();
            if (card is null)
            {
                break;
            }

            hand.Add(card);
        }

        return hand;
    }

    private static List<Card> GenerateDeck()
    {
        var deck = new List<Card>();

        foreach (var suit in Enum.GetValues<Suits>())
        {
            foreach (var rank in Enum.GetValues<Ranks>())
            {
                deck.Add(new Card(rank, suit));
            }
        }

        return deck;
    }
}
