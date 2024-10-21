namespace ClassObjectDemo02;

public class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountName { get; private set; }
    public double Balance { get; private set; }

    public BankAccount(string accountNumber, string accountName, double initialBalance)
    {
        AccountNumber = accountNumber;
        AccountName = accountName;
        Balance = initialBalance >= 0 ? initialBalance : 0;
    }

    public bool Deposite(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (amount > 0)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }

    public bool Transfer(double amount, BankAccount toAccount)
    {
        if (amount > 0)
        {
            Balance -= amount;
            toAccount.Deposite(amount);
            return true;
        }
        return false;
    }
}