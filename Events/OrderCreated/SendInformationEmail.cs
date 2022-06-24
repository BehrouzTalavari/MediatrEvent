using MediatR;

namespace MediatrEventWebApp.Events.OrderCreated
{
    public class SendInformationEmail : INotificationHandler<OrderCreatedNotification>
    {
        public async Task Handle(OrderCreatedNotification notification, CancellationToken cancellationToken)
        {
            var actionSendEmail = async () =>  Console.WriteLine($"Email Sended to {notification.UserName} for OrderId: {notification.OrderId} !!!!"); ;
            await actionSendEmail.Invoke();
        }
    }
}
