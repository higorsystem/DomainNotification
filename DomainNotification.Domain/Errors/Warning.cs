namespace DomainNotification.Domain.Errors
{
    using DomainNotification.Domain.Interfaces.Errors;

    public class Warning : ILevel
    {

        public Warning(string description = "Alerta")
        {
            this.Description = description;
        }

        /// <summary>
        /// Obtém ou define a descrição do nível.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Retorna a descrição dos alertas.
        /// </summary>
        /// <returns>
        /// Retorna a descrição do alerta.
        /// </returns>
        public override string ToString() => this.Description;

    }
}