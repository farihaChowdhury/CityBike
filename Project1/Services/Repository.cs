using CityBike.Data;
using Microsoft.EntityFrameworkCore;

namespace CityBike.Services
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get();
        T GetByID(object id);
        void Insert(T entity);
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly CityBikeContext _dbContext;
        private DbSet<T> _dbSet;
        public Repository(CityBikeContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual IQueryable<T> Get()
        {
            return _dbSet;
        }

        public virtual T GetByID(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        //public virtual void Delete(object id)
        //{
        //    T entityToDelete = _dbSet.Find(id);
        //    Delete(entityToDelete);
        //}

        //public virtual void Delete(T entityToDelete)
        //{
        //    if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        //    {
        //        _dbSet.Attach(entityToDelete);
        //    }
        //    _dbSet.Remove(entityToDelete);
        //}

        //public virtual void Update(T entityToUpdate)
        //{
        //    _dbSet.Attach(entityToUpdate);
        //    _dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        //}
    }
}
