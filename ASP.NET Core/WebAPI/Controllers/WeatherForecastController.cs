using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

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
    public IEnumerable<WeatherForecast> Get([FromQuery] WeatherRequest weatherRequest)
    {
        
        Console.WriteLine(weatherRequest.TempLimit);

        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

public class WeatherRequest
{
    public int TempLimit { get; set; }
    public string? Summary { get; set; }

    public static bool TryParse(string s, out WeatherRequest result)
    {
        
        Console.WriteLine("this is getting called");

        if (s is null)
        {
            result = default;
            return false;
        }

        result = new WeatherRequest { TempLimit = Convert.ToInt32(s) };
        return true;
    }
}
