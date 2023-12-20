using System;
using System.Collections.Generic;
using System.Text;

 // Класс банка для игры в покер
    public class PokerBank : Bank
    {
    public int GetTotalBetAmount(List<PlayerAccount> players)
    {
        int amount = 0;
        foreach (PlayerAccount player in players)
        {
            amount += player.GetBetAmount(1000);
        }
        return amount;
    }


    // Метод для начисления выигрыша победителю
    public void AwardWinner(Account playerAccount, int amount)
            {
                playerAccount.Deposit(amount);
            }
           
            // Метод для списания ставок от игроков
            public void DeductBet(Account playerAccount, int amount)
            {
                playerAccount.Withdraw(amount);
            }

    internal void AwardWinner(Action<int> deposit, int v)
    {
        throw new NotImplementedException();
    }

    // Метод для проверки наличия достаточной суммы на счету игрока для ставки
    public bool HasSufficientFundsForBet(Account playerAccount, int amount)
            {
                return playerAccount.Balance >= amount;
            }
        }
    

    
