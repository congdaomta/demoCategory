using demoCatalogue.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace demoCatalogue.Controllers
{
    public class GiaoVienController : Controller
    {
        private readonly DemoContext _context;

        public GiaoVienController(DemoContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> ListGiaoVien()
        {
            return View(await _context.GiaoVien.ToListAsync());
        }
    }
}