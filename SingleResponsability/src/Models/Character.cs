public class Character
{
  public string Name { get; set; }
  public int Level { get; set; }
  public string Class { get; set; }
  public Character(string name, int level, string characterClass)
  {
    Name = name;
    Level = level;
    Class = characterClass;
  }
}