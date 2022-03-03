using Microsoft.AspNetCore.Mvc;

namespace MusicLibrary.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}