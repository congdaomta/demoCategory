using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demoCatalogue.Models
{
    [Table("GiaoVien")]
    public class GiaoVien
    {
        [Display(Name="Tên")]
        public string TenGiaoVien{get;set;}

        [Display(Name="Tuổi")]
        public int TuoiGiaoVien{get;set;}

        [Key]
        public string MaGiaoVien{get;set;}

        [Display(Name="Khoa làm việc")]
        public string KhoaGiaoVien{get;set;}
    }
}