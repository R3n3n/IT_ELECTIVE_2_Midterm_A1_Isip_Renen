using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Greet"] = "Hello there! Welcome to My Portfolio!";
        ViewData["Intro"] = "Hello there! I'm still currently a 3rd year BSIT student at Lyceum of Alabang. I enjoy various fields such as being a database analyst, web development, and cybersecurity. I believe that being flexible in a field such as IT can greatly contribute in solving real-world problems.";
        ViewData["Aspiring"] = "Aspiring Data Analyst";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult About()
    {
        ViewData["Status"] = "I'm not currently a 3rd year BSIT student at Lyceum of Alabang. Throughout my journey, I began to develop my interests in fields such as database, web development, and cybersecurity.";
        ViewData["More"] = "While ultimately my goal is to become a professional in the Cybersecurity field where I can still keep learning to improve my technical skills since we are in a field where learning doesn't stop as technology keeps on evolving. During my free time, I enjoy working on improving my skills in different programming languages and working on my portfolio like the one I have created right now.";
        ViewData["Program"] = "Bachelor of Science in Information Technology";
        ViewData["Goal"] = "My goal is to become a professional a data analyst I aspire to continously improve my technical skills while contributing to projects that create meaningful experiences for users.";
        return View();
    }

    public IActionResult Skills()
    {
        return View();
    }

    public IActionResult Projects()
    {
        ViewData["FirstDesc"] = "A desktop application for managing parking slots.";
        ViewData["SecondDesc"] = "A system that focuses on the transaction of the tickets between the costumers, the organizers of the concerts, and the organizer of the place.";
        ViewData["ThirdDesc"] = "A desktop application that calculates loans and verifies if people are qualified for one.";
        return View();
    }

    public IActionResult Contacts()
    {
        ViewData["Email"] = "isiprenen911@gmail.com";
        ViewData["MobileNum"] = "+63 956 558 0578";
        ViewData["Github"] = "github.com/R3n3n";
        ViewData["FB"] = "facebook.com/renen.isip";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}