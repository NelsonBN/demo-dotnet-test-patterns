namespace Demo.Spy;

public interface INotifier
{
    void SendNotification(User user, string message);
}

public class Notifier : INotifier
{
    public void SendNotification(User user, string message) { }
}
