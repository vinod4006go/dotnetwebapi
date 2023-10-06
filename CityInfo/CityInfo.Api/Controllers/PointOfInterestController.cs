using CityInfo.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [Route("api/cities/{cityId}/pointOfinterest")]
    [ApiController]
    public class PointOfInterestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<PointOfInterestDto>> Get(int cityId)
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null) { return NotFound(); }

            var pointOfInterests = city.PointsOfInterest;
            return Ok(pointOfInterests);
        }

        [HttpGet("/id")]
        public ActionResult<PointOfInterestDto> Get(int cityId, int id)
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null) { return NotFound(); }

            var pointOfInterests = city.PointsOfInterest;
            var pointOfInterest = pointOfInterests.FirstOrDefault(x => x.Id == id);
            if (pointOfInterest == null) { return NotFound(); }
            return Ok(pointOfInterest);
        }
    }
}
