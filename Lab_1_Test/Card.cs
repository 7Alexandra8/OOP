using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_1_Test
{
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    public enum Rank
    {
        Ace,
        King,
        Queen,
        Jack,
        Ten,
        Nine,
        Eight,
        Seven,
        Six,
        Five,
        Four,
        Three,
        Two
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }
}
