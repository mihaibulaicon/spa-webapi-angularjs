using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomTests.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        RandomTestsContext dbContext;

        public RandomTestsContext Init()
        {
            return dbContext ?? (dbContext = new RandomTestsContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
