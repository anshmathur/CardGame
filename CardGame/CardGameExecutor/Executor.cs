using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGameExecutor
{
    public interface IGameExecutor
    {
        void StartGame();
    }
    public class GameExecutor : IGameExecutor
    {
        public void StartGame()
        {
            var playingDeck = new PlayDeck();
            playingDeck.generateDeck();
            var playedDeck = new List<Card>();
            while (true)
            {
                bool exitGame = false;
                Console.WriteLine("Select an Option below : " +
                    "\n1. Play a Card" +
                    "\n2. Shuffle your deck" +
                    "\n3. Reset Deck" +
                    "\n4. Exit Game");
                var input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        var card = playingDeck.drawCard();
                        playedDeck.Add(card);
                        Console.WriteLine($"Played Card - {card.suit} {card.face}\n");
                        break;
                    case 2:
                        playingDeck.shuffleDeck();
                        Console.WriteLine("Deck Shuffled\n");
                        break;
                    case 3:
                        playingDeck = new PlayDeck();
                        playingDeck.generateDeck();
                        Console.WriteLine("Deck reset\n");
                        continue;
                    case 4:
                        exitGame = true;
                        break;
                    default:
                        continue;
                }

                if (exitGame)
                {
                    Console.WriteLine("Thank you for playing");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
