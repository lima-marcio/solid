public interface IAccount
{
  void Deposit(decimal amount);
  void Withdraw(decimal amount);
  decimal GetBalance();
}