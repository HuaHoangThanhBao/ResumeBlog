using CoreLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBaiVietRepository
    {
        Task<IEnumerable<BaiViet>> GetAllBaiVietsAsync();
        Task<BaiViet> GetBaiVietByIdAsync(int baiVietID);
        void AddBaiViet(int idchude, string tieude, string mota, string noidung, string hinhAnh);
        void DeleteBaiViet(BaiViet bv);
    }
}
