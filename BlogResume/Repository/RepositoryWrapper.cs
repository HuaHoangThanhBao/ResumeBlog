using CoreLibrary;
using DataAccessLayer;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IBaiVietRepository _baiViet;
        private IChuDeRepository _chuDe;

        public IBaiVietRepository BaiViet
        {
            get
            {
                if (_baiViet == null)
                {
                    _baiViet = new BaiVietRepository(_repoContext);
                }
                return _baiViet;
            }
        }
        public IChuDeRepository ChuDe
        {
            get
            {
                if (_chuDe == null)
                {
                    _chuDe = new ChuDeRepository(_repoContext);
                }
                return _chuDe;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
