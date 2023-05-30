using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CV.Models;
namespace CV.Controllers;
[Area("CV")]
public class HomeController : Controller
{
    /*private readonly LoggerDummy<HomeController> _logger;
    public HomeController(LoggerDummy<HomeController> logger)
    {
        _logger = (LoggerDummy<HomeController>)logger;
    }*/
    public IActionResult Index()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        /*if(HttpContext.Response != null)
            _logger.LogError($"Error with the HTTP request {HttpContext.Request}. The response is: {HttpContext.Response}", HttpContext.Request, HttpContext.Response);
        else
            _logger.LogError($"Error with the {HttpContext.Request} request: ", HttpContext.Request, HttpContext.Response);*/
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
