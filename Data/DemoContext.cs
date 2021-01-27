using Microsoft.EntityFrameworkCore;
using demoCatalogue.Models;

namespace demoCatalogue.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext (DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public DbSet<SinhVien> SinhVien { get; set; }
        public DbSet<GiaoVien> GiaoVien {get;set;}
    }
}