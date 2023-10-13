using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_1
{
    public class Dealer
    {
        private Deck deck;

        public Dealer()
        {
            deck = new Deck();
        }

        public void ShuffleDeck()
        {
            deck.Shuffle();
        }

        public List<Card> DealCards(int numCards)
        {
            return deck.DealCards(numCards);
        }
    }
}
