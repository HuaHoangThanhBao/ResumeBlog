﻿using CoreLibrary;
using CoreLibrary.Model;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository
{
    public class BaiVietRepository : RepositoryBase<BaiViet>, IBaiVietRepository
    {
        public BaiVietRepository(RepositoryContext repositoryContext)
               : base(repositoryContext)
        {
        }

        //Lấy danh sách các tác giả không bị xóa
        public async Task<IEnumerable<BaiViet>> GetAllBaiVietsAsync()
        {
            return await FindAll()
                .Where(ow => !ow.TinhTrang)
                .Include(ow => ow.ChuDe)
                .OrderBy(ow => ow.TieuDe)
                .ToListAsync();
        }

        public async Task<BaiViet> GetBaiVietByIdAsync(int baiVietID)
        {
            return await FindByCondition(baiViet => baiViet.BaiVietID.Equals(baiVietID))
                .Include(cd => cd.ChuDe)
                .FirstOrDefaultAsync();
        }
    }
}
