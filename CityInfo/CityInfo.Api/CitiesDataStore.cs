using CityInfo.Api.Models;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataStore Instance { get; set; } = new CitiesDataStore();
        public CitiesDataStore() 
        {
            Cities = new List<CityDto>() 
            {
            new CityDto { Id = 1, Name = "New York", Country = "USA" },
            new CityDto { Id = 2, Name = "London", Country = "UK" },
            new CityDto { Id = 3, Name = "Paris", Country = "France" },
            new CityDto { Id = 4, Name = "Tokyo", Country = "Japan" },
            new CityDto { Id = 5, Name = "Sydney", Country = "Australia" }
            };
        }
    }
}
