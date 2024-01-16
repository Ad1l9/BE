using Be.Areas.Admin.ViewModel.Position;
using Be.DAL;
using Be.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Be.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PositionController : Controller
    {
        private readonly AppDbContext _context;

        public PositionController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Position> positions = await _context.Positions.ToListAsync();
            return View(positions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreatePositionVm vm)
        {
            if(!ModelState.IsValid)
            {
                return View(vm);
            }
            bool isExist= await _context.Positions.AnyAsync(p=>p.Name==vm.Name);
            if (isExist)
            {
                ModelState.AddModelError("Name", "This Position is already exist");
                return View(vm);
            }
            Position position = new()
            {
                Name = vm.Name
            };
            await _context.Positions.AddAsync(position);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            if(id<=0) return BadRequest();
            Position existed = await _context.Positions.FirstOrDefaultAsync(p => p.Id == id);
            if(existed is null) return NotFound();

            return View(existed);
        }
    }
}
