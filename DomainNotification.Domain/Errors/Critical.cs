namespace DomainNotification.Domain.Errors
{
    using DomainNotification.Domain.Interfaces.Errors;
    using DomainNotification.Domain.Notifications;

    public class Critical : ILevel
    {
        public Critical(string description = "Crítico")
        {
            this.Description = description;
        }

        /// <summary>
        /// Obtém ou define a descrição do nível.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Retorna a descrição no nível.
        /// </summary>
        /// <returns>
        /// A descrição.
        /// </returns>
        public override string ToString() => this.Description;

    }
}