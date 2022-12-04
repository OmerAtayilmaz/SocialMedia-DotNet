using System.Diagnostics;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using VisualForm.Models;
using VisualForm.Services;

namespace VisualForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("/")]
    public IActionResult Index()
    {
        ViewData["postList"]=UserService.getUserPosts().Result;
        ViewData["userList"]=UserService.getUserData().Result;

        return View();
    }
    [HttpGet]
    [Route("/friends")]
    public IActionResult Friends()
    {
        ViewData["userList"]=UserService.getUserData().Result;
        return View("Friends");
    }

   [HttpGet]
   [Route("/friends/detail/{id:int}")]
    public IActionResult FriendDetail(int id)
    {
        ViewData["userDetail"] = UserService.getUserById(id).Result;
        Console.WriteLine(UserService.getUserById(id).Result.Email);
        return View("FriendDetails");
    }

    [HttpGet]
    [Route("/messages")]
    public IActionResult MessagesPage()
    {
        return View("Messages");
    }

    [HttpGet]
    [Route("/my-profile")]
    public IActionResult Profile()
    {
        return View("Profile");
    }

    [HttpGet]
    [Route("/my-settings")]
    public IActionResult Settings()
    {
        return View("Settings");
    }
    [HttpGet]
    [Route("/privacy-policy")]
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