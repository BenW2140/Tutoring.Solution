using System;

namespace Tutoring.Models
{
  public class CardList
  {
    public Array Data { get; set; }
    public bool HasMore { get; set; }
    public Uri PageNext { get; set; }
    public int TotalCards { get; set; }
  }
}