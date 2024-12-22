using Bshop.Data;
using Microsoft.AspNetCore.Mvc;

namespace Bshop.Controllers
{
    public class HizmetController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HizmetController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hizmet
        public IActionResult Index()
        {
            var hizmetler = _context.Hizmets.ToList(); // Veritabanındaki tüm hizmetleri alır.
            return View(hizmetler); // View'a gönderir.
        }
    }
}
