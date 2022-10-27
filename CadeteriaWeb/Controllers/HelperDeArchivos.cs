using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CadeteriaWeb.Controllers
{
    [Route("Helper")]
    public class HelperDeArchivos : Controller
    {
        private readonly ILogger<HelperDeArchivos> _logger;

        public HelperDeArchivos(ILogger<HelperDeArchivos> logger)
        {
            _logger = logger;
        }

        public IActionResult HelperDeArchivos()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}