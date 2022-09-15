namespace Dottor.BlazorApp.Client.Services;

using Dottor.BlazorApp.Shared;
using System;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class WeatherForecastService : IWeatherForecastService
{
    private readonly HttpClient _httpClient;

    public WeatherForecastService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    {
        return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
