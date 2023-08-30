namespace CityBike.Services
{
    using CityBike.Data;
    using CityBike.ViewModels;

    public interface IBikeStationService
    {
        List<BikeStation> GetAllBikeStations();

        BikeStationViewModel GetBikeStationDetailsById(int bikeStationId);
    }

    public class BikeStationService : IBikeStationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BikeStationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<BikeStation> GetAllBikeStations()
        {
            return _unitOfWork.BikeStations.Get().OrderBy(e => e.Name).ToList();
        }

        public BikeStationViewModel GetBikeStationDetailsById(int bikeStationId)
        {
            return _unitOfWork.BikeStations.GetBikeStationDetailsById(bikeStationId);
        }
    }
}
