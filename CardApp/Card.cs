public class Card
{
    public Suit Suit { get; }
    public int Rank { get; }

    private static readonly Dictionary<int, string> rankValue = new Dictionary<int, string>
    {
        { 2, "2" },
        { 3, "3" },
        { 4, "4" },
        { 5, "5" },
        { 6, "6" },
        { 7, "7" },
        { 8, "8" },
        { 9, "9" },
        { 10, "10" },
        { 11, "J" },
        { 12, "Q" },
        { 13, "K" },
        { 14, "A" }
    };

    public Card(Suit suit, int rank)
    {
        Suit = suit;
        Rank = rank;
    }

    private static readonly Dictionary<Suit, string> SuitEmojis = new Dictionary<Suit, string>
    {
        { Suit.Heart, "❤️" },
        { Suit.Diamond, "◆" },
        { Suit.Club, "♣️" },
        { Suit.Spade, "♠️" }
    };

    public string GetValue()
    {
        var rankStr = rankValue.TryGetValue(Rank, out var value) ? value : Rank.ToString();
        var suitEmoji = SuitEmojis[Suit];
        return $"{rankStr}{suitEmoji}";
    }
}

public enum Suit
{
    Heart,
    Diamond,
    Club,
    Spade
}