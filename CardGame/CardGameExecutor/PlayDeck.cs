using System;
using System.Collections.Generic;
using System.Text;

namespace CardGameExecutor
{
    public class PlayDeck : Deck
    {
        public override Card drawCard()
        {
            Card popCard = stack[0];
            stack.Remove(popCard);
            return popCard;
        }

        public override void generateDeck()
        {
            for (int k = 0; k < 4; k++)
            {
                for (int i = 1; i < 14; i++)
                {
                    stack.Add(new Card((Card.Suit)k, (Card.Face)i));
                }
            }
        }

        public override bool isEmpty()
        {
            return stack.Count == 0;
        }

        public override void shuffleDeck()
        {
            Random rng = new Random();

            for (int i = stack.Count - 1; i > 1; i--)
            {
                int k = rng.Next(i);

                Card v = stack[k];
                stack[k] = stack[i];
                stack[i] = v;

            }
        }
    }
}
