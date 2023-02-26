namespace OOP_ICT.Domain.Interfaces;

public interface IDeck
{
    void Mix(IMixingStrategy strategy);

    Card GetNextCard();

    int Count();

}

