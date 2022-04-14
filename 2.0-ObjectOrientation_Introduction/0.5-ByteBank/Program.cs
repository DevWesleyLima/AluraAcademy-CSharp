using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.5: ByteBank");
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account1 = new BankAccount();

            //  Data1
            account1.Holder = new Customer()
            {
                Name = "Gabbryela Costa",
                Profession = "C# Developer",
                CPF = "434.562.878-20"
            };          
            account1.BranchNumber = 563;
            account1.Number = 5634527;
            account1.SetInitialBalance(-10);
            account1.BankWithdrawal(200);
            account1.BankTransfer(200, account1);


            Console.WriteLine(account1);
            Console.WriteLine();            
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account2 = new BankAccount();

            //  Data2
            account2.Holder = new Customer()
            {
                Name = "Gabbryela Costa",
                Profession = "C# Developer",
                CPF = "434.562.878-20"
            };
            account2.BranchNumber = 563;
            account2.Number = 5634527;
            account2.AmountValue = 10;

            Console.WriteLine(account2.AmountValue);
            //Console.WriteLine(account2);
            Console.WriteLine();
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account3 = new BankAccount();

            //  Data3
            account3.Holder = new Customer()
            {
                Name = "Guglielmo Perozzo",
                Profession = "C# Developer",
                CPF = "434.564.879-20"
            };
            account3.BranchNumber = 563;
            account3.Number = 5634527;          

            account3.AmountValue = 10;

            Console.WriteLine(account3.Holder.Name);
            Console.WriteLine(account3.AmountValue);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
