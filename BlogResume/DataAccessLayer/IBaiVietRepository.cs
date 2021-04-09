using CoreLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IBaiVietRepository
    {
        Task<IEnumerable<BaiViet>> GetAllBaiVietsAsync();
    }
}
