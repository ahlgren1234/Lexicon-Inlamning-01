using Lexicon_Inlamning_01.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Lexicon_Inlamning_01.Web.Models;
using Lexicon_Inlamning_01.Web.Views.RunningShoes;

namespace Lexicon_Inlamning_01.Web.Controllers;

public class RunningShoesController(IRunningShoeService service) : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        var model = service.GetAll();

        var viewModel = new IndexVM()
        {
            RunningShoeVMs = model
                .Select(e => new IndexVM.RunningShoeVM()
                {
                    Id = e.Id,
                    Name = e.Name,
                    Price = e.Price,
                })
                .ToArray()
        };
        
        return View(viewModel);
    }

    [HttpGet("create")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost("create")]
    public IActionResult Create(RunningShoe shoe)
    {
        if (!ModelState.IsValid)
            return View();

        service.Add(shoe);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet("details/{id}")]
    public IActionResult Details(int id)
    {
        var model = service.GetById(id);
        return View(model);
    }
}
