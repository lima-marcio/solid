Console.Clear();
var account1 = new SavingAccount(10000);
// var account1 = new InvestimentAccount(10000);
Console.WriteLine($"Balance: {account1.GetBalance()}");

var transaction = new TransactionService();
transaction.Withdraw(account1, 500);
account1.Withdraw(499);
Console.WriteLine($"Balance after withdrawal: {account1.GetBalance()}");

