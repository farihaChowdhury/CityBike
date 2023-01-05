using CityBike.Data;
using Microsoft.EntityFrameworkCore;

namespace CityBike.Services
{
    public interface IBikeStationService
    {
        List<BikeStation> GetAllBikeStations();
    }

    public class BikeStationService: IBikeStationService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BikeStationService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<BikeStation> GetAllBikeStations()
        {
            return _unitOfWork.BikeStationRepository.Get().OrderBy(e => e.Name).ToList();
        }
    }
}
