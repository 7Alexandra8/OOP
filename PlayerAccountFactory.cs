using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2_Test
{

    public class PlayerAccountFactory : AccountFactory
    {
        public override Account CreateAccount(int initialBalance)
        {
            return new PlayerAccount(initialBalance);
        }
    }

}
