namespace TamagotchiGame.Models
{
  public class Tamagotchi
  {
    public string Name { get; set; }  
    public int Hunger { get; set; }

    public Tamagotchi (string name)
    {
      Name = name;
      Hunger = 0;
    }
    
  }
}