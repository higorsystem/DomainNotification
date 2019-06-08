namespace DomainNotification.Domain.Notifications
{
    using System.Collections.Generic;
    using System.Linq;

    using DomainNotification.Domain.Interfaces.Notifications;

    public abstract class Notification : INotification
    {
        public IList<object> List { get; } = new List<object>();

        public bool HasNotifications => this.List.Any();  

        public bool Includes(Description error)
        {
            return List.Contains(error);
        }

        public void Add(Description description) => this.List.Add(description);
    }
}