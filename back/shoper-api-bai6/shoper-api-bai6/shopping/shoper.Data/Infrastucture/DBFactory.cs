using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Data.Infrastucture
{
    public class DBFactory : Disposable, IDbFactory
    {
        ShoperDbContext dbContext;
        public ShoperDbContext Init()
        {
            return dbContext ?? (dbContext = new ShoperDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
