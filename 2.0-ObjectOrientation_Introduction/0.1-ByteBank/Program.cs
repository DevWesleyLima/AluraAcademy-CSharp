using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.1: ByteBank");
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account = new BankAccount();

            //  Data1
            account.holder = "Gabbie";            
            Console.WriteLine("Bank Account Holder: " + account.holder);
            Console.WriteLine("Bank Account Number: " + account.number);
            Console.WriteLine("Bank Account Initial Balance: " + account.initialBalance);
            Console.WriteLine("Bank Account Balance: " + account.amountValue);

            account.initialBalance = 200;
            Console.WriteLine();
            Console.WriteLine("New Update!!!");
            Console.WriteLine("Bank Account Initial Balance: " + account.initialBalance);
            Console.WriteLine("Bank Account Balance: " + account.amountValue);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
