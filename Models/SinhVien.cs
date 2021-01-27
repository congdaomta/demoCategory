using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoCatalogue.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Display(Name = "Tên")]
        public string TenSinhVien { get; set; }

        [Display(Name = "Tuổi")]
        public int TuoiSinhVien { get; set; }

        [Key]
        public string MaSinhVien { get; set; }
    }
}