using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("/")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/Privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet("/Numbers")]
    public IActionResult Numbers()
    {
        return View();
    }

    [HttpGet("/User")]
    public IActionResult User()
    {
        User newUser = new User()
        {
            FirstName = "James",
            LastName = "Remer"
        };
        return View(newUser);
    }


[HttpGet("/Users")]
public IActionResult Users()
{
    User James = new User()
        {
            FirstName = "James",
            LastName = "Remer"
        };
    User Aimee = new User()
        {
            FirstName = "Aimee",
            LastName = "Gottesman"
        };
    User Ling = new User()
        {
            FirstName = "Ling",
            LastName = "Xiao"
        };
    User Julie = new User()
        {
            FirstName = "Julie",
            LastName = "Krug"
        };

    List<User> users = new List<User>(){James, Aimee, Ling, Julie};

    return View(users);
}



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
