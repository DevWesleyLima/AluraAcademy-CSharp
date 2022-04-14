using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._0_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.0: ByteBank");
            Console.WriteLine("***************************************");

            /*
             *  Non-Object Oriented Method
             */
           
            Console.WriteLine("Non-Object Oriented Method");
            Console.WriteLine();

            //  VAR
            string bankAccountHolder;
            int bankBranchNumber;
            int bankAccountNumber;
            double bankAccountBalance;

            //  Data1
            bankAccountHolder = "Gabbie";
            bankBranchNumber = 863;
            bankAccountNumber = 863146;
            bankAccountBalance = 100.00;
            Console.WriteLine(
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {bankAccountHolder} \n" +
                $"Bank Branch Number: {bankBranchNumber} \n" +
                $"Bank Account Number: {bankAccountNumber} \n" +
                $"Bank Balance: R$ {bankAccountBalance}"
                );

            Console.WriteLine();

            //  Data2
            bankAccountHolder = "Brendon";
            bankBranchNumber = 863;
            bankAccountNumber = 863864;
            bankAccountBalance = 50.00;
            Console.WriteLine(
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {bankAccountHolder} \n" +
                $"Bank Branch Number: {bankBranchNumber} \n" +
                $"Bank Account Number: {bankAccountNumber} \n" +
                $"Bank Balance: R$ {bankAccountBalance}"
                );

            Console.WriteLine("***************************************");

            /*
             *  Object Orientation Method
             */

            Console.WriteLine("Object Orientation Method");
            Console.WriteLine();

            //  OBJ
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();
            BankAccount bankAccount3 = new BankAccount();
            BankAccount bankAccount4 = new BankAccount();
            BankAccount bankAccount5 = new BankAccount();

            //  Data1
            bankAccount1.holder = "Annie";
            bankAccount1.branchNumber = 865;
            bankAccount1.number = 865865;
            bankAccount1.InitialBankBalance(500);

            Console.WriteLine(bankAccount1);            
            Console.WriteLine();

            //  Data2
            bankAccount2.holder = "Freddy";
            bankAccount2.branchNumber = 866;
            bankAccount2.number = 866866;
            bankAccount2.InitialBankBalance(900);
            bankAccount2.BankDeposit(100);
            bankAccount2.BankWithdrawal(250);

            Console.WriteLine(bankAccount2);
            Console.WriteLine();

            //  Data3
            bankAccount3.holder = "Jackie";
            bankAccount3.branchNumber = 867;
            bankAccount3.number = 867867;
            bankAccount3.InitialBankBalance(900);
            bankAccount3.BankDeposit(100);

            Console.WriteLine(bankAccount3);
            Console.WriteLine();

            //  Data4
            bankAccount4.holder = "Francesca";
            bankAccount4.branchNumber = 868;
            bankAccount4.number = 868868;
            bankAccount4.InitialBankBalance(750);            
            bankAccount4.BankWithdrawal(250);

            Console.WriteLine(bankAccount4);
            Console.WriteLine();

            //  Data5
            bankAccount5.holder = "Nevraska";
            bankAccount5.branchNumber = 869;
            bankAccount5.number = 869869;
            bankAccount5.InitialBankBalance(750);
            bankAccount5.BankWithdrawal(760);

            Console.WriteLine(bankAccount5);
            Console.WriteLine();

            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
