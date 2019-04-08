using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyModel.Models;

namespace DojoSurveyModel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost("result")]
    public IActionResult Create(Survey MySurvey)
    {
      if(ModelState.IsValid)
        return RedirectToAction("Result");
      
      else
        return View("Index");
    }

    [HttpGet("success")]
    public IActionResult Result()
    {
      return View("Results");
    }

  }
}
