using Gighub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Gighub.Controllers
{
  public class HomeController : Controller
  {
    private ApplicationDbContext _ctx;
    public HomeController()
    {
      _ctx = new ApplicationDbContext();
    }
    public ActionResult Index()
    {
      var upcomingGigs = _ctx.Gigs
        .Include(g => g.Artist)
        .Where(g => g.DateTime > DateTime.Now);
      return View(upcomingGigs);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}