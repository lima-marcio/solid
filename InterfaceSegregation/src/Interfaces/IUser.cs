public interface IUser
{
  void Login();
  void Logout();
  void CreateUser(string username, string email);
  void DeleteUser(int id);
  void UpdateUser(int id, string username, string email);
}