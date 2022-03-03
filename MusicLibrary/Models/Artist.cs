using System.Collections.Generic;

namespace MusicLibrary.Models
{
  public class Artist 
  {
    public string Name { get; set; }
    private static List<Artist> _instances = new List<Artist> { };
    public Artist(string name)
    {
      Name = name;
      _instances.Add(this);
    }
    
  }
}