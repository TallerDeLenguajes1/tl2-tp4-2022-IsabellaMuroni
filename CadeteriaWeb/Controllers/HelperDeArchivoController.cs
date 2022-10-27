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
    public class HelperDeArchivoController : Controller
    {
        private readonly ILogger<HelperDeArchivoController> _logger;

        public HelperDeArchivoController(ILogger<HelperDeArchivoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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