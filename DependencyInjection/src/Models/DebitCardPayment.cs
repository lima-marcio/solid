public class DebitCardPayment : IPayment
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Payment of {amount:C} processed using Debit Card.");
  }
}