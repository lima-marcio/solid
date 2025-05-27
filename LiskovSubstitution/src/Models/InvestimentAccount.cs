public class InvestimentAccount : BaseAccount
{
  public InvestimentAccount(decimal initialBalance) : base(initialBalance)
  {
  }
  public override void Withdraw(decimal amount)
  {
    Console.WriteLine($"Withdrawing {amount} from InvestingAccount.");
    if (amount < 500)
    {
      throw new InvalidOperationException("Minimum withdrawal amount is 500.");
    }
    Balance -= amount;
  }
}