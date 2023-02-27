using OOP_ICT.Domain.Interfaces;
using OOP_ICT.Services;

namespace OOP_ICT.Domain;

public class Dealer: IDealer
{
    private IDeck _deck;
    private readonly IDeckService _deckService;
    
    public Dealer(IDeckService deckService)
    {
        _deckService = deckService;
        _deck = _deckService.CreateDeck();
    }
    
    public Card TossNextCard()
    {
        return _deck.GetNextCard();
    }

    public IDeck GetMixedDeck()
    {
        _deckService.Mix(_deck);
        return _deck;
    }

    public void RecreateDeck()
    {
        _deck = _deckService.CreateDeck();
    }
}