namespace OOP_ICT.Domain.Interfaces;

public interface IMixingStrategy
{
    IEnumerable<Card> PerformMix(IReadOnlyList<Card> cards);
}