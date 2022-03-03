using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;
using System.Collections.Generic;

namespace MusicLibrary.Controllers
{

  public class AlbumController : Controller
  {

      [HttpGet("/artists/{artistId}/albums/new")]
      public ActionResult New(int artistId)
      {
        Artist artist = Artist.Find(artistId);
        return View(artist);
      }

      [HttpPost("/albums/delete")]
      public ActionResult DeleteAll()
      {
        Album.RemoveAll();
        return View();
      }

      [HttpGet("/artists/{artistId}/album/{albumId}")]
      public ActionResult Show(int albumId, int artistId)
      {
        Album album = Album.Find(albumId);
        Artist artist = Artist.Find(artistId);
        Dictionary<string, object> model = new Dictionary<string, object>();
        model.Add("album", album);
        model.Add("artist", artist);
        return View(model);
    }
  }
}