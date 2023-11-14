using Lab_3_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class BankTests
{
    [TestMethod]
    public void Deposit_ShouldIncreasePlayerAccountBalance()
    {
        // Arrange
        var bank = new Bank();
        var playerAccount = new PlayerAccount(100);
        var amount = 50;
        // Act
        bank.Deposit(playerAccount, amount);
        // Assert
        Assert.AreEqual(150, playerAccount.Balance);
    }

    [TestMethod]
    public void Withdraw_ShouldDecreasePlayerAccountBalance()
    {
        // Arrange
        var bank = new Bank();
        var playerAccount = new PlayerAccount(100);
        var amount = 50;
        // Act
        bank.Withdraw(playerAccount, amount);
        // Assert
        Assert.AreEqual(50, playerAccount.Balance);
    }

    [TestMethod]
    public void HasSufficientFunds_ShouldReturnTrue_WhenPlayerHasEnoughBalance()
    {
        // Arrange
        var bank = new Bank();
        var playerAccount = new PlayerAccount(100);
        var amount = 50;
        // Act
        var hasSufficientFunds = bank.HasSufficientFunds(playerAccount, amount);
        // Assert
        Assert.IsTrue(hasSufficientFunds);
    }

    [TestMethod]
    public void HasSufficientFunds_ShouldReturnFalse_WhenPlayerDoesNotHaveEnoughBalance()
    {
        // Arrange
        var bank = new Bank();
        var playerAccount = new PlayerAccount(100);
        var amount = 150;
        // Act
        var hasSufficientFunds = bank.HasSufficientFunds(playerAccount, amount);
        // Assert
        Assert.IsFalse(hasSufficientFunds);
    }
}
