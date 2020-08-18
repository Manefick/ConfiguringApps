using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new Dictionary<string, string> {["Message"]= "This is the index action"});
        }
    }
}
