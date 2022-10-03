using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Controllers
{
    public class CoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}