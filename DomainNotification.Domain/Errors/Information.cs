namespace DomainNotification.Domain.Errors
{
    using DomainNotification.Domain.Interfaces.Errors;

    public class Information : ILevel
    {
        public Information(string description = "Informação")
        {
            this.Description = description;
        }

        /// <summary>
        /// Obtém ou define a descrição do nível.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Returna a descrição da informação.
        /// </summary>
        /// <returns>
        /// Retorna a representação em string da descrição.
        /// </returns>
        public override string ToString() => this.Description;

    }
}