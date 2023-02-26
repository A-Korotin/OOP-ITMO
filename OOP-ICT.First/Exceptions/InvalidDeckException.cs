namespace OOP_ICT.Exceptions;

public class InvalidDeckException : Exception
{
    public InvalidDeckException()
    {
    }
    public InvalidDeckException(string msg) 
        : base(msg)
    {
    }
    public InvalidDeckException(string msg, Exception inner)
        : base(msg, inner)
    {
    }
}