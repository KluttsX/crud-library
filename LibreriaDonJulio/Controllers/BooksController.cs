using LibreriaDonJulio.DataContext;
using LibreriaDonJulio.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaDonJulio.Controllers
{
    public class BooksController : Controller
    {
        public readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _context.Books.Add(book);
            await _context.SaveChangesAsync();

            TempData["Sucess"] = "Book Registered Successfully";

            return RedirectToAction(nameof(Create));
        }
    }
}
