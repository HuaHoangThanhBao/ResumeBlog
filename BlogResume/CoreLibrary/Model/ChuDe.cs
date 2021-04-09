using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreLibrary.Model
{
    [Table("chu_de")]
    public class ChuDe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChuDeID { get; set; }

        [Required(ErrorMessage = "Ten chu de is required")]
        [StringLength(50, ErrorMessage = "Ten chu de can't be longer than 50 characters")]
        public string TenChuDe { get; set; }

        [DefaultValue(false)]
        public bool TinhTrang { get; set; }
    }
}
