using Microsoft.AspNetCore.Identity;

namespace WeatherAPI.Model.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<WeatherForecast> Forecasts { get; set; } = new HashSet<WeatherForecast>();
    }
}
