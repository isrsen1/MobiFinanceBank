using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobiFinanceBank.DAL.DbContexts.Interfaces
{
    /// <summary>
    /// Db context interface
    /// </summary>
    /// <seealso cref="IDisposable"/>
    public interface IDbContext: IDisposable
    {
        /// <summary>
        /// Save changes
        /// </summary>
        int SaveChanges();

        /// <summary>
        /// Save changes async
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();
        
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        DbEntityEntry Entry(object entity);
    }
}
