namespace Dottor.BlazorApp.Shared;

using System;
using System.Threading.Tasks;

public interface IWeatherForecastService
{
    Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
}
