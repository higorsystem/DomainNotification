namespace DomainNotification.Prompt.DTO
{
    using System;

    public class PessoaDTO
    {
        public PessoaDTO(Guid pessoaId, string nome, string email)
        {
            this.PessoaId = pessoaId;
            this.Nome = nome;
            this.Email = email;
        } 

        public Guid PessoaId { get; }
        public string Nome { get; }
        public string Email { get; }
    }
}