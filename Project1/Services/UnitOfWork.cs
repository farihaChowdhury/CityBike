using CityBike.Data;

namespace CityBike.Services
{
    public interface IUnitOfWork
    {
        IBikeStationRepository BikeStations { get; }

        IRepository<Journey> JourneyRepository { get; }
        
        void SaveChanges();
        
        void Dispose();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly CityBikeContext _dbContext;

        #region Repositories
        private IBikeStationRepository _bikeStationRepository;
        private IRepository<Journey> _journeyRepository;
        #endregion

        public UnitOfWork(CityBikeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IBikeStationRepository BikeStations
        {
            get
            {
                return _bikeStationRepository ??= new BikeStationRepository(_dbContext);
            }
        }

        public IRepository<Journey> JourneyRepository
        {
            get
            {
                if (_journeyRepository == null)
                {
                    _journeyRepository = new Repository<Journey>(_dbContext);
                }

                return _journeyRepository;
            }
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
