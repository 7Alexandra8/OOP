using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Lab_1_Test
{

    [TestClass]
    public class DealerTests
    {
        [TestMethod]
        public void TestGetShuffledDeck()
        {
            Dealer dealer = new Dealer();
            List<Card> shuffledDeck = dealer.GetShuffledDeck();

            Assert.AreEqual(52, shuffledDeck.Count); // ����������, ��� ������ ������� �� 52 ����
        }

        [TestMethod]
        public void TestDealCard()
        {
            Dealer dealer = new Dealer();
            Card card = dealer.DealCard();

            Assert.IsNotNull(card); // ����������, ��� ������������ �� ������ �����
        }
    }

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
}
