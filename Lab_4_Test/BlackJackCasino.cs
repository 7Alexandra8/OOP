
    public class BlackjackCasino
    {
      
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


