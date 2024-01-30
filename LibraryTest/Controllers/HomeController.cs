using LibraryTest.DAL;
using LibraryTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LibraryTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryDatabaseContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, LibraryDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Book
        public async Task<IActionResult> Index()
        {
            var libraryDatabaseContext = _context.Book.Include(b => b.Author);
            return View(await libraryDatabaseContext.ToListAsync());
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
