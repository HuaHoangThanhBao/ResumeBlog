using CoreLibrary.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreLibrary
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<ChuDe> ChuDes { get; set; }
        public DbSet<BaiViet> BaiViets { get; set; }
    }
}
