public class CreditCardPayment : IPayment
{
  public void ProcessPayment(decimal amount)
  {
    Console.WriteLine($"Payment of {amount:C} processed using Credit Card.");
  }
}