using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._3_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.3: ByteBank");
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            BankAccount bankAccount3 = new BankAccount();
            BankAccount bankAccount4 = new BankAccount();

            //  VAR
            bool checkBankWithdrawal1;
            bool checkBankWithdrawal2;
            bool checkBankWithdrawal3;
            
            bool checkBankTransfer1;

            //  Data1
            bankAccount1.holder = "Braian";
            bankAccount1.branchNumber = 870;
            bankAccount1.number = 870870;
            bankAccount1.InitialBankBalance(50);
            bankAccount1.BankDeposit(0);
            checkBankWithdrawal1 = bankAccount1.BankWithdrawal(50);          

            Console.WriteLine(bankAccount1);
            Console.WriteLine();
            Console.WriteLine("Was it possible to withdraw the amount informed from the bank account balance?");
            Console.WriteLine("A: " + checkBankWithdrawal1);
            Console.WriteLine("***************************************");

            //  Data2
            bankAccount2.holder = "Brianna";
            bankAccount2.branchNumber = 871;
            bankAccount2.number = 871871;
            bankAccount2.InitialBankBalance(50);
            bankAccount2.BankDeposit(0);
            checkBankWithdrawal2 = bankAccount2.BankWithdrawal(60);
            //  Added to simulate the value
            bankAccount2.withdrawalValue = 60;

            Console.WriteLine(bankAccount2);
            Console.WriteLine();
            Console.WriteLine("Was it possible to withdraw the amount informed from the bank account balance?");
            Console.WriteLine("A: " + checkBankWithdrawal2);
            Console.WriteLine("***************************************");

            //  Data3
            bankAccount3.holder = "Bryson";
            bankAccount3.branchNumber = 872;
            bankAccount3.number = 872872;
            bankAccount3.InitialBankBalance(100);
            bankAccount3.BankDeposit(400);
            checkBankWithdrawal3 = bankAccount3.BankWithdrawal(160);

            Console.WriteLine(bankAccount3);
            Console.WriteLine();
            Console.WriteLine("Was it possible to withdraw the amount informed from the bank account balance?");
            Console.WriteLine("A: " + checkBankWithdrawal3);
            Console.WriteLine("***************************************");

            //  Data4
            bankAccount4.holder = "Briany";
            bankAccount4.branchNumber = 873;
            bankAccount4.number = 873873;
            bankAccount4.InitialBankBalance(100);
            bankAccount4.BankDeposit(400);
            checkBankTransfer1 = bankAccount4.BankTransfer(500, bankAccount3);

            Console.WriteLine(bankAccount4);
            Console.WriteLine();
            Console.WriteLine("Was it possible to transfer the amount informed from the bank account balance?");
            Console.WriteLine("A: " + checkBankTransfer1);
            Console.WriteLine("***************************************");
            Console.WriteLine("Bank Account Update");
            Console.WriteLine("***************************************");
            Console.WriteLine(bankAccount3);
            Console.WriteLine();
            Console.WriteLine("Was it possible to withdraw the amount informed from the bank account balance?");
            Console.WriteLine("A: " + checkBankWithdrawal3);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
