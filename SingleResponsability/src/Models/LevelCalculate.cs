public static class LevelCalculate
{
  public static int Calculate(int actualLevel, int attack, int damage)
  {
    if (Math.Abs(attack) > 10 && Math.Abs(attack) <= 20)
    {
      attack = attack * 2;
    }
    else if (Math.Abs(attack) > 20)
    {
      attack = attack * 5;
    }

    if (Math.Abs(damage) > 10 && Math.Abs(damage) <= 20)
    {
      damage = damage * 2;
    }
    else if (Math.Abs(damage) > 20)
    {
      damage = damage * 5;
    }

    damage = damage * (-1);

    var result = actualLevel + attack + damage;

    if (result < 0)
    {
      result = 0;
    }

    return result;
  }
}