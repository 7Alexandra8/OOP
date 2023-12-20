using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
enum Combination
{
    Pair,
    TwoPair,
    Triple,
    Straight,
    Flush,
    FullHouse,
    Kare,
    StraightFlush,
    RoyalFlush

}
class PokerCombinations
{
    public static List<Combination> GetWinningCombinations(List<Card> cards)
    {   
        
        List<Combination> winningCombinations = new List<Combination>();

        if (HasRoyalFlush(cards))
        {
            winningCombinations.Add(Combination.RoyalFlush);
        }

        if (HasStraightFlush(cards))
        {
            winningCombinations.Add(Combination.StraightFlush);
        }

        if (HasFourOfAKind(cards))
        {
            winningCombinations.Add(Combination.Kare);
        }

        if (HasFullHouse(cards))
        {
            winningCombinations.Add(Combination.FullHouse);
        }

        if (HasFlush(cards))
        {
            winningCombinations.Add(Combination.Flush);
        }

        if (HasStraight(cards))
        {
            winningCombinations.Add(Combination.Straight);
        }

        if (HasThreeOfAKind(cards))
        {
            winningCombinations.Add(Combination.Triple);
        }

        if (HasTwoPair(cards))
        {
            winningCombinations.Add(Combination.TwoPair);
        }

        if (HasOnePair(cards))
        {
            winningCombinations.Add(Combination.Pair);
        }

        return winningCombinations;
    }

    private static bool HasRoyalFlush(List<Card> cards)
    {
        return HasFlush(cards) && HasStraight(cards) && cards.Max(card => card.Rank) == Rank.Ace;
    }

    private static bool HasStraightFlush(List<Card> cards)
    {
        return HasFlush(cards) && HasStraight(cards);
    }

    private static bool HasFourOfAKind(List<Card> cards)
    {
        return cards.GroupBy(card => card.Rank).Any(group => group.Count() == 4);
    }

    private static bool HasFullHouse(List<Card> cards)
    {
        return HasThreeOfAKind(cards) && HasOnePair(cards);
    }

    private static bool HasFlush(List<Card> cards)
    {
        return cards.GroupBy(card => card.Suit).Any(group => group.Count() >= 5);
    }

    private static bool HasStraight(List<Card> cards)
    {
        List<int> ranks = cards.Select(card => ConvertRankToInt(card.Rank)).OrderBy(rank => rank).ToList();

        if (ranks.Count < 5)
        {
            return false;
        }

        int previousRank = ranks[0];
        int consecutiveCount = 1;

        for (int i = 1; i < ranks.Count; i++)
        {
            if (ranks[i] == previousRank + 1)
            {
                consecutiveCount++;

                if (consecutiveCount >= 5)
                {
                    return true;
                }
            }
            else if (ranks[i] != previousRank)
            {
                consecutiveCount = 1;
            }

            previousRank = ranks[i];
        }

        // Check for "Ace to Five" straight
        if (ranks.Contains(14) && ranks.Contains(2) && ranks.Contains(3) && ranks.Contains(4) && ranks.Contains(5))
        {
            return true;
        }

        return false;
    }

    private static bool HasThreeOfAKind(List<Card> cards)
    {
        return cards.GroupBy(card => card.Rank).Any(group => group.Count() == 3);
    }

    private static bool HasTwoPair(List<Card> cards)
    {
        return cards.GroupBy(card => card.Rank).Count(group => group.Count() == 2) == 2;
    }

    private static bool HasOnePair(List<Card> cards)
    {
        return cards.GroupBy(card => card.Rank).Any(group => group.Count() == 2);
    }

    private static int ConvertRankToInt(Rank rank)
    {
        int order = (int)rank;
        int ranksCount = Enum.GetValues(typeof(Rank)).Length;
        return ranksCount - order;
    }
}

