using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConfiguringApps.Infrastructure;

namespace ConfiguringApps.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService uptime;
        public HomeController(UptimeService up) => uptime = up;
        public ViewResult Index()
        {
            return View(new Dictionary<string, string> {["Message"]= "This is the index action", ["Uptime"]=$"{uptime.Uptime}ms"});
        }
    }
}
