using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class SavingsAccount : Account, IAccount
    {
        public SavingsAccount(double val1, double val2) : base(val1, val2) { }

        void IAccount.CalculateInterest() { }

        string IAccount.CloseAndReport()
        {
            if (Account.withdrawal_count>4)
            {
                service_charge += Account.withdrawal_count - 4;
            }
            return base.CloseAndReport(); 
        }

        void IAccount.MakeWithdrawl(double amount)
        {
            if (Account.AccountStatus == AccountStatus.Active)
            {
                base.MakeWithdrawl(amount);
            }
            else
                Account.Unsuccessful();
        }

        void IAccount.MakeDeposit(double amount)
        {
            if (Account.AccountStatus == AccountStatus.Active)
            {
                base.MakeDeposit(amount);
            }
            else if ((Account.current_balance + amount) > 25)
            {
                Account.AccountStatus = AccountStatus.Active;
                base.MakeDeposit(amount);
            }
            else
            {
                Account.AccountStatus = AccountStatus.Disabled;
                Account.Unsuccessful();
            }
        }
    }
}
