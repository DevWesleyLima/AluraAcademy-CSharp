using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.2: ByteBank");
            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount bankAccount1 = new BankAccount();
            BankAccount bankAccount2 = new BankAccount();

            //  VAR
            int bank1;
            int bank2;
            
            //  Data1
            bankAccount1.holder = "Gabbie";
            bankAccount1.branchNumber = 863;
            bankAccount1.number = 863452;
            bankAccount1.InitialBankBalance(100);

            //  Data2
            bankAccount2.holder = "Gabbie";
            bankAccount2.branchNumber = 863;
            bankAccount2.number = 863452;
            bankAccount2.InitialBankBalance(100);

            //  Data3
            bank1 = 863;
            bank2 = 863;

            //  Bool Check1: Memory Reference Type (Objects)
            Console.WriteLine("Check Memory Reference Type: " + (bankAccount1 == bankAccount2)); //  Return False!

            //  Bool Check2: Value Type (Variables)
            Console.WriteLine("Check Value Type: " + (bank1 == bank2)); //  Return True!

            //  Data4
            bankAccount2 = bankAccount1;

            // Bool Check3: Memory Reference Type (Objects)
            Console.WriteLine("Check Memory Reference Type: " + (bankAccount1 == bankAccount2)); //  Return True!
            Console.WriteLine("Check Memory Reference Type: " + (bankAccount2 == bankAccount1)); //  Return True!

            Console.WriteLine();
            Console.WriteLine("Balance BankAccount1: " + bankAccount1.initialBalance); //  Return 100
            Console.WriteLine("Balance BankAccount2: " + bankAccount2.initialBalance); //  Return 100
            Console.WriteLine();

            //  Data5
            bankAccount1.initialBalance = 300; //  Bank1 Initial Balance Receives 300

            Console.WriteLine("Balance BankAccount1: " + bankAccount1.initialBalance); //  Return 300
            Console.WriteLine("Balance BankAccount2: " + bankAccount2.initialBalance); //  Return 300 too, because both are linked to the same Memory Reference Type (check "Data4");

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}