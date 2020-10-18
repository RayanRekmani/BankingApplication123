using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class Class1
    {
        public static string getPercentageChange(this double starting, double current)
        {
            string x = ((current / starting) * 100).ToString("0.##");
            return x;
        }
    }
}
