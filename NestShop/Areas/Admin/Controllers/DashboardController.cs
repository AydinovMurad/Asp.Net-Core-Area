using Microsoft.AspNetCore.Mvc;

namespace NestShop.Areas.Admin.Controllers;
[Area("Admin")]

public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
