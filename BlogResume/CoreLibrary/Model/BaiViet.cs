using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreLibrary.Model
{
    [Table("bai_viet")]
    public class BaiViet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BaiVietID { get; set; }

        [Required(ErrorMessage = "ChuDeID is required")]
        //Tập khóa ngoại
        [ForeignKey(nameof(ChuDe))]
        public int ChuDeID { get; set; }
        public ChuDe ChuDe { get; set; }

        [Required(ErrorMessage = "Tieu de is required")]
        [StringLength(50, ErrorMessage = "Tieu de can't be longer than 50 characters")]
        public string TieuDe { get; set; }

        [Required(ErrorMessage = "Mo ta is required")]
        [StringLength(25, ErrorMessage = "Mo ta can't be longer than 25 characters")]
        public string MoTa { get; set; }

        [Required(ErrorMessage = "Noi dung is required")]
        public string NoiDung { get; set; }

        [Required(ErrorMessage = "Ngay dang is required")]
        public DateTime NgayDang { get; set; }

        [Required(ErrorMessage = "HinhAnh is required")]
        public string HinhAnh { get; set; }

        [DefaultValue(false)]
        public bool TinhTrang { get; set; }
    }
}
