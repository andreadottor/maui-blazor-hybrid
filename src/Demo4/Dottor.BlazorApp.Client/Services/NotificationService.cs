namespace Dottor.BlazorApp.Client.Services;

using Dottor.BlazorApp.Shared;
using Microsoft.JSInterop;
using System.Threading.Tasks;

public class NotificationService : INotificationService
{
    private readonly IJSRuntime _jsRuntime;

    public NotificationService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task ShowAlertAsync(string message)
    {
        await _jsRuntime.InvokeVoidAsync("window.alert", message);
    }

    public async Task<bool> ShowConfirmAsync(string message)
    {
        return await _jsRuntime.InvokeAsync<bool>("window.confirm", message);
    }
}
