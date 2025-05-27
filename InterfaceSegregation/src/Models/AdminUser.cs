public class AdminUser : IAdminUser
{
  public void Login()
  {
    Console.WriteLine("Admin login successful.");
  }

  public void Logout()
  {
    Console.WriteLine("Admin logout successful.");
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
    Console.WriteLine($"User ID {id} updated with username {username} and email {email}.");
  }
}