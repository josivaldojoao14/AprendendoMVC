using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraTentativa.Controllers
{
    public class ContactController : Controller
    {
        [Route("/contact")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
