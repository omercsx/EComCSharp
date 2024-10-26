using Microsoft.AspNetCore.Mvc;

namespace EComCSharp.Controllers;

public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
