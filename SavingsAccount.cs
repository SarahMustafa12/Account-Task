using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public class SavingsAccount : Account
    {
        public double Rate { get; set; }
        public SavingsAccount(string Name = "Unnamed Account", double Balance = 0, double rate = 0) : base(Name, Balance)
        {

            Rate = rate;
        }
        public override bool Deposit(double amount)
        {
            return base.Deposit(amount - Rate);
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount - Rate);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\t Rate: {Rate}";
        }



    }
}
