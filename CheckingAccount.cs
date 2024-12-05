using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class CheckingAccount : Account
    {

        public double Fee = 1.5; // per withdrawer process

        public CheckingAccount(string Name = "Unnamed Account", double Balance = 0) : base(Name, Balance)
        {

        }

        public override bool Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= Fee;
            return true;
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
