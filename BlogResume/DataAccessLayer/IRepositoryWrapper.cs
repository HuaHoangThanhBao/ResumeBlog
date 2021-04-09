
namespace DataAccessLayer
{
    public interface IRepositoryWrapper
    {
        IBaiVietRepository BaiViet { get; }
        IChuDeRepository ChuDe { get; }
        void Save();
    }
}
