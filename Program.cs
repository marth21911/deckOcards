using System;

namespace deckOcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Card games");

            Deck d1 = new Deck();
            d1.ShuffleDeck();
            d1.Deal();
            d1.Deal();
            d1.Deal();
            d1.printDeck();
        }

    }
}
