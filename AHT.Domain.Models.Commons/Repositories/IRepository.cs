using AHT.Domain.Commons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AHT.Domain.Commons.Repositories
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity, in TPrimaryKey> : IRepository where TEntity : IAggregateRoot
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(TPrimaryKey key);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TPrimaryKey id);
    }
}
