using Lab_4_Test;
using System;
using System.Collections.Generic;
using System.Text;

    public abstract class Account
    {
        public int Balance { get; protected set; }

        public Account(int initialBalance)
        {
            Balance = initialBalance;
        }

        public virtual void Deposit(int amount)
        {
            Balance += amount;
        }

        public virtual void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }

