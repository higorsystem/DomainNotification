namespace DomainNotification.Domain.Errors
{
    using DomainNotification.Domain.Interfaces.Errors;
    using DomainNotification.Domain.Notifications;

    public class ErrorDescription : Description
    {
        /// <summary>
        /// Obtém ou define o nível e severidade dos erros.
        /// </summary>
        public ILevel Level { get; }

        /// <summary>
        /// Inicializa uma nova instância da classe.
        /// </summary>
        /// <param name="message">
        /// A mensagem a ser apresentada.
        /// </param>
        /// <param name="level">
        /// O nível.
        /// </param>
        /// <param name="args">
        /// Outros argumentos a serem atribuidos.
        /// </param>
        public ErrorDescription(string message, ILevel level, params string[] args)
            : base(message, args)
        {
            this.Level = level;
        }
    }
}