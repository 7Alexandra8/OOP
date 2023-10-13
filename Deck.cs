using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_1
{


    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        public List<Card> DealCards(int numCards)
        {
            if (cards.Count < numCards)
            {
                throw new InvalidOperationException("Не достаточно карт");
            }

            List<Card> dealtCards = new List<Card>();
            for (int i = 0; i < numCards; i++)
            {
                Card card = cards[0];
                cards.RemoveAt(0);
                dealtCards.Add(card);
            }
            return dealtCards;
        }
    }

}
