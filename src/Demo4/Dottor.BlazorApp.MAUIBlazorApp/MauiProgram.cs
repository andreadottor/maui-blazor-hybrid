namespace Dottor.BlazorApp.MAUIBlazorApp
{
    using Dottor.BlazorApp.MAUIBlazorApp.Services;
    using Dottor.BlazorApp.Shared;
    using Microsoft.AspNetCore.Components.WebView.Maui;
    using Microsoft.Extensions.Logging;

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
            builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IWeatherForecastService, WeatherForecastService>();
            builder.Services.AddSingleton<INotificationService, NotificationService>();

            return builder.Build();
        }
    }
}