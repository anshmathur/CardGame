using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameExecutor
{
    public abstract class Deck
    {
        public List<Card> stack;

        public Deck()
        {
            this.stack = new List<Card>();
        }

        public abstract void generateDeck();
        public abstract void shuffleDeck();
        public abstract Card drawCard();
        public abstract bool isEmpty();
    }
}
