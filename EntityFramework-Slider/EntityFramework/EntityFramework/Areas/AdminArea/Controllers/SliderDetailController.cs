using EntityFramework.Data;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderDetailController : Controller
    {
        private readonly AppDbContext _context;

        public SliderDetailController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            SliderDetail sliderDetail = _context.SliderDetails.Where(m => !m.IsDeleted).FirstOrDefault();
            return View(sliderDetail); 
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
