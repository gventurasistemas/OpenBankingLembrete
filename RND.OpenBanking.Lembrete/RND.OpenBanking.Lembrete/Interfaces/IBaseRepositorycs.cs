using System;
using System.Collections.Generic;

namespace RND.OpenBanking.Lembrete.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetId(int id);
        TEntity GetString(string text);
        IEnumerable<TEntity> GetAll();
    }
}
