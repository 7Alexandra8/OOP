using System;
using System.Collections.Generic;
using System.Text;

    public class Dealer
    {
        private Deck deck;
        private List<Card> tableCards;
        private List<Card> shuffledDeck;

        public List<Card> TableCards { get { return tableCards; } }

        public Dealer()
        {
            deck = new Deck();
            shuffledDeck = deck.GetShuffledDeck();
            tableCards = new List<Card>(5);
            for (int i = 0; i < 5; i++)
            {
                tableCards.Add(shuffledDeck[i]);
                shuffledDeck.RemoveAt(i);
            }

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

        public void DealCards(List<PlayerAccount> players)
        {
            List<Card> shuffledDeck = GetShuffledDeck();

            foreach (PlayerAccount player in players)
            {
                Card card = shuffledDeck[shuffledDeck.Count - 1];
                shuffledDeck.RemoveAt(shuffledDeck.Count - 1);
                player.TakeOneCard(card);
            }
        }

           }

