namespace OOP_ICT.Domain.Interfaces;

public interface IDealer
{
    Card TossNextCard();
    IDeck GetMixedDeck();

    void RecreateDeck();
}