namespace DomainNotification.Domain.Interfaces.Errors
{
    public interface ILevel
    {
        /// <summary>
        /// Obtém ou define a descrição do nível.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Sobrescreve o método ToString para ser apresentado de forma simples.
        /// </summary>
        /// <returns>
        /// A message da descrição.
        /// </returns>
        string ToString();
    }
}