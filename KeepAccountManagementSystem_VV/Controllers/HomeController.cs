using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net.Mime;
using System.Runtime.InteropServices.JavaScript;
using System.Text.Encodings.Web;
using KeepAccountManagementSystem_VV.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KeepAccountManagementSystem_VV.Models;
using KeepAccountManagementSystem_VV.ViewModels;

namespace KeepAccountManagementSystem_VV.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IHomeService _homeService;

    public HomeController(ILogger<HomeController> logger,
        IHomeService homeService)
    {
        _logger = logger;
        _homeService = homeService;
    }

    public IActionResult Index()
    {
        KeepAccountViewModel showData = new KeepAccountViewModel();

        showData.index = _homeService.index();

        return View(showData);
    }

    public IActionResult Save(KeepAccount keepAccount)
    {
        _homeService.Create(keepAccount);

        return RedirectToAction("Index");
    }

    [HttpGet("api/records")]
    public IActionResult Privacy()
    {
        return Json(_homeService.index());
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}