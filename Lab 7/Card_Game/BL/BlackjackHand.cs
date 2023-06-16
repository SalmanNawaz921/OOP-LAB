using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game.BL
{
    class BlackjackHand : Hand
    {
        public int getBlackjackValue()
        {
            int val;
            bool ace;
            int noOfCards;
            val = 0;
            ace = false;
            noOfCards = getCardCount();
            
            foreach(Card i in cards)
            {
                if (i.getValue() == 1)
                {
                    if((val + 11) > 21)
                    {
                        val += 1;
                    }
                    else
                    {
                        val += 11;
                    }
                }
                else if (i.getValue() >= 11 && i.getValue() <= 13)
                {
                    val += 10;
                }
                else
                {
                    val += i.getValue();
                }
            }

            return val;
        }
    }
}