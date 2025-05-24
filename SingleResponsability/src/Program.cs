Console.Clear();
var player = new Character("Hero 1", 10, "Warrior");
Console.WriteLine($"{player.Name} is now level {player.Level}.");
player.UpdateLevel(5);
Console.WriteLine($"{player.Name} is now level {player.Level}.");
player.UpdateLevel(25);
Console.WriteLine($"{player.Name} is now level {player.Level}.");
