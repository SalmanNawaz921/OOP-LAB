using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Card_Game.BL
{
    public class Card
    {
        private int value;
        private int suit;
        public Card(int value, int suit)
        {
            this.value = value;
            this.suit = suit;
        }
        public int getValue()
        {
            return this.value;
        }
        public int getSuit()
        {
            return this.suit;
        }
        public string toString()
        {
            string theValue = "";
            if (this.value == 1)
            {
                theValue = "Ace";
            }
            else if (this.value == 11)
            {
                theValue = "Jack";
            }
            else if (this.value == 12)
            {
                theValue = "Queen";
            }
            else if (this.value == 13)
            {
                theValue = "King";
            }
            return theValue;

        }
        public string getSuitAsString()
        {
            string theSuit = "";
            if (this.suit == 1)
            {
                theSuit = "Clubs";
            }
            else if (this.suit == 2)
            {
                theSuit = "Diamonds";
            }
            else if (this.suit == 3)
            {
                theSuit = "Spades";
            }
            else if (this.suit == 4)
            {
                theSuit = "Hearts";
            }
            string suit = Convert.ToString(this.suit);
            suit = theSuit;
            return suit;
        }
        public string getBothValues()
        {
            return (getValue() + " " + getSuit());
        }
    }
}