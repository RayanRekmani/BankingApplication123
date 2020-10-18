using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    class ExtensionMethods:Account
    {
        public ExtensionMethods(double val1, double val2) : base(val1, val2) { }
        public static string getPercentageChange()
        {
            string s = ((current_balance / starting_balance) * 100).ToString("0.##");
            return s;
        }

        public static string toNAMoneyFormat(bool b)
        {
            double x=12.43;
            if (b)
                x= Math.Ceiling(x * 100) / 100;
            else
                x= Math.Floor(x * 100) / 100;
            return "$" + x;
        }
    }
}
