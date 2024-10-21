BankAccount bankAccount1 = new BankAccount("ACC-001", "Md. Saddam Hossain", 1000);

BankAccount bankAccount2 = new BankAccount("ACC-002", "Rana", 500);

Console.WriteLine($"{bankAccount1.AccountName}'s initial balance: {bankAccount1.Balance}");

Console.WriteLine($"{bankAccount2.AccountName}'s initial balance: {bankAccount2.Balance}");

if (bankAccount1.Deposite(100))
{
    Console.WriteLine($"Deposited to {bankAccount1.AccountName}'s account. New balance: {bankAccount1.Balance}");
}
else
{
    Console.WriteLine("Failed to deposit.");
}

if (bankAccount1.Withdraw(50))
{
    Console.WriteLine($"Withdraw from {bankAccount1.AccountName}'s account. New balance: {bankAccount1.Balance}");
}
else
{
    Console.WriteLine("Failed to withdraw. Insufficient funds or invalid amount.");
}


if (bankAccount1.Transfer(200, bankAccount2))
{
    Console.WriteLine($"Transferred to {bankAccount2.AccountName}'s account. New balance of {bankAccount1.AccountName}'s : {bankAccount1.Balance}");

    Console.WriteLine($"{bankAccount2.AccountName}'s new balance: {bankAccount2.Balance}");
}
else
{
    Console.WriteLine("Failed to transfer. Insufficient funds or invalid amount.");
}

Console.WriteLine($"{bankAccount1.AccountName}'s final balance: {bankAccount1.Balance}");

Console.WriteLine($"{bankAccount2.AccountName}'s final balance: {bankAccount2.Balance}");