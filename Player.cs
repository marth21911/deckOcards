using System;
using System.Collections.Generic;

namespace deckOcards
{

    public class Player
    {
        public string Name;
        public List<Card> hand;
        public Player (string Name)
        {
            this.Name = Name;
            //I want an empty list by default for hand
            //i want max hand size to be 5
            //i want cards to be drawn from selected deck and added to empty hand list

            this.hand = [];
        }
    }   
}