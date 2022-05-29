using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using yeeflix_project.Models;

namespace yeeflix_project.Controllers;

public class MovieController : Controller
{
    private readonly ILogger<MovieController> _logger;

    public MovieController(ILogger<MovieController> logger)
    {
        _logger = logger;
    }
    
    public IActionResult All()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
