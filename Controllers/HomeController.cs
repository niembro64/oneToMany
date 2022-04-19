using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using oneToMany.Models;

namespace oneToMany.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private MyContext _context;

    public HomeController(ILogger<HomeController> logger, MyContext context)
    {
      _logger = logger;
      _context = context;
    }

    public IActionResult Index()
    {
      ViewBag.AllArtists = _context.Artists.OrderBy(a => a.Name).ToList();
      return View();
    }

    public IActionResult Privacy()
    {
      return View();
    }

    [HttpPost("artist/create")]
    public IActionResult AddArtist(Artist newArtist)
    {
      if (ModelState.IsValid)
      {
        _context.Artists.Add(newArtist);
        _context.SaveChanges();

        ViewBag.AllArtists = _context.Artists.OrderBy(a => a.Name).ToList();
        return RedirectToAction("Index");
      }
      else
      {
        ViewBag.AllArtists = _context.Artists.OrderBy(a => a.Name).ToList();
        return View("Index");
      }
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
