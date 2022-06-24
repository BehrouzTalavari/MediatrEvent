using MediatR;

using System.Reflection;

namespace MediatrEventWebApp.Events.OrderCreated
{
    public class OrderCreatedNotification : INotification
    {
        public string UserName { get; set; }
        public int OrderId { get; set; }
    } 
}
