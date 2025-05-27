public class User : IUser
{
  public void Login()
  {
    Console.WriteLine("Login successful.");
  }
  public void Logout()
  {
    Console.WriteLine("Logout successful.");
  }
  public void CreateUser(string username, string email)
  {
    Console.WriteLine($"User {username} with email {email} created.");
  }
  public void DeleteUser(int id)
  {
    Console.WriteLine($"User ID {id} deleted.");
  }
  public void UpdateUser(int id, string username, string email)
  {
    Console.WriteLine($"User ID {id} updated.");
  }
}