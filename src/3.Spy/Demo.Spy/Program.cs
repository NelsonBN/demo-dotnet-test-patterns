using Demo.Spy;

var notifier = new Notifier();

var service = new NotificationService(notifier);
service.NotifyUsers(
    [new() { Email = "fake@mail.fk" }],
    "Hello from Spy!");
