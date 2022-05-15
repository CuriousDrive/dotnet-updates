using WebAPI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<WeatherService>();

var app = builder.Build();

app.MapGet("/", (WeatherService weatherService) => 
    weatherService.GetWeatherForecast());

app.Run();
