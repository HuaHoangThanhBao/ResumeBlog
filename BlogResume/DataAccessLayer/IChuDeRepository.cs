using CoreLibrary.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IChuDeRepository
    {
        Task<IEnumerable<ChuDe>> GetAllChuDesAsync();
    }
}
