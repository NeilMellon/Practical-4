using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;


namespace SMS.Web.Controllers;


public class HomeController : Controller
{
    public IActionResult Index()
    {
        return Content("Web Development");
    }

    public IActionResult About()
    {
        var formed = new DateTime(2020,01,01);

        var about = new AboutViewModel {
            Formed = formed,
            Company = "Cocacola"          
        };
        
        return View(about);
    }

}



    
    

