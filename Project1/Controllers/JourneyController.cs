using CityBike.Data;
using CityBike.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityBike.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JourneyController: ControllerBase
    {
        private readonly IJourneyService _journeyService;

        public JourneyController(IJourneyService journeyService)
        {
            _journeyService = journeyService;
        }

        [HttpGet]
        [Route("GetAllJourneys")]
        public List<Journey> GetAllJourneys()
        {
            var journeys = _journeyService.GetAllJourneys();
            return journeys;
        }
    }
}
