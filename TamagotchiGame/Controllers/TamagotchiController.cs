using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;

namespace TamagotchiGame.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/tamagotchis/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/tamagotchis")]
    public ActionResult Create(string name)
    {
      Tamagotchi myTamagotchi = new Tamagotchi(name);
      return RedirectToAction("Index");
    }
  }
}