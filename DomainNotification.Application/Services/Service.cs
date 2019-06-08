namespace DomainNotification.Application.Services
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;

    using DomainNotification.Domain.Entities;

    public abstract class Service
    {
        protected Entity NotificationEntity;

        public bool HasNotifications => this.NotificationEntity != null && this.NotificationEntity.Errors.HasNotifications;

        public bool HasErrors => this.NotificationEntity != null && this.NotificationEntity.Errors.HasErrors;

        public bool HasWarnings => this.NotificationEntity != null && this.NotificationEntity.Errors.HasWarnings;

        public bool HasInformations => this.NotificationEntity != null && this.NotificationEntity.Errors.HasInformation;

        public IEnumerable Errors()
        {
            return this.NotificationEntity?.Errors.Errors;
        }

        public IEnumerable Warnings()
        {
            return this.NotificationEntity?.Errors.Warnings;
        }

        public IEnumerable Information()
        {
            return this.NotificationEntity?.Errors.Information;
        }
    }
}