public class InvestimentAccount : IAccount
{
  private decimal _balance;

  public InvestimentAccount(decimal initialBalance)
  {
    _balance = initialBalance;
  }
  public void Deposit(decimal amount)
  {
    _balance += amount;
  }

  public void Withdraw(decimal amount)
  {
    throw new InvalidOperationException("Account type does not allow direct withdrawal.");
  }

  public decimal GetBalance()
  {
    return _balance;
  }
}