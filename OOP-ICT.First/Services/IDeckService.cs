using System.Collections.Immutable;
using OOP_ICT.Domain;
using OOP_ICT.Domain.Interfaces;

namespace OOP_ICT.Services;

public interface IDeckService
{
    IDeck CreateDeck();
    void Mix(IDeck deck);

    IImmutableQueue<Card> GetDefaultCards();

    int GetDefaultDeckSize();
}