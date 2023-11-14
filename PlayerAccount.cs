using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_Test
{       
    public class PlayerAccount : Account
    {
        public PlayerAccount(int initialBalance) : base(initialBalance)
        {
        }

        public override void Withdraw(int amount)
        {
            // Проверка на отриц. баланс
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Insufficient funds");
            }

            base.Withdraw(amount);
        }
    }

}
