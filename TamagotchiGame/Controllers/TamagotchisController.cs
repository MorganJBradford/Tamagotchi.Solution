using Microsoft.AspNetCore.Mvc;
using TamagotchiGame.Models;
using System.Collections.Generic;

namespace TamagotchisGame.Controllers
{
  public class TamagotchisController : Controller
  {
    [HttpGet("/tamagotchis")]
    public ActionResult Index()
    {
      List<Tamagotchi> allTamagotchis = Tamagotchi.GetAll();
      return View(allTamagotchis);
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


    [HttpGet("/tamagotchis/{id}")]
    public ActionResult Show(int id)
    {
      Tamagotchi foundTamagotchi = Tamagotchi.Find(id);
      return View(foundTamagotchi);
    }
  }
}