using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class DashboardController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
