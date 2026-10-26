namespace EduHub.Ch02.Notifications;
public interface INotificationService { void Send(string to, string message); }

// Notifications/EmailNotificationService.cs
public class EmailNotificationService : INotificationService
{
    public void Send(string to, string message) =>
        Console.WriteLine($"Email to {to}: {message}");
}