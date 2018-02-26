using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MathWizardForm.Models;

namespace MathWizardForm.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"]="This is the message";
            return View("MathForm");
        }

        [HttpGet]
        public IActionResult MathForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MathForm(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(userResponse);
                return View("UserResponse", userResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}
