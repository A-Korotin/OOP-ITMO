using System.Collections.Immutable;
using OOP_ICT.Domain;
using OOP_ICT.Domain.Interfaces;
using OOP_ICT.Domain.MixingStrategies;

namespace OOP_ICT.Services.Impl;

public class ClassicDeckService : IDeckService
{
    private readonly IMixingStrategy _mixingStrategy;
    
    public const int DeckSize = 52;
    public static readonly IImmutableQueue<Card> DefaultCards = ClassicDeckHelper.InitDefault();

    public ClassicDeckService() : this(new PerfectShuffle())
    {
    }
    
    public ClassicDeckService(IMixingStrategy mixingStrategy)
    {
        _mixingStrategy = mixingStrategy;
    }

    public IDeck CreateDeck()
    {
        return new ClassicDeck(this);
    }

    public void Mix(IDeck deck)
    {
        deck.Mix(_mixingStrategy);
    }

    public IImmutableQueue<Card> GetDefaultCards()
    {
        return DefaultCards;
    }

    public int GetDefaultDeckSize()
    {
        return DeckSize;
    }
}

internal static class ClassicDeckHelper
{
    public static IImmutableQueue<Card> InitDefault()
    {
        var cards = new Card[ClassicDeckService.DeckSize];
        var i = 0;
        // todo linq
        foreach (var rank in Enum.GetValues(typeof(CardRank)).Cast<CardRank>().Reverse())
        {
            foreach (var suit in Enum.GetValues(typeof(CardSuit)).Cast<CardSuit>())
            {
                cards[i++] = new Card(suit, rank);
            }
        }

        return ImmutableQueue.Create(cards);
    }
}