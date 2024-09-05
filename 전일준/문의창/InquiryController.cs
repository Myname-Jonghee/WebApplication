using Microsoft.AspNetCore.Mvc;
using Ptoject_battery03.Data;
using Ptoject_battery03.Models;
using System.Threading.Tasks;

namespace Ptoject_battery03.Controllers
{
    public class InquiryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InquiryController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Inquiry/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Inquiry/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Inquiry inquiry)
        {
            if (ModelState.IsValid)
            {
                inquiry.CreatedAt = DateTime.Now;
                _context.Add(inquiry);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "문의가 완료되었습니다.";
                return RedirectToAction(nameof(Create));
            }
            return View(inquiry);
        }
    }
}
