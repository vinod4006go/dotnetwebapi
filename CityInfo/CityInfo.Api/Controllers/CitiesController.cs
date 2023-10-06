using CityInfo.Api.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CityInfo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        // GET: api/<CitiesController>
        [HttpGet]
        public ActionResult<IEnumerable<CityDto>> Get()
        {
            return Ok(CitiesDataStore.Instance.Cities);
        }

        // GET api/<CitiesController>/5
        [HttpGet("{id}")]
        public ActionResult<CityDto> Get(int id)
        {
            var city = CitiesDataStore.Instance.Cities.FirstOrDefault(x => x.Id == id);
            if(city ==null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
