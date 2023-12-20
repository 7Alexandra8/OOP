using System;
using System.Collections.Generic;
using System.Text;

    public class Deck
    {
        public List<Card> cards;

        public Deck()
        {
            cards = CreateOrderedDeck();
        }
        public Card TakeOneCard()
        {
            if (cards.Count == 0)
            {
                throw new InvalidOperationException("No more cards in the deck");
            }

            ShuffleDeck(cards); // Перетасовка колоды
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        private List<Card> CreateOrderedDeck()
        {
            List<Card> orderedDeck = new List<Card>();

            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    orderedDeck.Add(new Card { Suit = suit, Rank = rank });
                }
            }

            return orderedDeck;
        }

        public List<Card> GetShuffledDeck()
        {
            List<Card> shuffledDeck = new List<Card>(cards);
            ShuffleDeck(shuffledDeck);
            return shuffledDeck;
        }

        private void ShuffleDeck(List<Card> deck)
        {
            Random random = new Random();

            for (int i = deck.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
       
    }

