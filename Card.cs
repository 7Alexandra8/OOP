using System;
using System.Collections.Generic;
using System.Text;

public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }
    }

    // Перечисление мастей карт
    public enum Suit
    {
        Hearts,
        Diamonds,
        Clubs,
        Spades
    }

    // Перечисление достоинств карт
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

