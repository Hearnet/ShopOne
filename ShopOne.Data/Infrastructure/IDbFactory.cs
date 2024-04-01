using System;

namespace ShopOne.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopOneDbContext Init();
    }
}
