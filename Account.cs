using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankingApplication
{
    protected abstract class Account : IAccount
    {
        double starting_balance, current_balance, cumulative_deposit, deposit_count, cumulative_withdrawal, withdrawal_count, annual_interest_rate, service_charge;
        AccountStatus active_account = AccountStatus.Active;
        AccountStatus disabled_account = AccountStatus.Disabled;

        public Account(double starting_balance, double annual_interest_rate)
        {
            this.starting_balance = starting_balance;
            this.annual_interest_rate = annual_interest_rate;
        }

        public void CalculateInterest()
        {
            double monthly_interest_rate = annual_interest_rate/12;
            monthly_interest_rate *= current_balance;
            current_balance += monthly_interest_rate;
        }

        public string CloseAndReport()
        {
            CalculateInterest();
            current_balance -= service_charge;
            String report = "Starting balance : " + starting_balance +
                "\nCurrent balance: " + current_balance +
                "\nPercentage of change in comparison of past month " + (current_balance / starting_balance) * 100 +
                "\nMonthly interest rate: " + annual_interest_rate/12 +
                "\nService charge: "+ service_charge;
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
    }
}
