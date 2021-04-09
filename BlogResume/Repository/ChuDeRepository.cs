using CoreLibrary;
using CoreLibrary.Model;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class ChuDeRepository : RepositoryBase<ChuDe>, IChuDeRepository
    {
        public ChuDeRepository(RepositoryContext repositoryContext)
               : base(repositoryContext)
        {
        }

        //Lấy danh sách các tác giả không bị xóa
        public async Task<IEnumerable<ChuDe>> GetAllChuDesAsync()
        {
            return await FindAll()
                .Where(ow => !ow.TinhTrang)
                .OrderBy(ow => ow.TenChuDe)
                .ToListAsync();
        }
    }
}
