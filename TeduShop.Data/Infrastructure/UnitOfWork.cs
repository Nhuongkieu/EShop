using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactoty dbFactoty;
        private TeduShopDbContext dbContext;
        public UnitOfWork(IDbFactoty dbFactoty)
        {
            this.dbFactoty = dbFactoty;
        }
        public TeduShopDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactoty.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
