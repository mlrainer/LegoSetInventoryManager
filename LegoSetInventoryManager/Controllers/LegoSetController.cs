using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using LegoSetInventoryManager.Demo.Data;

namespace DotNetSix.Demo.Controllers
{
    public class LegoSetController : Controller
    {
        private readonly AppDBContext _context;
        private readonly IConfiguration _config;

        public LegoSetController(AppDBContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }
        // GET: Papers
        public async Task<IActionResult> Index()
        {
            var appDBContext = _context.SetDetails.Include(b => b.SetNumber);
            return View(await appDBContext.ToListAsync());
        }
    }
}