using BookShelf.model;
using Microsoft.AspNetCore.Mvc;

namespace BookShelf.Controllers
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
        private readonly bookData _db;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, bookData db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
       

        [HttpPost("storeData")]
        public void GetData(books b1)
        {
            _db.Add(b1);
            _db.SaveChanges();
        }
        [HttpGet("GetData")]
        public IEnumerable<books> GetData()
        {
            return _db.db;
        }
    }
}