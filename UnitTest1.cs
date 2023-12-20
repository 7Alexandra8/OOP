using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void TestGetShuffledDeck()
        {
            Deck deck = new Deck();
            List<Card> shuffledDeck = deck.GetShuffledDeck();

            Assert.AreEqual(52, shuffledDeck.Count); // Убеждаемся, что колода состоит из 52 карт
        }
    }

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardProperties()
        {
            Card card = new Card { Suit = Suit.Hearts, Rank = Rank.Ace };

            Assert.AreEqual(Suit.Hearts, card.Suit); // Проверяем, что масть карты соответствует заданным значениям
            Assert.AreEqual(Rank.Ace, card.Rank); // Проверяем, что номинал карты соответствует заданным значениям
        }
    }

