using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.6: ByteBank");
            Console.WriteLine("***************************************");

            Console.WriteLine("Total of Accounts: " + BankAccount.TotalAccounts);

            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account1 = new BankAccount(867, 86712540);
                       
            Console.WriteLine(account1.BranchNumber);
            Console.WriteLine(account1.Number);
            Console.WriteLine("Total of Accounts: " + BankAccount.TotalAccounts);

            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account2 = new BankAccount(867, 86745820);

            Console.WriteLine(account2.BranchNumber);
            Console.WriteLine(account2.Number);
            Console.WriteLine("Total of Accounts: " + BankAccount.TotalAccounts);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
