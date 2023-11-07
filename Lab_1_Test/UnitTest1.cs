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

            Assert.AreEqual(52, shuffledDeck.Count); // ”беждаемс€, что колода состоит из 52 карт
        }

        [TestMethod]
        public void TestDealCard()
        {
            Dealer dealer = new Dealer();
            Card card = dealer.DealCard();

            Assert.IsNotNull(card); // ”беждаемс€, что возвращаетс€ не пуста€ карта
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

            Assert.AreEqual(52, shuffledDeck.Count); // ”беждаемс€, что колода состоит из 52 карт
        }
    }

    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardProperties()
        {
            Card card = new Card { Suit = Suit.Hearts, Rank = Rank.Ace };

            Assert.AreEqual(Suit.Hearts, card.Suit); // ѕровер€ем, что масть карты соответствует заданным значени€м
            Assert.AreEqual(Rank.Ace, card.Rank); // ѕровер€ем, что номинал карты соответствует заданным значени€м
        }
    }
}
