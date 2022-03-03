using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicLibrary.Models;

namespace MusicLibrary.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> allArtists = Artist.GetAll();
      return View(allArtists);
    }

    [HttpGet("/artists/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/artists")]
    public ActionResult Create(string artistName)
    {
      Artist newArtist = new Artist(artistName);
      return RedirectToAction("Index");
    }

    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist selectedArtist = Artist.Find(id);
      List<Album> artistAlbums = selectedArtist.Albums;
      model.Add("artist", selectedArtist);
      model.Add("album", artistAlbums);
      return View();
    }

    [HttpPost("/artists/{artistId}/album")]
    public ActionResult Create(int artistId, string albumTitle)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Artist foundArtist = Artist.Find(artistId);
      Album newAlbum = new Album(albumTitle);
      foundArtist.AddAlbum(newAlbum);
      List<Album> artistAlbum = foundArtist.Albums;
      model.Add("album", artistAlbum);
      model.Add("artist", foundArtist);
      return View("Show", model);
    }
  }
}