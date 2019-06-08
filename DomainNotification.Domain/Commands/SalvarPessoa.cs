namespace DomainNotification.Domain.Commands
{
    using System;

    using DomainNotification.Domain.Entities;
    using DomainNotification.Domain.Errors;

    public class SalvarPessoa : Command
    {
        private readonly Pessoa _pessoa;

        public SalvarPessoa(Pessoa pessoa)
            : base(pessoa)
        {
            this._pessoa = pessoa;
            var description = new ErrorDescription("Nova pessoa criada em memoria.", new Warning());
            this._pessoa.Errors.Add(description);
        }

        public void Run()
        {
            if (!Errors.HasErrors)
            {
               this.SavePessoaInBackendSystems();
            }

            else
            {
                var error = new ErrorDescription("O registro foi abortado por causa de um error!", new Critical());
                this._pessoa.Errors.Add(error);
            }
        }

        private void SavePessoaInBackendSystems()
        {
            var message = new ErrorDescription("Registro criado com sucesso!!!", new Information());
            this._pessoa.Errors.Add(message);
        }
    }
}