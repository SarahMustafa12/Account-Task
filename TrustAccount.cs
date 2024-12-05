using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Task_4
{
    public class TrustAccount : SavingsAccount
    {
        public DateTime StartDate { get; set; } = DateTime.Now;
        public int Counter { get; set; }



        public TrustAccount(string Name = "Unnamed Account", double Balance = 0, double rate = 0) : base(Name, Balance, rate) { }

        public override bool Deposit(double amount)
        {
            double bonus = 50.00;
            if (amount >= 5000.00)
            {
                Balance += amount + bonus;
                Console.WriteLine($"your Balance now is {Balance} and there is {bonus} Added.");
                return true;
            }
            else
                return base.Deposit(amount);

        }
        public override bool Withdraw(double amount)
        {
            double total = Balance * 0.2;
            StartDate = DateTime.Now;
            DateTime endDate = StartDate.AddYears(1);  //https://www.influxdata.com/blog/c-sharp-date-classes/
            TimeSpan diffDayes = endDate - StartDate;   // https://stackoverflow.com/questions/1607336/how-to-calculate-difference-between-two-dates-number-of-days
            double diff = diffDayes.TotalDays;  
            if (diff <= 365 && Counter < 3 && amount < total)
            {
                Counter++;
                return base.Withdraw(amount);
            }
            else
                return false;


        }
        public override string ToString()
        {
            return $"{base.ToString()}\t Date = {StartDate}\t Count: {Counter}";
        }


    }

}
