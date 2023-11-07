using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_Test
{
    public class BlackjackCasino
    {
        private readonly AccountFactory _accountFactory;

        public BlackjackCasino(AccountFactory accountFactory)
        {
            _accountFactory = accountFactory;
        }

        public void AwardWinToPlayer(Account playerAccount, int amount)
        {
            playerAccount.Deposit(amount);
        }

        public void ChargeLossToPlayer(Account playerAccount, int amount)
        {
            playerAccount.Withdraw(amount);
        }

        public void HandleBlackjack(Account playerAccount, int betAmount)
        {
            int blackjackPayment = betAmount * 3 / 2;
            playerAccount.Deposit(blackjackPayment);
        }
    }

}
