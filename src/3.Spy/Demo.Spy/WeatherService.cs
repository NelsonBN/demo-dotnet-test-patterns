namespace Demo.Spy;

public class NotificationService
{
    private readonly INotifier _notifier;

    public NotificationService(INotifier notifier)
    {
        _notifier = notifier;
    }

    public void NotifyUsers(List<User> users, string message)
    {
        foreach (var user in users)
        {
            _notifier.SendNotification(user, message);
        }
    }
}
