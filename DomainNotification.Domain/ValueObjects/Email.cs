namespace DomainNotification.Domain.ValueObjects
{
    using System.Net.Sockets;

    public class Email : ValueObject
    {
        /// <summary>
        /// Inicializa uma nova instância da classe.
        /// </summary>
        /// <param name="address">
        /// O endereço a ser utilizado.
        /// </param>
        public Email(string address)
        {
            this.Address = address;
            this.Validate();
        }

        /// <summary>
        /// Valida a regra de negócio do dominio.
        /// </summary>
        public sealed override void Validate()
        {
            this.IsInvalidEmail(this.Address, InvalidEmail);
        }

        /// <summary>
        /// Obtém ou define o enderço de e-mail.
        /// </summary>
        public string Address { get; }
    }
}