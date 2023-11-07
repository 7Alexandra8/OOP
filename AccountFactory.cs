using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_Test
{
    public abstract class AccountFactory
    {
        public abstract Account CreateAccount(int initialBalance);
    }
}
