using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestService
{
    public interface IRestService<TEntity, TKey>
    {
        Task AsyncDelete(TEntity entity);
        Task AsyncDelete(TKey id);
        Task<TEntity> AsyncGet(TKey id);
        Task<IEnumerable<TEntity>> AsyncGetAll();
        Task AsyncInsert(TEntity entity);
        Task AsyncUpdate(TEntity entity);
        void Delete(TEntity entity);
        void Delete(TKey id);
        TEntity Get(TKey id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}