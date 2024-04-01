using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOne.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopOneDbContext dbContext;

        public ShopOneDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopOneDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
