using CityBike.Data;
using Microsoft.EntityFrameworkCore;

namespace CityBike.Services
{
    public interface IUnitOfWork
    {
        IRepository<BikeStation> BikeStationRepository { get; }
        IRepository<Journey> JourneyRepository { get; }
        void SaveChanges();
        void Dispose();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityBikeContext _dbContext;

        #region Repositories
        public IRepository<BikeStation> BikeStationRepository =>
           new Repository<BikeStation>(_dbContext);
        public IRepository<Journey> JourneyRepository =>
           new Repository<Journey>(_dbContext);
        #endregion

        public UnitOfWork(CityBikeContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
