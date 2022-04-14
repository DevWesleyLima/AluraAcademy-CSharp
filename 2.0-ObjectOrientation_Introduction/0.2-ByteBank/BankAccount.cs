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

    public BankAccount()
    {
        holder = String.Empty;
        branchNumber = 0;
        number = 0;
        initialBalance = 0;
        depositValue = 0;
        withdrawalValue = 0;
        amountValue = 0;
    }
    public BankAccount(string holder, int branchNumber, int number, double initialBalance, double depositValue, double withdrawalValue, double amountValue)
    {
        this.holder = holder;
        this.branchNumber = branchNumber;
        this.number = number;
        this.initialBalance = initialBalance;
        this.depositValue = depositValue;
        this.withdrawalValue = withdrawalValue;
        this.amountValue = amountValue;
    }

    public double InitialBankBalance(double value)
    {
        initialBalance = value;
        return amountValue += value;
    }

    public double BankDeposit(double value)
    {
        depositValue += value;
        return amountValue += value;
    }

    public double BankWithdrawal(double value)
    {
        withdrawalValue += value;
        return amountValue -= value;
    }

    public override string ToString()
    {
        if (depositValue > 0 && withdrawalValue > 0)
        {
            return
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {holder} \n" +
                $"Bank Branch Number: {branchNumber} \n" +
                $"Bank Account Number: {number} \n" +
                $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Deposits in the Period: R$ {depositValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Withdrawal in the Period: R$ -{withdrawalValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Balance in the Period: R$ {amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";
        }
        else if (depositValue > 0 && withdrawalValue == 0)
        {
            return
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {holder} \n" +
                $"Bank Branch Number: {branchNumber} \n" +
                $"Bank Account Number: {number} \n" +
                $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Deposits in the Period: R$ {depositValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Balance in the Period: R$ {amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";
        }
        else if (withdrawalValue > 0 && depositValue == 0)
        {
            return
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {holder} \n" +
                $"Bank Branch Number: {branchNumber} \n" +
                $"Bank Account Number: {number} \n" +
                $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Withdrawal in the Period: R$ -{withdrawalValue.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Balance in the Period: R$ {amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";
        }
        else
        {
            return
                $"Bank Account - Data Information \n" +
                $"Bank Account Holder: {holder} \n" +
                $"Bank Branch Number: {branchNumber} \n" +
                $"Bank Account Number: {number} \n" +
                $"Bank Initial Balance: R$ {initialBalance.ToString("0,0.00", CultureInfo.InvariantCulture)} \n" +
                $"Bank Balance in the Period: R$ {amountValue.ToString("0,0.00", CultureInfo.InvariantCulture)}";
        }
    }
}