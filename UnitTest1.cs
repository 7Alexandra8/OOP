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

            Assert.AreEqual(52, shuffledDeck.Count); // ����������, ��� ������ ������� �� 52 ����
        }
    }

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardProperties()
        {
            Card card = new Card { Suit = Suit.Hearts, Rank = Rank.Ace };

            Assert.AreEqual(Suit.Hearts, card.Suit); // ���������, ��� ����� ����� ������������� �������� ���������
            Assert.AreEqual(Rank.Ace, card.Rank); // ���������, ��� ������� ����� ������������� �������� ���������
        }
    }

