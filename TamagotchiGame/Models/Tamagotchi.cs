using System.Collections.Generic;

namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }  
    public int Hunger { get; set; }
    public int Attention { get; set; }
    public int Sleepiness { get; set; }
    public int Id { get; }
    private static List<Tamagotchi> _instances = new List<Tamagotchi> {};

    public Tamagotchi (string name)
    {
      Name = name;
      Hunger = 100;
      Attention = 100;
      Sleepiness = 0;
      _instances.Add(this);
      Id = _instances.Count;
    }
    
    public void PassTime()
    {
      Hunger -= 10;
      Attention -= 10;
      Sleepiness += 10;
    }

    public static List<Tamagotchi> GetAll()
    {
      return _instances;
    }

    public static Tamagotchi Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}