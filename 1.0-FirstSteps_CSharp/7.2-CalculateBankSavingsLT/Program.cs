using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_CalculateBankSavingsLT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 7.2: Calculate Bank Savings Long Term");
            Console.WriteLine("*****************************************************");

            //  VAR
            double initialInvestment;
            double bankInterestRate;
            int monthlyCounter;
            int annualCounter;

            //  Data
            initialInvestment = 1000.00;
            bankInterestRate = 1.0036;

            //  Calculating Compound Interest
            for (annualCounter = 1; annualCounter <= 5; annualCounter++)
            {
                Console.WriteLine($"Year: {annualCounter}");
                for (monthlyCounter = 1; monthlyCounter <= 12; monthlyCounter++)
                {
                    initialInvestment *= bankInterestRate;
                    Console.WriteLine($"After {monthlyCounter} month(s), your amount will be: R$ " + initialInvestment);

                }
                bankInterestRate += 0.0010;
                Console.WriteLine();
            }

            Console.WriteLine("Your amount will be: R$ " + initialInvestment + " in the end of the period!");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
