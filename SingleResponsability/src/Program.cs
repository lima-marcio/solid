Console.Clear();
var player = new Character("Hero 1", 10, "Warrior");
Console.WriteLine($"Player: {player.Name}, Level: {player.Level}, Class: {player.Class}");
player.Level = LevelCalculate.Calculate(player.Level, 1, 5);
Console.WriteLine($"Player: {player.Name}, Level: {player.Level}, Class: {player.Class}");
player.Level = LevelCalculate.Calculate(player.Level, 23, 11);
Console.WriteLine($"Player: {player.Name}, Level: {player.Level}, Class: {player.Class}");
player.Level = LevelCalculate.Calculate(player.Level, 16, 37);
Console.WriteLine($"Player: {player.Name}, Level: {player.Level}, Class: {player.Class}");
