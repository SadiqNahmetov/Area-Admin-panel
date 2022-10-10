using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
        // GET: DashboardController
        public IActionResult Index()
        {
            return View();
        }

    }
}
