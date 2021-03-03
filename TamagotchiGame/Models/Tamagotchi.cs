namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }  
    public int Hunger { get; }
    public int Attention { get; }
    public int Sleepiness { get; }

    public Tamagotchi (string name)
    {
      Name = name;
      Hunger = 100;
      Attention = 100;
      Sleepiness = 0;
    }
    
  }
}