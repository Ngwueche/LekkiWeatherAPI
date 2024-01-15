using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherAPI.Model.Entities;

namespace WeatherAPI.Data;

public class DbContextWeather : IdentityDbContext<ApplicationUser>
{
    public DbContextWeather(DbContextOptions<DbContextWeather> options) : base(options) { }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

}
