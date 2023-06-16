using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Card_Game.BL;
using Card_Game.UI;

namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            bool gameRunning = true;
            Deck deck = new Deck();
            deck.shuffle();
            BlackjackHand playerHand = new BlackjackHand();
            BlackjackHand dealerHand = new BlackjackHand();
            for (int i = 0; i < 2; i++)
            {
                playerHand.addCard(Deck.dealCard());
                dealerHand.addCard(Deck.dealCard());
            }
            if (checkLosingCondition(playerHand))
            {
                Console.WriteLine("Dealer Won");
                gameRunning = false;
            }
            else if (checkWinningCondition(playerHand))
            {
                Console.WriteLine("Player Won");
                gameRunning = false;
            }
            while (gameRunning)
            {
                GameUI.playerTurn(playerHand, dealerHand);
                choice = Console.ReadLine();
                if (choice == "Hit")
                {
                    playerHand.addCard(Deck.dealCard());
                }
                if (checkLosingCondition(playerHand))
                {
                    GameUI.playerWon("Dealer");
                    gameRunning = false;
                    break;
                }
                else if (checkWinningCondition(playerHand))
                {
                    GameUI.playerWon("Player");
                    gameRunning = false;
                    break;
                }
                GameUI.dealerTurn(dealerHand);
                if (checkLosingCondition(dealerHand))
                {
                    GameUI.playerWon("Player");
                    gameRunning = false;
                    break;
                }
                else if (checkWinningCondition(dealerHand))
                {
                    GameUI.playerWon("Dealer");
                    gameRunning = false;
                    break;
                }
            }
            Console.ReadKey();
        }
        public static bool checkLosingCondition(BlackjackHand h)
        {
            bool condition = false;
            if (h.getBlackjackValue() > 21)
            {
                condition = true;
            }
            return condition;
        }
        public static bool checkWinningCondition(BlackjackHand h)
        {
            bool condition = false;
            if (h.getBlackjackValue() == 21)
            {
                condition = true;
            }
            return condition;
        }
    }
}
