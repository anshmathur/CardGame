using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameExecutor
{
    public class Card
    {
        public enum Suit { Clubs, Hearts, Spades, Diamond };
        public enum Face { Ace = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King };
        public Suit suit { get; set; }
        public Face face { get; set; }
        public Card(Suit s, Face f)
        {
            this.suit = s;
            this.face = f;
        }        
    }
}
