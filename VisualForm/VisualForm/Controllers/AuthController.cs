using Microsoft.AspNetCore.Mvc;

namespace VisualForm.Controllers;

public class AuthController:Controller
{
   
    [HttpGet]
    [Route(("/login"))]
    public IActionResult LoginPanel()
    {
        return View("LoginPanel");
    }
    
    [HttpGet]
    [Route("/sign-up")]
    public IActionResult RegisterPanel()
    {
        return View("RegisterPanel");
    }
}