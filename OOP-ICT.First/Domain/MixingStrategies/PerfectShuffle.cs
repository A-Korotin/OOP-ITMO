using OOP_ICT.Domain.Interfaces;

namespace OOP_ICT.Domain.MixingStrategies;

public class PerfectShuffle : IMixingStrategy
{
    private readonly Random _random = new(DateTime.Now.Millisecond);

    private static Card[] Algorithm(IReadOnlyList<Card> cards)
    {
        var len = cards.Count;
        var half = len / 2;

        var output = new Card[len];
        
        for (var i = 0; i < half ; i++)
        {
            output[2 * i] = cards[i + half];
            output[2 * i + 1] = cards[i];
        }

        return output;
    }
    
    public IEnumerable<Card> PerformMix(IReadOnlyList<Card> cards)
    {
        var amountOfMixes = _random.Next(1, 6);
        
        for (var i = 0; i < amountOfMixes; ++i)
        {
            cards = Algorithm(cards);
        }

        return cards;
    }
}