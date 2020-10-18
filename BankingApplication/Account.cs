using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApplication
{
    public abstract class Account
    {
        double cumulative_deposit, deposit_count, annual_interest_rate, cumulative_withdrawal;
        public static double current_balance, service_charge, withdrawal_count, starting_balance;

        protected Account(double s, double annual_interest_rate)
        {
            starting_balance = s;
            this.annual_interest_rate = annual_interest_rate;
        }


        protected void CalculateInterest()
        {
            double monthly_interest_rate = annual_interest_rate/12;
            monthly_interest_rate *= current_balance;
            current_balance += monthly_interest_rate;
        }

        public string CloseAndReport()
        {
            CalculateInterest();
            current_balance -= service_charge;
            String report = "Starting balance : " + starting_balance.ToString("0.##") +
                "\nCurrent balance: " + current_balance.ToString("0.##") +
                "\nPercentage of change in comparison of past month " + ExtensionMethods.getPercentageChange() +"%"+
                "\nMonthly interest rate: " + (annual_interest_rate/12).ToString ("0.##") +
                "\nService charge: "+ service_charge.ToString("0.##");
            Reset();
            return report;

        }

        public void Reset()
        {
            starting_balance = current_balance;
            cumulative_deposit = 0;
            cumulative_withdrawal = 0;
            withdrawal_count = 0;
            deposit_count = 0;
            service_charge = 0;
        }

        public void MakeDeposit(double amount)
        {
            cumulative_deposit += amount;
            current_balance += amount;
            deposit_count++;
        }

        public void MakeWithdrawl(double amount)
        {
            cumulative_withdrawal += amount;
            current_balance -= amount;
            withdrawal_count++;
        }

        public static AccountStatus AccountStatus {get; set; }

        public static String Unsuccessful()
        {
            return "Sorry, your attempt was unsuccessful";
        }
    }
}
