public class PaymentService
{
  public void ProcessPayment(decimal amount)
  {
    var paymentMethod = new CreditCardPayment();
    paymentMethod.ProcessPayment(amount);
  }
}