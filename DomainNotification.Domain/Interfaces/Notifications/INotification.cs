namespace DomainNotification.Domain.Interfaces.Notifications
{
    using System.Collections.Generic;
    using DomainNotification.Domain.Notifications;

    public interface INotification
    {
         IList<object> List { get; }

        bool HasNotifications { get; }

        bool Includes(Description error);

        void Add(Description description);
    }
}