namespace RestService
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class RestService<TEntity, TKey> : IRestService<TEntity, TKey>
    {
        public readonly string Url;
        public readonly string GetByKey;
        public RestService(string url, string getByKey = "/")
        {
            Url = url;
            GetByKey = getByKey;
        }

        public virtual async Task AsyncDelete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task AsyncDelete(TKey id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> AsyncGet(TKey id)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(Url + GetByKey + id);
                var entity = JsonConvert.DeserializeObject<TEntity>(json);
                return entity;
            }
        }

        public virtual async Task<IEnumerable<TEntity>> AsyncGetAll()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(Url);
                var entity = JsonConvert.DeserializeObject<IEnumerable<TEntity>>(json);
                return entity;
            }
        }

        public virtual async Task AsyncInsert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task AsyncUpdate(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TKey id)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Get(TKey id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }

}
