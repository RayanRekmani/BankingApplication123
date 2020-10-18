using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            RunBank();
        }

        static void RunBank()
        {
            Boolean run = false;
            do
            {
                run = false;
                Console.WriteLine("Please choose an account type \n" +
                    "A for Savings Account \n" +
                    "B for Chequing Account \n" +
                    "C for GlobalSaving Account \n" +
                    "Q to Exit Program\n" +
                    "---------------------------------------------");
                String x = Console.ReadLine();
                switch (x.ToLower())
                {
                    case "a":
                        RunSavings();
                        break;
                    case "b":
                        RunChequing();
                        break;
                    case "c":
                        RunGlobal();
                        break;
                    case "q":
                        System.Environment.Exit(1);
                        break;
                    default:
                        run = true;
                        break;
                }
            }
            while (run);
        }

        static void RunGlobal()
        {
            GlobalSavingsAcount gs = new GlobalSavingsAcount(5, 1);
            Boolean run = false;
            do
            {
                run = false;
                Console.WriteLine("A to Deposit\n" +
                    "B to Withdraw\n" +
                    "C to Close and Report\n" +
                    "R to Return to Bank Menu\n" +
                    "---------------------------------------------");
                String x = Console.ReadLine();
                switch (x.ToLower())
                {
                    case "a":
                        Console.WriteLine("How much would you like to deposit?");
                        double d = Convert.ToDouble(Console.ReadLine());
                        gs.MakeDeposit(d);
                        run = true;
                        break;
                    case "b":
                        Console.WriteLine("How much would you like to withdraw?");
                        double w = Convert.ToDouble(Console.ReadLine());
                        gs.MakeWithdrawl(w);
                        run = true;
                        break;
                    case "c":
                        String s = gs.CloseAndReport();
                        Console.WriteLine(s);
                        break;
                    case "d":
                        Console.WriteLine("What is the current US rate?");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(gs.USValue(r));
                        run = true;
                        break;
                    case "r":
                        RunBank();
                        break;
                    default:
                        run = true;
                        break;
                }
            }
            while (run);
        }

        static void RunChequing()
        {
            ChequingAccount ca = new ChequingAccount(5, 1);
            Boolean run = false;
            do
            {
                run = false;
                Console.WriteLine("A to Deposit\n" +
                    "B to Withdraw\n" +
                    "C to Close and Report\n" +
                    "R to Return to Bank Menu\n" +
                    "---------------------------------------------");
                String x = Console.ReadLine();
                switch (x.ToLower())
                {
                    case "a":
                        Console.WriteLine("How much would you like to deposit?");
                        double d = Convert.ToDouble(Console.ReadLine());
                        ca.MakeDeposit(d);
                        run = true;
                        break;
                    case "b":
                        Console.WriteLine("How much would you like to withdraw?");
                        double w = Convert.ToDouble(Console.ReadLine());
                        ca.MakeWithdrawl(w);
                        run = true;
                        break;
                    case "c":
                        String s = ca.CloseAndReport();
                        Console.WriteLine(s);
                        break;
                    case "r":
                        RunBank();
                        break;
                    default:
                        run = true;
                        break;
                }
            }
            while (run);
        }

        static void RunSavings()
        {
            SavingsAccount sa = new SavingsAccount(5, 1);
            Boolean run = false;
            do
            {
                run = false;
                Console.WriteLine("A to Deposit\n" +
                    "B to Withdraw\n" +
                    "C to Close and Report\n" +
                    "R to Return to Bank Menu\n" +
                    "---------------------------------------------");
                String x = Console.ReadLine();
                switch (x.ToLower())
                {
                    case "a":
                        Console.WriteLine("How much would you like to deposit?");
                        double d = Convert.ToDouble(Console.ReadLine());
                        sa.MakeDeposit(d);
                        run = true;
                        break;
                    case "b":
                        Console.WriteLine("How much would you like to withdraw?");
                        double w = Convert.ToDouble(Console.ReadLine());
                        sa.MakeWithdrawl(w);
                        run = true;
                        break;
                    case "c":
                        String s = sa.CloseAndReport();
                        Console.WriteLine(s);
                        break;
                    case "r":
                        RunBank();
                        break;
                    default:
                        run = true;
                        break;
                }
            }
            while (run);
        }
    }
}
