Console.Clear();
var commomUser = new User();
commomUser.Login();
// Commom users canot delete users
commomUser.Logout();

var adminUser = new AdminUser();
adminUser.Login();
adminUser.DeleteUser(1);