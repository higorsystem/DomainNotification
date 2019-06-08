namespace DomainNotification.Application.Services
{
    using System;

    using DomainNotification.Domain.Commands;
    using DomainNotification.Domain.Entities;
    using DomainNotification.Domain.ValueObjects;

    public class PessoaService : Service
    {
        private readonly Pessoa _pessoaEntity;

        public PessoaService(Guid pessoaId, string nome, string email)
        {
            this._pessoaEntity = new Pessoa(pessoaId, nome, new Email(email));
            this.NotificationEntity = this._pessoaEntity;
        }

        public void SavePessoa(Guid pessoaId, string nome)
        {
            var cmd = new SalvarPessoa(this._pessoaEntity);
            cmd.Run();
        }
    }
}