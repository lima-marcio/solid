Console.Clear();
var commomUser = new User();
commomUser.Login();
// Commom users canot delete users
commomUser.DeleteUser(1);