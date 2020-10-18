using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class ChequingAccount : Account, IAccount
    {
        public ChequingAccount(double val1, double val2) : base(val1, val2) { }

        void IAccount.CalculateInterest() { }

        string IAccount.CloseAndReport()
        {
            double monthly_fee = 5;
            service_charge += monthly_fee;
            for(int i = 0; i < withdrawal_count; i++)
            {
                service_charge += .1;
            }
            return base.CloseAndReport();
        }

        void IAccount.MakeWithdrawl(double amount)
        {
            if (current_balance >= amount)
                base.MakeWithdrawl(amount);
            else
            {
                Account.current_balance -= 15;
                base.MakeWithdrawl(amount);
            }
        }
        void IAccount.MakeDeposit(double amount) { }
    }
}
