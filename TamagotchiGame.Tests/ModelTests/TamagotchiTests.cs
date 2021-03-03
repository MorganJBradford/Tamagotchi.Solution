using Microsoft.VisualStudio.TestTools.UnitTesting;
using TamagotchiGame.Models;

namespace TamagotchiGame.Tests
{
  [TestClass]
  public class TamagotchiTests
  {
    [TestMethod]
    public void TamagotchiConstructor_CreateInstanceOfTamagotchi_Tamagotchi()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Daniel";
      Tamagotchi newTamagotchi = new Tamagotchi(name);
      string result = newTamagotchi.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetHunger_ReturnsHunger_Int()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      int result = newTamagotchi.Hunger;
      Assert.AreEqual(100, result);
    }

    [TestMethod]
    public void GetAttention_ReturnsAttention_Int()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      int result = newTamagotchi.Attention;
      Assert.AreEqual(100, result);
    }

    [TestMethod]
    public void GetSleepiness_ReturnsSleepiness_Int()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      int result = newTamagotchi.Sleepiness;
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void PassTime_SubtractsFromHunger_Int()
    {
      Tamagotchi newTamagotchi = new Tamagotchi("Daniel");
      newTamagotchi.PassTime()
      int result = newTamagotchi.Hunger;
      Assert.AreEqual(90, result);
    }
  }
}