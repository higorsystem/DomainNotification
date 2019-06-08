namespace DomainNotification.Domain.Commands
{
    using DomainNotification.Domain.Entities;
    using DomainNotification.Domain.Errors;

    public class Command
    {
        protected Command(Entity entity)
        {
            Entity = entity;
        }

        protected Entity Entity;

        protected Error Errors => this.Entity.Errors;
    }
}