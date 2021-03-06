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
    public IActionResult Index()
    {
      return View();
    }
    public async Task<IActionResult> Search(string parameter)
    {
      client.BaseAddress = new Uri("https://api.scryfall.com/cards/search?q=");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
      CardList cardList = null;
      HttpResponseMessage response = await client.GetAsync(parameter);
      if(response.IsSuccessStatusCode)
      {
        cardList = await response.Content.ReadAsAsync<CardList>();
      }
      return View(cardList);
    }
  }
}