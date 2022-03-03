using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicLibrary;
using MusicLibrary.Models;

namespace MusicLibrary.Tests
{
  [TestClass]
  public class ArtistTests
  {
    [TestMethod]
    public void Constructor_CreatesArtist_Artist()
    {
      Artist testArtist = new Artist("Reba McEntire");
      Assert.AreEqual(typeof(Artist), testArtist.GetType());
    }
  }
}