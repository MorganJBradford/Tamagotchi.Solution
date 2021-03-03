namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }  
    public int Hunger { get; set; }
    public int Attention { get; set; }
    public int Sleepiness { get; set; }

    public Tamagotchi (string name)
    {
      Name = name;
      Hunger = 100;
      Attention = 100;
      Sleepiness = 0;
    }
    
    public void PassTime()
    {
      Hunger -= 10;
      Attention -= 10;
      Sleepiness += 10;
    }
  }
}