using System.Collections.Immutable;
using System.Text;
using OOP_ICT.Domain.Interfaces;
using OOP_ICT.Exceptions;
using OOP_ICT.Services;

namespace OOP_ICT.Domain;


public class ClassicDeck: IDeck
{
    private Queue<Card> Cards { get; set; }
    
    public ClassicDeck(IDeckService service)
    {
        Cards = new Queue<Card>(service.GetDefaultCards()); // copy
    }
    
    public void Mix(IMixingStrategy strategy)
    {
        var mixed = strategy.PerformMix(Array.AsReadOnly(Cards.ToArray()));
        
        Cards = new Queue<Card>(mixed);
    }

    public Card GetNextCard()
    {
        if (Cards.Count == 0)
        {
            throw new InvalidDeckException("Deck is empty");
        }

        return Cards.Dequeue();
    }

    public int Count()
    {
        return Cards.Count;
    }

    public override string ToString()
    {
        var builder = new StringBuilder("ListDeck(");
        builder.Append("Cards: [ ");
        foreach (var card in Cards)
        {
            builder.Append('{');
            builder.Append(card);
            builder.Append("} ");
        }
        builder.Append("])");
        return builder.ToString();
    }
}


