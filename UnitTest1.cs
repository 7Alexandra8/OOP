using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab_2_Test
{
    [TestClass]
    public class BlackjackCasinoTests
    {
        [TestMethod]
        public void AwardWinToPlayer_ShouldIncreasePlayerAccountBalance()
        {
            // Arrange
            AccountFactory accountFactory = new PlayerAccountFactory();
            BlackjackCasino casino = new BlackjackCasino(accountFactory);
            Account playerAccount = accountFactory.CreateAccount(100);
            int amount = 50;

            // Act
            casino.AwardWinToPlayer(playerAccount, amount);

            // Assert
            Assert.AreEqual(150, playerAccount.Balance);
        }

        [TestMethod]
        public void ChargeLossToPlayer_ShouldDecreasePlayerAccountBalance()
        {
            // Arrange
            AccountFactory accountFactory = new PlayerAccountFactory();
            BlackjackCasino casino = new BlackjackCasino(accountFactory);
            Account playerAccount = accountFactory.CreateAccount(100);
            int amount = 50;

            // Act
            casino.ChargeLossToPlayer(playerAccount, amount);

            // Assert
            Assert.AreEqual(50, playerAccount.Balance);
        }

        [TestMethod]
        public void HandleBlackjack_ShouldIncreasePlayerAccountBalance()
        {
            // Arrange
            AccountFactory accountFactory = new PlayerAccountFactory();
            BlackjackCasino casino = new BlackjackCasino(accountFactory);
            Account playerAccount = accountFactory.CreateAccount(100);
            int betAmount = 50;

            // Act
            casino.HandleBlackjack(playerAccount, betAmount);

            // Assert
            Assert.AreEqual(175, playerAccount.Balance);
        }
    }

    [TestClass]
    public class BankTests
    {
        [TestMethod]
        public void Deposit_ShouldIncreasePlayerAccountBalance()
        {
            // Arrange
            Bank bank = new Bank();
            Account playerAccount = new PlayerAccount(100);
            int amount = 50;

            // Act
            bank.Deposit(playerAccount, amount);

            // Assert
            Assert.AreEqual(150, playerAccount.Balance);
        }

        [TestMethod]
        public void Withdraw_ShouldDecreasePlayerAccountBalance()
        {
            // Arrange
            Bank bank = new Bank();
            Account playerAccount = new PlayerAccount(100);
            int amount = 50;

            // Act
            bank.Withdraw(playerAccount, amount);

            // Assert
            Assert.AreEqual(50, playerAccount.Balance);
        }

        [TestMethod]
        public void HasSufficientFunds_ShouldReturnTrue_WhenPlayerHasEnoughBalance()
        {
            // Arrange
            Bank bank = new Bank();
            Account playerAccount = new PlayerAccount(100);
            int amount = 50;

            // Act
            bool hasSufficientFunds = bank.HasSufficientFunds(playerAccount, amount);

            // Assert
            Assert.IsTrue(hasSufficientFunds);
        }

        [TestMethod]
        public void HasSufficientFunds_ShouldReturnFalse_WhenPlayerDoesNotHaveEnoughBalance()
        {
            // Arrange
            Bank bank = new Bank();
            Account playerAccount = new PlayerAccount(100);
            int amount = 150;

            // Act
            bool hasSufficientFunds = bank.HasSufficientFunds(playerAccount, amount);

            // Assert
            Assert.IsFalse(hasSufficientFunds);
        }
    }
}
