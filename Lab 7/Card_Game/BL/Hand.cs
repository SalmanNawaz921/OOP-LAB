using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game.BL
{
    class Hand
    {
        protected List<Card> cards;
        public Hand()
        {
            cards = new List<Card>();
        }
        public void clear()
        {
            foreach (Card i in cards)
            {
                cards.Remove(i);
            }
        }
        public void addCard(Card c)
        {
            cards.Add(c);
        }
        public void removeCard(Card c)
        {
            cards.Remove(c);
        }
        public void removeCard(int position)
        {
            cards.Remove(cards[position]);
        }
        public int getCardCount()
        {
            return cards.Count();
        }
        public Card getCard(int position)
        {
            return cards[position];
        }
        public void sortBySuit()
        {
            List<Card> tempCards = new List<Card>();
            for (int i = 1; i <= 4; i++)
            {
                foreach (Card j in cards)
                {
                    if (j.getSuit() == i)
                    {
                        if (tempCards.Count > 0 && tempCards[tempCards.Count - 1].getSuit() == j.getSuit())
                        {
                            if (j.getValue() >= tempCards[tempCards.Count - 1].getValue())
                            {
                                tempCards.Add(j);
                            }
                            else
                            {
                                tempCards.Insert(tempCards.Count - 1, j);
                            }
                        }
                        else
                        {
                            tempCards.Add(j);
                        }
                    }
                }
            }
            cards = tempCards;
        }

        public void sortByValue()
        {
            List<Card> tempCards = new List<Card>();
            for (int i = 1; i <= 13; i++)
            {
                foreach (Card j in cards)
                {
                    if (j.getValue() == i)
                    {
                        if (tempCards.Count > 0 && tempCards[tempCards.Count - 1].getValue() == j.getValue())
                        {
                            if (j.getSuit() >= tempCards[tempCards.Count - 1].getSuit())
                            {
                                tempCards.Add(j);
                            }
                            else
                            {
                                tempCards.Insert(tempCards.Count - 1, j);
                            }
                        }
                        else
                        {
                            tempCards.Add(j);
                        }
                    }
                }
            }
            cards = tempCards;
        }
    }
}
