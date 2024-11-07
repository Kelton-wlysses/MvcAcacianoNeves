using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcAcacianoNeves.Models;

namespace MvcAcacianoNeves.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        HomeModel home = new HomeModel();

        home.Nome = "Kelton Wlysses";
        home.Email = "kelton.wlysses@mail.com";

        return View(home);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
