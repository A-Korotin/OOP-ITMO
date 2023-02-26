using OOP_ICT.Domain;
using OOP_ICT.Domain.Interfaces;
using OOP_ICT.Exceptions;
using OOP_ICT.Services;
using OOP_ICT.Services.Impl;
using Xunit;

namespace OOP_ICT.Dealer.Tests;

public class Tests
{
    private static IDeckService _deckService = new ClassicDeckService();
    private static IDealer _dealer = new Domain.Dealer(_deckService);
    
    [Fact]
    public void CheckCardAmount()
    {
        _dealer.RecreateDeck();
        var deck = _dealer.GetMixedDeck();
        Assert.Equal(_deckService.GetDefaultDeckSize(), deck.Count());
    }

    [Fact]
    public void CheckCardTossing_AssertEmptyDeck_ThenRecreateDeck()
    {
        _dealer.RecreateDeck();
        
        for (var i = 0;  i < _deckService.GetDefaultDeckSize(); ++i)
        {
            _dealer.TossNextCard();
        }

        Assert.Throws<InvalidDeckException>(() => _dealer.TossNextCard()); // deck is empty
        
        _dealer.RecreateDeck();
        
        Assert.Equal(_deckService.GetDefaultDeckSize(), _dealer.GetMixedDeck().Count());
    }
    
    [Fact]
    public void CheckIfDeckIsMixed()
    {
        _dealer.RecreateDeck();
        var deck = _dealer.GetMixedDeck();
        var cards = new Card[_deckService.GetDefaultDeckSize()];
        for (var i = 0; i < _deckService.GetDefaultDeckSize(); ++i)
        {
            cards[i] = deck.GetNextCard();
        }
        
        Assert.NotEqual(_deckService.GetDefaultCards().ToArray(), cards);
    }
    
}