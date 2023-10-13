using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame_1
{
    public enum Suit
    {
        Hearts,//Сердца
        Clubs,//Крести
        Diamonds,//Буби
        Spades// Пики
    }

    public enum Rank
    {
        Ace,// Туз
        King,// Король
        Queen,//Королева
        Jack,// Валет
        Ten,// Десятка
        Nine,//Девятка
        Eight,//Восьмёрка
        Seven,// Семёрка
        Six,//Шестёрка
        Five,//Пятёрка
        Four,//Четвёрка
        Three,//Тройка
        Two//Двойка
    }

    public class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }
    }
}
