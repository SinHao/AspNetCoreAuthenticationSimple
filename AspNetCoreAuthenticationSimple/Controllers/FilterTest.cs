using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreAuthenticationSimple.Controllers
{
    public class FilterTest : Controller
    {
        [Filters.Authorization]
        public IActionResult Index()
        {
            return View();
        }

        [Filters.Resorce]
        public IActionResult ResourceFileterTest()
        {
            return Ok();
        }

        [Filters.Action]
        public IActionResult ActionFilterTest()
        {
            return Ok();
        }

        [Filters.Result]
        public IActionResult ResultFilterTest()
        {
            return Ok();
        }
    }
}
