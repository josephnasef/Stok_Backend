using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Abstraction
{
    public interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        IQueryable<TEntity> GetAllQurAsync();
        List<TEntity> GetAllBind();
        TEntity Add(TEntity entity);
        Task<TEntity> AddAsync(TEntity entity);
        TEntity GetBy(params object[] Id);
        Task<TEntity> GetByAsync(params object[] Id);
        TEntity Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        TEntity Remove(TEntity entity);
        Task<TEntity> RemoveAsync(params object[] Id);
        TEntity Remove(params object[] Id);
    }
}
