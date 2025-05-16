using Lexicon_Inlamning_01.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Lexicon_Inlamning_01.Web.Models;

namespace Lexicon_Inlamning_01.Web.Controllers;

public class RunningShoesController : Controller
{
    static RunningShoeService shoeServíce = new RunningShoeService();

    [HttpGet("")]
    public IActionResult Index()
    {
        var model = shoeServíce.GetAll();
        return View(model);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(RunningShoe runningShoe)
    {
        if (!ModelState.IsValid)
            return View();

        shoeServíce.Add(runningShoe);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var model = shoeServíce.GetById(id);
        return View(model);
    }
}
