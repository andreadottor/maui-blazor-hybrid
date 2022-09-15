namespace Dottor.BlazorApp.Shared;

using System.Threading.Tasks;

public interface INotificationService
{

    Task ShowAlertAsync(string message);
    Task<bool> ShowConfirmAsync(string message);
}
