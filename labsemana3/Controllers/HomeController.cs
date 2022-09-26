using labsemana3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace labsemana3.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var text = new HelloModel();
            text.Texto = " Hello world MVC";
            return View(text);
        }
    }
}
