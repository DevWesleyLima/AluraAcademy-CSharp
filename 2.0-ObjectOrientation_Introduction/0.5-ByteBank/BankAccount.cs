using System;
using System.Globalization;

namespace _0._5_ByteBank
{
    public class BankAccount
    {
        public Customer Holder { get; set; }
        public int BranchNumber { get; set; }
        public int Number { get; set; }
        public double initialBalance;
        public double depositValue;
        public double withdrawalValue;
        private double _amountValue;
        public double transferedAmountValue;
        public double receivedAmountValue;

        public BankAccount()
        {
            Holder = null;
            BranchNumber = 0;
            Number = 0;
            initialBalance = 0;
            depositValue = 0;
            withdrawalValue = 0;
            _amountValue = 0;
            transferedAmountValue = 0;
            receivedAmountValue = 0;
        }
        public BankAccount(Customer Holder, int BranchNumber, int Number, double initialBalance, double depositValue, double withdrawalValue, double _amountValue, double transferedAmountValue, double receivedAmountValue)
        {
            this.Holder = Holder;
            this.BranchNumber = BranchNumber;
            this.Number = Number;
            this.initialBalance = initialBalance;
            this.depositValue = depositValue;
            this.withdrawalValue = withdrawalValue;
            this._amountValue = _amountValue;
            this.transferedAmountValue = transferedAmountValue;
            this.receivedAmountValue = receivedAmountValue;
        }

        // Get Set
        public double AmountValue
        {
            get 
            {
                return _amountValue;
            }
            set
            { 
                if (value < 0)
                {
                    return;
                }
                
                _amountValue = value;
            }
        }        

        //  New Bool SetInitialBalance according to the teacher's instructions
        public bool SetInitialBalance(double value)
        {            
            if (value < 0)
            {
                Console.WriteLine("Attention: it was NOT possible to set the initial bank balance!!!");
                Console.WriteLine($"Please Check the following data: R$ {value.ToString("0,0.00", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                return false;
            }
            else
            {
                initialBalance = value;
                _amountValue += value;
                return true;
            }
        }

        //  New void BankDeposit according to the teacher's instructions
        public void BankDeposit(double value)
        {
            depositValue += value;
            _amountValue += value;
        }

        //  New Bool BankWithdrawal according to the teacher's instructions
        public bool BankWithdrawal(double value)
        {
            if (this._amountValue < value)
            {                
                Console.WriteLine("Attention: it was NOT possible to withdraw the amount informed!!!");
                Console.WriteLine($"Please Check the following data: R$ -{value.ToString("0,0.00", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                return false;
            }
            else
            {
                withdrawalValue += value;
                _amountValue -= value;
                return true;
            }
        }

        //  New Bool BankTransfer according to the teacher's instructions
        public bool BankTransfer(double value, BankAccount destinationAccount)
        {
            if (_amountValue < value)
            {
                Console.WriteLine("Attention: it was NOT possible to transfer the amount informed!!!");
                Console.WriteLine($"Please Check the following data: R$ -{value.ToString("0,0.00", CultureInfo.InvariantCulture)}");
                Console.WriteLine();
                return false;
            }
            else
            {
                transferedAmountValue += value;
                _amountValue -= value;

                destinationAccount.BankDeposit(value);
                destinationAccount.depositValue -= value;
                destinationAccount.receivedAmountValue += value;
                return true;
            }
        }

        public override string ToString()
        {
            return
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {Holder.Name} \n" +
                $"Bank Branch Number: {BranchNumber} \n" +
                $"Bank Account Number: {Number} \n" +
                $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Deposits in the Period: R$ {depositValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Withdrawal in the Period: R$ -{withdrawalValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Received Amount in the Period: R$ {receivedAmountValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Transfered Amount in the Period: R$ -{transferedAmountValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Balance in the Period: R$ {_amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";
        }
    }
}