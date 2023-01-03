using CityBike.Data;
using System.Web.Http;

namespace Project1.Controllers
{
    [RoutePrefix("bikestation")]
    public class BikeStationController : ApiController
    {
        private readonly ILogger<BikeStationController> _logger;
        private readonly CityBikeContext _context;


        public BikeStationController(ILogger<BikeStationController> logger, CityBikeContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("GetAllBikeStations")]
        public List<BikeStation> GetAllBikeStations()
        {
            return _context.BikeStations.OrderBy(e=> e.Name).ToList();
        }
    }
}