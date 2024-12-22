using Bshop.Data;
using Bshop.Models;
using Bshop.ViewModelleri;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Bshop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        // **1. Kullanıcı Yönetimi**
        // GET: Admin/Index
        public IActionResult Index()
        {
            return View();
        }

        // Kullanıcıları Listeleme
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);
        }

        // GET: Admin/EditUser/5
        public async Task<IActionResult> EditUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new EditUserViewModel
            {
                Id = user.Id,
                FullName = user.FullName,
                Phone = user.Phone,
                Email = user.Email,
                Role = user.Role,
                Roles = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new SelectListItem
                {
                    Value = r.ToString(),
                    Text = r.ToString()
                })
            };

            return View(viewModel);
        }

        // POST: Admin/EditUser/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, EditUserViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var existingUser = await _context.Users.FindAsync(id);
                    if (existingUser == null)
                    {
                        return NotFound();
                    }

                    existingUser.FullName = model.FullName;
                    existingUser.Phone = model.Phone;
                    existingUser.Email = model.Email;
                    existingUser.Role = model.Role;

                    _context.Update(existingUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Users");
            }

            // Gerekli verileri tekrar yükleyin
            model.Roles = Enum.GetValues(typeof(UserRole)).Cast<UserRole>().Select(r => new SelectListItem
            {
                Value = r.ToString(),
                Text = r.ToString()
            });
            return View(model);
        }

        // Kullanıcı Silme
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Users));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }

        // **2. Salon Yönetimi**

        // Salonları Listeleme
        public async Task<IActionResult> Salons()
        {
            var salons = await _context.Salons.ToListAsync();
            return View(salons);
        }

        // Salon Ekleme
        public IActionResult CreateSalon()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSalon([Bind("Id,Name")] Salon salon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(salon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Salons));
            }
            return View(salon);
        }

        // Salon Düzenleme
        public async Task<IActionResult> EditSalon(int id)
        {
            var salon = await _context.Salons.FindAsync(id);
            if (salon == null)
            {
                return NotFound();
            }
            return View(salon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSalon(int id, [Bind("Id,Name")] Salon salon)
        {
            if (id != salon.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(salon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SalonExists(salon.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Salons));
            }
            return View(salon);
        }

        // Salon Silme
        public async Task<IActionResult> DeleteSalon(int id)
        {
            var salon = await _context.Salons.FindAsync(id);
            if (salon == null)
            {
                return NotFound();
            }

            return View(salon);
        }

        [HttpPost, ActionName("DeleteSalon")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteSalonConfirmed(int id)
        {
            var salon = await _context.Salons.FindAsync(id);
            if (salon != null)
            {
                _context.Salons.Remove(salon);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Salons));
        }

        private bool SalonExists(int id)
        {
            return _context.Salons.Any(s => s.Id == id);
        }

        // **3. Hizmet Yönetimi**

        // Hizmetleri Listeleme
        public async Task<IActionResult> Hizmets()
        {
            var hizmetler = await _context.Hizmets.ToListAsync();
            return View(hizmetler);
        }

        // Hizmet Ekleme
        public IActionResult CreateHizmet()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateHizmet([Bind("Id,Name,Description,DurationMinutes,Price,PhotoUrl")] Hizmet hizmet)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hizmet);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Hizmets));
            }
            return View(hizmet);
        }

        // Hizmet Düzenleme
        public async Task<IActionResult> EditHizmet(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet == null)
            {
                return NotFound();
            }
            return View(hizmet);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHizmet(int id, [Bind("Id,Name,Description,DurationMinutes,Price,PhotoUrl")] Hizmet hizmet)
        {
            if (id != hizmet.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hizmet);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HizmetExists(hizmet.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Hizmets));
            }
            return View(hizmet);
        }

        // Hizmet Silme
        public async Task<IActionResult> DeleteHizmet(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet == null)
            {
                return NotFound();
            }

            return View(hizmet);
        }

        [HttpPost, ActionName("DeleteHizmet")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteHizmetConfirmed(int id)
        {
            var hizmet = await _context.Hizmets.FindAsync(id);
            if (hizmet != null)
            {
                _context.Hizmets.Remove(hizmet);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Hizmets));
        }

        private bool HizmetExists(int id)
        {
            return _context.Hizmets.Any(h => h.Id == id);
        }
    }
}
