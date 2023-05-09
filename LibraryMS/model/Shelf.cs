using Microsoft.AspNetCore.Mvc;

namespace BookShelf.model
{
    public class Shelf : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
