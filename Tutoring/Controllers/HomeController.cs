using Microsoft.AspNetCore.Mvc;
using Tutoring.Models;

namespace Tutoring.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }
  }
}