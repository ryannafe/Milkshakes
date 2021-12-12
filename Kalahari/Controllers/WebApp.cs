using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalahari.Controllers
{
    public class WebApp : Controller
    {
        public IActionResult Application()
        {
            return View();
        }
    }

}
