using CityBike.Data;
using CityBike.Services;
using System.Web.Http;

namespace Project1.Controllers
{
    [RoutePrefix("bikestation")]
    public class BikeStationController : ApiController
    {
        private readonly ILogger<BikeStationController> _logger;
        private readonly IBikeStationService _bikeStationService ;


        public BikeStationController(ILogger<BikeStationController> logger, IBikeStationService bikeStationService)
        {
            _logger = logger;
            _bikeStationService = bikeStationService;
        }

        [HttpGet]
        [Route("GetAllBikeStations")]
        public List<BikeStation> GetAllBikeStations()
        {
            return _bikeStationService.GetAllBikeStations();
        }
    }
}