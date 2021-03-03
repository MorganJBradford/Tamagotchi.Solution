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
      Tamagotchi newTamagotchi = new Tamagotchi();
      Assert.AreEqual(typeof(Tamagotchi), newTamagotchi.GetType());
    }
  }
}