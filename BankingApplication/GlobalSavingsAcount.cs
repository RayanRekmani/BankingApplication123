using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class GlobalSavingsAcount : SavingsAccount, IExchangeable
    {
        public GlobalSavingsAcount(double val1, double val2) : base(val1, val2) { }

        public double USValue(double rate)
        {
            return current_balance * rate;
        }
    }
}
