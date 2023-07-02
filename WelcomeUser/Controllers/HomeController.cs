using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WelcomeUser.Models;

namespace WelcomeUser.Controllers;

public class HomeController : Controller
{
    [HttpGet]
    public ViewResult Index()
    {
        return View();
    }

    [HttpPost]
    public ViewResult Index (UserResponse userResponse) {
        if(ModelState.IsValid)
        {
            Repository.AddResponse(userResponse);
            return View("Thanks", userResponse);
        }
        else
        {
            return View();
        }
    }

    public ViewResult VotingList()
    {
        return View(Repository.Responses.Where(m=>m.IsAdult==true));
    }
}
