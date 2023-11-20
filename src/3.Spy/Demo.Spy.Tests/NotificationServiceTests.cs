namespace Demo.Spy.Tests;

public class NotificationServiceTests
{
    [Fact]
    public void NotifyUsers_ShouldCallSendNotificationForEachUser()
    {
        // Arrange
        var notifier = Substitute.For<INotifier>();

        var service = new NotificationService(notifier);

        var users = new List<User>
        {
            new() { Email = "fake1@mail.fk" },
            new() { Email = "fake2@mail.fk" },
            new() { Email = "fake3@mail.fk" }
        };


        // Act
        service.NotifyUsers(
            users,
            "Test Message");


        // Assert
        notifier.Received(3)
                .SendNotification(Arg.Any<User>(), "Test Message");
    }
}