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
             new CityDto
            {
                Id = 1,
                Name = "New York",
                Country = "USA",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto { Id = 1, Name = "Central Park", Description = "A large urban park in Manhattan." },
                    new PointOfInterestDto { Id = 2, Name = "Statue of Liberty", Description = "A famous symbol of freedom and democracy." }
                }
            },
            new CityDto
            {
                Id = 2,
                Name = "London",
                Country = "UK",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto { Id = 3, Name = "Big Ben", Description = "The iconic clock tower near the River Thames." },
                    new PointOfInterestDto { Id = 4, Name = "Buckingham Palace", Description = "The official residence of the monarch." }
                }
            },
            new CityDto
            {
                Id = 3,
                Name = "Paris",
                Country = "France",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto { Id = 5, Name = "Eiffel Tower", Description = "A famous wrought-iron tower." },
                    new PointOfInterestDto { Id = 6, Name = "Louvre Museum", Description = "Home to thousands of works of art." }
                }
            },
            new CityDto
            {
                Id = 4,
                Name = "Tokyo",
                Country = "Japan",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto { Id = 7, Name = "Tokyo Tower", Description = "An iconic communications and observation tower." },
                    new PointOfInterestDto { Id = 8, Name = "Shibuya Crossing", Description = "One of the busiest pedestrian crossings." }
                }
            },
            new CityDto
            {
                Id = 5,
                Name = "Sydney",
                Country = "Australia",
                PointsOfInterest = new List<PointOfInterestDto>
                {
                    new PointOfInterestDto { Id = 9, Name = "Sydney Opera House", Description = "A world-famous performing arts venue." },
                    new PointOfInterestDto { Id = 10, Name = "Bondi Beach", Description = "A popular beach for surfing and sunbathing." }
                }
            }
            };
        }
    }
}
