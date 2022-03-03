using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicLibrary;
using MusicLibrary.Models;
using System;
using System.Collections.Generic;

namespace MusicLibrary.Tests
{
  [TestClass]
  public class ArtistTests : IDisposable
  {
    public void Dispose()
    {
      Artist.RemoveAll();
    }
    [TestMethod]
    public void Constructor_CreatesArtist_Artist()
    {
      Artist testArtist = new Artist("Reba McEntire");
      Assert.AreEqual(typeof(Artist), testArtist.GetType());
    }
    [TestMethod]
    public void NameGetter_ReturnsName_String()
    {
      Artist nameArtist = new Artist("George Michael");
      Assert.AreEqual("George Michael", nameArtist.Name);
    }
    [TestMethod]
    public void GetId_ReturnsArtistId_int()
    {
      Artist newArtist = new Artist("Dolly Parton");
      Assert.AreEqual(1, newArtist.Id);
    }
    [TestMethod]
    public void GetAll_ReturnsAllArtists_ArtistList()
    {
      string name01 = "Cher";
      string name02 = "Skrillex";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      List<Artist> newList = new List<Artist> { newArtist1, newArtist2 };
      List<Artist> result = Artist.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectArtist_Artist()
    {
      string name01 = "Cher";
      string name02 = "Skrillex";
      Artist newArtist1 = new Artist(name01);
      Artist newArtist2 = new Artist(name02);
      Artist result = Artist.Find(2);
      Assert.AreEqual(newArtist2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithCategory_ItemList()
    {
      string album = "Illmatic";
      Album newAlbum = new Album(album);
      List<Album> newList = new List<Album> { newAlbum };
      string artist = "Nas";
      Artist newArtist = new Artist(artist);
      newArtist.AddAlbum(newAlbum);
      List<Album> result = newArtist.Albums;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}