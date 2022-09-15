namespace Dottor.BlazorApp.MAUIBlazorApp
{
    using Dottor.BlazorApp.MAUIBlazorApp.Data;
    using Dottor.BlazorApp.Shared;
    using Microsoft.AspNetCore.Components.WebView.Maui;

    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();

            return builder.Build();
        }
    }
}