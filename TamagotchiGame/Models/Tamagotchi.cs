namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }  
    public int Hunger { get; }

    public Tamagotchi (string name)
    {
      Name = name;
      Hunger = 100;
    }
    
  }
}