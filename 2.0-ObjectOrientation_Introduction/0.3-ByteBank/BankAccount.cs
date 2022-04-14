using System;
using System.Globalization;

public class BankAccount
{
    public string holder;
    public int branchNumber;
    public int number;
    public double initialBalance;
    public double depositValue;
    public double withdrawalValue;
    public double amountValue;
    public double transferedAmountValue;
    public double receivedAmountValue;

    public BankAccount()
    {
        holder = String.Empty;
        branchNumber = 0;
        number = 0;
        initialBalance = 0;
        depositValue = 0;
        withdrawalValue = 0;
        amountValue = 0;
        transferedAmountValue = 0;
        receivedAmountValue = 0;
    }
    public BankAccount(string holder, int branchNumber, int number, double initialBalance, double depositValue, double withdrawalValue, double amountValue, double transferedAmountValue, double receivedAmountValue)
    {
        this.holder = holder;
        this.branchNumber = branchNumber;
        this.number = number;
        this.initialBalance = initialBalance;
        this.depositValue = depositValue;
        this.withdrawalValue = withdrawalValue;
        this.amountValue = amountValue;
        this.transferedAmountValue = transferedAmountValue;
        this.receivedAmountValue = receivedAmountValue;
    }

    public double InitialBankBalance(double value)
    {
        initialBalance = value;
        return amountValue += value;
    }

    //  New void BankDeposit according to the teacher's instructions
    public void BankDeposit(double value)
    {
        depositValue += value;
        this.amountValue += value;
    }

    //  New Bool BankWithdrawal according to the teacher's instructions
    public bool BankWithdrawal(double value)
    {
        if(this.amountValue < value)
        {
            return false;
        }
        else 
        {
            withdrawalValue += value;
            amountValue -= value;
            return true;
        }
    }

    //  New Bool BankTransfer according to the teacher's instructions
    public bool BankTransfer(double value, BankAccount destinationAccount)
    { 
        if(this.amountValue < value)
        {
            return false;
        }
        else
        {
            this.transferedAmountValue += value;
            this.amountValue -= value;
            
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
            $"Bank Account Holder: {holder} \n" +
            $"Bank Branch Number: {branchNumber} \n" +
            $"Bank Account Number: {number} \n" +
            $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
            $"Bank Deposits in the Period: R$ {depositValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +            
            $"Bank Withdrawal in the Period: R$ -{withdrawalValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
            $"Bank Received Amount in the Period: R$ {receivedAmountValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
            $"Bank Transfered Amount in the Period: R$ -{transferedAmountValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
            $"Bank Balance in the Period: R$ {amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";        
    }
}