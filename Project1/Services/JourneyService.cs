using CityBike.Data;

namespace CityBike.Services
{
    public interface IJourneyService
    {
        List<Journey> GetAllJourneys();
    }
    public class JourneyService : IJourneyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public JourneyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<Journey> GetAllJourneys()
        {
            return _unitOfWork.JourneyRepository.Get().ToList();
        }
    }
}
