using System;
using System.Collections.Generic;
using System.Linq;

public class PlayerAccount : Account
{
    public string _name;
    public List<Card> _hand;
    public int _bet;
    

    public PlayerAccount(string name, int balance)
        : base(balance)
    {
        _name = name;
        _hand = new List<Card>();
        _bet = 0;
      
    }

    public void TakeOneCard(Card card)
    {
        _hand.Add(card);
    }

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public bool HasValidCombination()
    {
        // Пример: проверка наличия пары карт в руке игрока
        var cardRanks = new HashSet<Rank>();
        foreach (var card in _hand)
        {
            if (cardRanks.Contains(card.Rank))
            {
                return true; // Найдена пара
            }
            cardRanks.Add(card.Rank);
        }
        return false; // Пара не найдена
    }

    public int GetBetAmount(int limit)
    {
        // Пример: выбор ставки, равной половине лимита (округленной вниз до ближайшего целого числа)
        int betAmount = limit / 2;
        return betAmount;
    }

    internal int CompareCombinations(PlayerAccount otherPlayer, List<Card> table)
    {
        var ourBestCombination = GetCombinations(this, table).Max(x => (int)x);
        var otherBestCombination = GetCombinations(otherPlayer, table).Max(x => (int)x);

        return Math.Sign(ourBestCombination - otherBestCombination);
    }

    private List<Combination> GetCombinations(PlayerAccount player, List<Card> table)
    {
        List<Card> union = table.GetRange(0,table.Count);
        union.Add(player._hand[0]);
        union.Add(player._hand[1]);
        return PokerCombinations.GetWinningCombinations(union);
    }
}
