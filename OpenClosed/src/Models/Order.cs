public class Order
{
  public int OrderId { get; private set; }
  public string CustomerName { get; private set; }
  public DateTime OrderDate { get; private set; }
  public Order(int orderId, string customerName, DateTime orderDate)
  {
    OrderId = orderId;
    CustomerName = customerName;
    OrderDate = orderDate;
  }

}