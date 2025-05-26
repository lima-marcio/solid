var account1 = new CheckingAccount(10000);
Console.WriteLine($"Balance: {account1.GetBalance()}");
account1.Withdraw(100);
Console.WriteLine($"Balance after withdrawal: {account1.GetBalance()}");
var account2 = new InvestimentAccount(25000);
Console.WriteLine($"Balance after withdrawal: {account2.GetBalance()}");
account2.Withdraw(100);
