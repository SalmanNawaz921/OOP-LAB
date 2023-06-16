using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card_Game.BL;

namespace Card_Game.UI
{
    class GameUI
    {
        public static void playerWon(string name)
        {
            Console.WriteLine("\n" + name + " Won");
        }
        public static void playerTurn(BlackjackHand p, BlackjackHand d)
        {
            Console.Clear();
            Console.WriteLine("Player's Turn:\n");
            Console.WriteLine("Your cards are:");
            for (int i = 0; i < p.getCardCount(); i++)
            {
                Console.WriteLine(p.getCard(i).toString());
            }
            Console.WriteLine("\nDealer's first card is: " + d.getCard(0).toString() + "\n");
            Console.WriteLine("Would you like to Hit or Stand?");
        }
        public static void dealerTurn(BlackjackHand dealerHand)
        {
            Console.Clear();
            Console.WriteLine("Dealer's Turn:");
            if (dealerHand.getBlackjackValue() < 17)
            {
                dealerHand.addCard(Deck.dealCard());
                Console.WriteLine("Dealer Hit");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Dealer Stayed");
                Console.ReadKey();
            }
        }
    }
}
