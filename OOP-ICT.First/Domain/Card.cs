namespace OOP_ICT.Domain;

public class Card
{
    public readonly CardSuit Suit;
    public readonly CardRank Rank;

    public Card(CardSuit suit, CardRank rank)
    {
        Suit = suit;
        Rank = rank;
    }
    
    public override string ToString()
    {
        return $"{Rank} of {Suit}";
    }
}

public enum CardSuit
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum CardRank
{
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King,
    Ace
    
}
