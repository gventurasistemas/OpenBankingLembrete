using RND.OpenBanking.Lembrete.Data;
using RND.OpenBanking.Lembrete.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RND.OpenBanking.Lembrete.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly Context _Context;
        public BaseRepository(Context Context)
        {
            _Context = Context;
        }
        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
            _Context.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            _Context.Set<TEntity>().Update(entity);
            _Context.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            _Context.Remove(entity);
            _Context.SaveChanges();
        }
        public TEntity GetId(int id)
        {
            return _Context.Set<TEntity>().Find(id);
        }

        public TEntity GetString(string text)
        {
            return _Context.Set<TEntity>().Find(text);
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }
        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}
