using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab.Controllers
{
    public class TVShowsController : Controller
    {
        public IActionResult Shows()
        {
            return View();
        }
    }
}
