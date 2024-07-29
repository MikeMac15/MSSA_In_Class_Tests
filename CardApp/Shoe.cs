public class Shoe {
    private static readonly Random Random = new Random();
    public List<Card> AllCards { get; private set; }

    public Shoe (int numOfDecks){
        
        AllCards = new List<Card>();

        for (int i = 0; i < numOfDecks; i++){
            Deck newDeck = new Deck();
            // AllCards.Add(...newDeck);
            AllCards.AddRange(newDeck.Cards);
        }
    }

     public void Shuffle()
    {
        int n = AllCards.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Next(0, i + 1);
            
            Card temp = AllCards[i];
            AllCards[i] = AllCards[j];
            AllCards[j] = temp;
        }
    }

    public Card DealOneCard()
    {
        if (AllCards.Count == 0)
        {
            throw new InvalidOperationException("No cards left");
        };

        Card topCard = AllCards[0];
        AllCards.RemoveAt(0);
        return topCard;
    }

    public List<Card> DealMultipleCards(int numOfCards)
    {
        if (numOfCards > AllCards.Count){
            throw new ArgumentException("Not enough cards");
        };

        List<Card> cards = new List<Card>();
        for (int i = 0; i < numOfCards; i++)
        {
            cards.Add(DealOneCard());
        }
        return cards;
    }


    public void PrintAllCards()
    {
        foreach (Card card in AllCards)
        {
            Console.Write(card.GetValue());
            
        }
    }
}