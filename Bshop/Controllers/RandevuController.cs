using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Bshop.Data;
using Bshop.Models;
using Bshop.ViewModelleri;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace Bshop.Controllers
{
    public class RandevuController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RandevuController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var randevular = await _context.Randevular
                .Include(r => r.Salon) // Salon bilgisi
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Calisan) // Çalışan bilgisi
                .Include(r => r.CalisanHizmet)
                    .ThenInclude(ch => ch.Hizmet) // Hizmet bilgisi
                .ToListAsync();

            return View(randevular);
        }









        
    }
}
