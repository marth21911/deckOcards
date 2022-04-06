using System;
using System.Collections.Generic;

namespace deckOcards
{
    public class Deck 
    {
        public List<Card> cards;
        public Deck()
            {
                this.cards = new List<Card>();
                string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};
                string[] names = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
                int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                for (int i = 0; i < suits.Length; i++) 
                {
                    for (int j = 0; j < names.Length; j++) 
                    {
                        cards.Add(new Card(suits[i], names[j], values[j]));
                    }
                }
            }
        
        public void printDeck()
        {
            foreach (Card card in cards)
            {
                card.print();
            }
        }

        public void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++)
            {
                Card temp = cards[i];
                int randvalue = rand.Next(0, cards.Count);
                cards[i] = cards[randvalue];
                cards[randvalue] = temp;
            }
        }

        public void Deal()
        {
            this.cards.RemoveAt(0);
        }
    }
}



