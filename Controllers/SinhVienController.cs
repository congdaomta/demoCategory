using demoCatalogue.Data;
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
        public async Task<IActionResult> ListSinhVien()
        {
            return View(await _context.SinhVien.ToListAsync());
        }
    }
}