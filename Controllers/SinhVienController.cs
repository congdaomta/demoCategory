using demoCatalogue.Data;
using demoCatalogue.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace demoCatalogue.Controllers
{
    public class SinhVienController : Controller
    {
        private readonly DemoContext _context;

        public SinhVienController(DemoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> ListSinhVien()
        {
            return View(await _context.SinhVien.ToListAsync());
        }

        [HttpGet]
        public IActionResult CreateSV()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSV(SinhVien sv)
        {
            if(ModelState.IsValid){
                _context.Add(sv);
                await _context.SaveChangesAsync();
                return RedirectToAction("ListSinhVien");
            }
            return View(sv);
        }
    }
}