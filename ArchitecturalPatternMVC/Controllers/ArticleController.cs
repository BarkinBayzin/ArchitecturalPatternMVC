using ArchitecturalPatternMVC.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArchitecturalPatternMVC.Controllers
{
    [LoggedUser]
    public class ArticleController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
