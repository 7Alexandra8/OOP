using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_Test
{// Класс, реализующий раздачу карт
    public class Dealer : ICardDealer
    {
        private Deck deck;

        public Dealer()
        {
            deck = new Deck();
        }

        public List<Card> GetShuffledDeck()
        {
            return deck.GetShuffledDeck();
        }

        public Card DealCard()
        {
            List<Card> shuffledDeck = GetShuffledDeck();
            Card card = shuffledDeck[shuffledDeck.Count - 1];
            shuffledDeck.RemoveAt(shuffledDeck.Count - 1);
            return card;
        }
    }

}
