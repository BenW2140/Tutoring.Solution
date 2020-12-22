using Tutoring.Models;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Tutoring.Models
{
  public class CardList
  {
    static HttpClient client = new HttpClient();
    public Array Data { get; set; }
    public bool HasMore { get; set; }
    public Uri PageNext { get; set; }
    public int TotalCards { get; set; }

    public async Task<CardList> Search(string parameter)
    {
      client.BaseAddress = new Uri("https://api.scryfall.com/cards/search");
      client.DefaultRequestHeaders.Accept.Clear();
      client.DefaultRequestHeaders.Accept.Add(
        new MediaTypeWithQualityHeaderValue("application/json"));
      CardList cardList = null;
      HttpResponseMessage response = await client.GetAsync(parameter);
      if(response.IsSuccessStatusCode)
      {
        cardList = await response.Content.ReadAsAsync<CardList>();
      }
      return cardList;
    }
  }
}