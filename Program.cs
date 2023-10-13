
    using System;
    using System.Collections.Generic;

    namespace CardGame_1
    {

    class Program
    {
        static void Main(string[] args)
        {
            Dealer dealer = new Dealer();
            dealer.ShuffleDeck();

            // Раздаётся по 6 карт игрокам
            int numPlayers = 4;
            for (int i = 0; i < numPlayers; i++)
            {
                List<Card> cards = dealer.DealCards(6);
                Console.WriteLine($"Игроку номер {i + 1} раздали:");
                foreach (Card card in cards)
                {
                    Console.WriteLine($"{card.Rank} {card.Suit}");
                }
                Console.WriteLine();
            }
        }
    }
}

