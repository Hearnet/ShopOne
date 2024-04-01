using ShopOne.Data.Infrastructure;
using ShopOne.Model.Models;

namespace ShopOne.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }
    public class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
