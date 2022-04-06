using System;

namespace deckOcards
{
    public class Card 
    {
        public string name; 
        public string suit; 
        public int val; 

        public Card(string Name, string suitType, int value)
        {
            this.name = Name;
            this.suit = suitType; 
            this.val = value; 
        }
        public void print()
        {
            Console.WriteLine($"{name}, {suit}, {val}");
        }
    }
}