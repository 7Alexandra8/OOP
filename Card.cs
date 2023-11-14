using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_Test
{
    // Класс для представления игровой карты
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Rank
    {
        Ace = 11,
        King = 10,
        Queen = 10,
        Jack = 10,
        Ten = 10,
        Nine = 9,
        Eight = 8,
        Seven = 7,
        Six = 6,
        Five = 5,
        Four = 4,
        Three = 3,
        Two = 2
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }
}
