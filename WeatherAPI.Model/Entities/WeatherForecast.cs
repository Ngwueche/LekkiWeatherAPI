using WeatherAPI.Model.Entities;

namespace WeatherAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int Id { get; set; }
        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
        public string AddById { get; set; }

        public ApplicationUser AddedBy { get; set; }

    }
}
