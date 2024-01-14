using Microsoft.AspNetCore.Mvc;

namespace WeatherAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IActionResult Get()
        {
            return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray());
        }
        [HttpGet(Name = "get-forecast-by-Id/{id}")]
        public IActionResult Get(int id)
        {
            var query = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-18, 60),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            });
            var result = query.ToList().FirstOrDefault(x => x.Id == id);
            if (result == null) return NotFound("No record with the query string.");
            return Ok(result);
        }
        //[HttpPost(Name = "AddRecord")]
        //public IActionResult AddRecord([FromBody] WeatherForecast weatherForecast)
        //{
        //    var record = new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(7)),
        //        TemperatureC = Random.Shared.Next(-18, 30),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    };
        //    if (record == null) return BadRequest("Supply required field!");
        //    return Ok(record);
        //}

    }
}
