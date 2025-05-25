public class Order
{
  public int Id { get; private set; }
  public string CustomerName { get; private set; }
  public DateTime OrderDate { get; private set; }
  public Order(int id, string customerName, DateTime orderDate)
  {
    Id = id;
    CustomerName = customerName;
    OrderDate = orderDate;
  }

}