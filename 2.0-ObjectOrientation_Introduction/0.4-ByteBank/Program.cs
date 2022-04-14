using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace _0._4_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running project 0.4: ByteBank");
            Console.WriteLine("***************************************");

            //  OBJ
            Customer gabby = new Customer();
            BankAccount account = new BankAccount();

            //  Data1
            gabby.name = "Gabbryela";
            gabby.profession = "C# Developer";
            gabby.cpf = "434.562.878-20";
            
            account.holder = gabby;

            //  Data2
            account.holder.name = "Gabbryela Costa";

            Console.WriteLine(gabby.name);
            Console.WriteLine(account.holder.name);

            //  Bool Check1: Memory Reference Type (Objects)
            Console.WriteLine("Check Memory Reference Type: " + (gabby.name == account.holder.name)); //  Return True!

            Console.WriteLine("***************************************");

            //  OBJ
            BankAccount account1 = new BankAccount();

            //  Data3
            //account1.holder = new Customer();
            //account1.holder.name = "Gabbryela Costa";
            //account1.holder.profession = "C# Developer";
            //account1.holder.cpf = "434.562.878-20";
            account1.branchNumber = 563;
            account1.number = 5634527;
            account1.InitialBankBalance(100);

            if (account1.holder == null) 
            {
                Console.WriteLine("Oops, the reference in account1.holder is NULL!!!");
            }

            //Console.WriteLine(account1);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
