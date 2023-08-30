namespace CityBike.Services
{
    using CityBike.Data;
    using CityBike.ViewModels;
    using Microsoft.EntityFrameworkCore;

    public interface IBikeStationRepository : IRepository<BikeStation>
    {
        BikeStationViewModel GetBikeStationDetailsById(int bikeStationId);
    }

    public class BikeStationRepository : Repository<BikeStation>, IBikeStationRepository
    {
        private readonly CityBikeContext _context;

        public BikeStationRepository(CityBikeContext context)
            : base(context)
        {
            this._context = context;
        }

        public BikeStationViewModel GetBikeStationDetailsById(int bikeStationId)
        {
            var query = "SELECT BS.Name AS StationName, BS.Address, (SELECT COUNT(*) FROM Journey J1 WHERE J1.DepartureStationId = BS.ID) AS TotalJourneysStarting, (SELECT COUNT(*) FROM Journey J2 WHERE J2.ReturnStationId = BS.ID) AS TotalJourneysEnding FROM BikeStation BS WHERE BS.ID = {0};";

            return _context.Set<BikeStationViewModel>()
                           .FromSqlRaw(query, bikeStationId)
                           .FirstOrDefault();
        }
    }
}
