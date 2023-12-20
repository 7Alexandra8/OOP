using System;
using System.Collections.Generic;
using System.Text;
     // Интерфейс взаимодействия с банком
        public interface IBankInteraction
        {
            void Deposit(Account playerAccount, int amount);
            void Withdraw(Account playerAccount, int amount);
            bool HasSufficientFunds(Account playerAccount, int amount);
        }

   
