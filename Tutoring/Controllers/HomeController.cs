using Microsoft.AspNetCore.Mvc;
using Tutoring.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Tutoring.Controllers
{
  public class HomeController : Controller
  {
    static HttpClient client = new HttpClient();
    public ActionResult Index()
    {
      return View();
    }
    public async Task<ActionResult> Search()
    {
      client.BaseAddress = new Uri("https://api.scryfall.com/cards/search");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
      return View();
    }
  }
}