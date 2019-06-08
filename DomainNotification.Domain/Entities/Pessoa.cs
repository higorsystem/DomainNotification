namespace DomainNotification.Domain.Entities
{
    using System;

    using DomainNotification.Domain.Errors;
    using DomainNotification.Domain.ValueObjects;

    public class Pessoa : Entity
    {
        public Guid PessoaId { get; }
        public string Nome { get; }

        public Email Email { get; }

        public Pessoa(Guid pessoaId, string nome, Email email)
        {
            this.PessoaId = pessoaId;
            this.Nome = nome;
            this.Email = email;
            this.Validate();
        }

        public override void Validate()
        {
            this.IsInvalidGuid(this.PessoaId, InvalidId);
            this.IsInvalidName(this.Nome, InvalidName);
            this.IsInvalidEmail(this.Email, InvalidPessoaEmail);
        }

        /// <summary>
        /// Notifica se o e-mail for inválido.
        /// </summary>
        /// <param name="email">
        /// O email a ser notifcado.
        /// </param>
        /// <param name="error">
        /// O error a ser disparado.
        /// </param>
        protected void IsInvalidEmail(Email email, ErrorDescription error)
        {
            this.Fail(email.Notification.HasErrors, error);
        }

        /// <summary>
        /// Valda
        /// </summary>
        public static ErrorDescription InvalidPessoaEmail = new ErrorDescription("E-mail inválido veja as notificações dos objetos para mais detalhes.", new Critical());
    }
}