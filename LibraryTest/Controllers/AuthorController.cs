using LibraryTest.DAL;
using LibraryTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryTest.Controllers
{
    public class AuthorController : Controller
    {
        private LibraryDatabaseContext _databaseContext;

        public AuthorController(LibraryDatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ViewResult Index()
        {
            return View(_databaseContext.Author.ToList());
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Author author)
        {
            try
            {
                _databaseContext.Add(author);
                await _databaseContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(author);
            }
        }
    }
}
