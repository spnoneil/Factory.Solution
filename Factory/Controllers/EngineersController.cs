using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Factory.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryContext _db;

    public EngineersController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Engineer> model = _db.Engineers.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Engineer eng)
    {
      _db.Engineers.Add(eng);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var eng = _db.Engineers
          .Include(e => e.JoinEntities)
          .ThenInclude(j => j.Machine)
          .FirstOrDefault(e => e.EngineerId == id);
      return View(eng);
    }
  }
}