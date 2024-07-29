public class Deck {
    public List<Card> Cards { get; private set; }
    public Deck() {
        Cards = new List<Card>();
        InitDeck();
    }

    private void InitDeck()
    {
        foreach (Suit suit in Enum.GetValues(typeof(Suit))){
            for (int i = 2; i <= 14; i++) {
                Cards.Add(new Card(suit,i));
            }
        }
    }
}