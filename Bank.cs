
    public class Bank
    {
        public void Deposit(Account playerAccount, int amount)
        {
            playerAccount.Deposit(amount);
        }

        public void Withdraw(Account playerAccount, int amount)
        {
            playerAccount.Withdraw(amount);
        }

        public bool HasSufficientFunds(Account playerAccount, int amount)
        {
            return playerAccount.Balance >= amount;
        }
    }
