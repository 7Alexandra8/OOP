using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_Test
{
    public interface ICardDealer
    {
        List<Card> GetShuffledDeck();
        Card DealCard();
    }
}
