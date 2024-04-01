using ShopOne.Data.Infrastructure;
using ShopOne.Model.Models;

namespace ShopOne.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
