using System;

namespace Tutoring.Models
{
  public class Card
  {
    public string Id { get; set; }
    public Array CardFaces { get; set; }
    public decimal Cmc { get; set; }
    public string ManaCost { get; set; }
    public Array Colors { get; set; }
    public Array ColorIdentity { get; set; }
    public Array Keywords { get; set; }
    public string Layout { get; set; }
    public string Name { get; set; }
    public string TypeLine { get; set; }
    public string Power { get; set; }
    public string Toughness { get; set; }
    public string Rarity { get; set; }
  }
}