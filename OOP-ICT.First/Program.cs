// See https://aka.ms/new-console-template for more information

using OOP_ICT.Domain;
using OOP_ICT.Domain.Interfaces;
using OOP_ICT.Services.Impl;


class Program
{
    public static void Main()
    {
        IDealer dealer = new Dealer(new ClassicDeckService());
        
    }
}