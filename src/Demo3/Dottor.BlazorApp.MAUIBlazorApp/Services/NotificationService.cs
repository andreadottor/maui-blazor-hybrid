namespace Dottor.BlazorApp.MAUIBlazorApp.Services;

using Dottor.BlazorApp.Shared;
using System.Threading.Tasks;

internal class NotificationService : INotificationService
{
    public async Task ShowAlertAsync(string message)
    {
        await Application.Current.MainPage.DisplayAlert("Alert", message, "OK");
    }

    public async Task<bool> ShowConfirmAsync(string message)
    {
        return await Application.Current.MainPage.DisplayAlert("Confirm", message, "Yes", "No");
    }
}
