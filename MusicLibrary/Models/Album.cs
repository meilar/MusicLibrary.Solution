using System.Collections.Generic;

namespace MusicLibrary.Models
{
    public class Album
    {
        public string AlbumTitle { get; set; }
        public int Id { get; }
        private static List<Album> _instances = new List<Album> { };

        public Album(string albumTitle)
        {
          AlbumTitle = albumTitle;
          _instances.Add(this);
          Id = _instances.Count;
        }

        public static List<Album> GetAll()
        {
          return _instances;
        }

        public static void RemoveAll()
        {
          _instances.Clear();
        }

        public static Album Find(int searchId)
        {
          return _instances[searchId - 1];
        }
    }
}