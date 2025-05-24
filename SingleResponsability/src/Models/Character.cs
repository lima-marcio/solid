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

  public void UpdateLevel(int level)
  {
    if (Math.Abs(level) > 10 && Math.Abs(level) <= 20)
    {
      level = level * 2;
    }
    else if (Math.Abs(level) > 20)
    {
      level = level * 5;
    }

    Level += level;

    if (Level <= 0)
    {
      Level = 0;
    }
  }

}