using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._0_ConversionAndOtherNumericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Project 2.0: Conversion and Other Numeric Types");
            Console.WriteLine("*****************************************************");

            //  VAR
            double doubleMonthlySalary;
            int intMonthlySalary;

            doubleMonthlySalary = 1200.50;
            Console.WriteLine("Double Monthly Salary: " + doubleMonthlySalary);

            //  Converting Double to Int            
            intMonthlySalary = (int)doubleMonthlySalary;
            Console.WriteLine("Int (Converted) Monthly Salary: " + intMonthlySalary);
            Console.WriteLine("Note: Data may not display correctly due to differences in data types!!!");
            Console.WriteLine("*****************************************************");

            //  Integer Numeric Types
            sbyte sbyteBegin;
            sbyte sbyteEnd;
            byte byteBegin;
            byte byteEnd;
            short shortBegin;
            short shortEnd;
            ushort uShortBegin;
            ushort uShortEnd;
            int intBegin;
            int intEnd;
            uint uIntBegin;
            uint uIntEnd;
            long longBegin;
            long longEnd;
            ulong uLongBegin;
            ulong uLongEnd;

            Console.WriteLine("[Numeric Integer Types]");

            sbyteBegin = -128;
            sbyteEnd = 127;
            Console.WriteLine("sByte Range (8 Bits): " + sbyteBegin + " to " + sbyteEnd);

            byteBegin = 0;
            byteEnd = 255;
            Console.WriteLine("Byte Range (8 Bits): " + byteBegin + " to " + byteEnd);

            shortBegin = -32768;
            shortEnd = 32767;
            Console.WriteLine("Short Range (16 Bits): " + shortBegin + " to " + shortEnd);

            uShortBegin = 0;
            uShortEnd = 65535;
            Console.WriteLine("uShort Range (16 Bits): " + uShortBegin + " to " + uShortEnd);

            intBegin = -2147483648;
            intEnd = 2147483647;
            Console.WriteLine("Int Range (32 Bits): " + intBegin + " to " + intEnd);

            uIntBegin = 0;
            uIntEnd = 4294967295;
            Console.WriteLine("uInt Range (32 Bits): " + uIntBegin + " to " + uIntEnd);

            longBegin = -9223372036854775808;
            longEnd = 9223372036854775807;
            Console.WriteLine("Long Range (64 Bits): " + longBegin + " to " + longEnd);

            uLongBegin = 0;
            uLongEnd = 18446744073709551615;
            Console.WriteLine("uLong Range (64 Bits): " + uLongBegin + " to " + uLongEnd);
            Console.WriteLine("*****************************************************");
            Console.WriteLine("[Floating Point Numeric Types]");

            //  Floating Point Numeric Types
            string floatBegin;
            string floatEnd;
            float floatNumber;
            string doubleBegin;
            string doubleEnd;
            double doubleNumber;
            double doubleNumber2;
            string decimalBegin;
            string decimalEnd;
            decimal decimalNumber;

            floatBegin = "-3.402823e38f";
            floatEnd = "3.402823e38f";
            floatNumber = 1.80f;
            Console.WriteLine("Float Number: " + floatNumber);
            Console.WriteLine("Float Range (32 Bits): " + floatBegin + " to " + floatEnd);

            doubleBegin = "-1.79769313486232e308";
            doubleEnd = "1.79769313486232e308";
            //  the use of d is optional!!!
            doubleNumber = 1.80;
            doubleNumber2 = 1.80d;
            Console.WriteLine("Double Number (without d): " + doubleNumber);
            Console.WriteLine("Double Number 2 (with d): " + doubleNumber2);
            Console.WriteLine("Double Range (64 Bits): " + doubleBegin + " to " + doubleEnd);

            decimalBegin = "±1.0 x 10e-28";
            decimalEnd = "±7.9 x 10e28";
            decimalNumber = 1.80m;
            Console.WriteLine("Decimal Number: " + decimalNumber);
            Console.WriteLine("Decimal Range (128 Bits): " + decimalBegin + " to " + decimalEnd);

            Console.WriteLine("");
            Console.WriteLine("Press any key to continue . . .       ");
            Console.ReadLine();
        }
    }
}
