namespace DomainNotification.Domain.Entities
{
    using System;

    using DomainNotification.Domain.Errors;

    public class Entity
    {
        public Error Errors { get; } = new Error();
        
        public virtual void Validate() { }

        protected void Fail(bool condition, ErrorDescription description)
        {
            if (condition) this.Errors.Add(description);
        }

        public bool IsValid()
        {
            return !this.Errors.HasErrors;
        }

        protected void IsInvalidGuid(Guid guid, ErrorDescription error)
        {
            this.Fail(guid == Guid.Empty, error);
        }

        protected void IsInvalidName(string s, ErrorDescription error)
        {
            this.Fail(string.IsNullOrWhiteSpace(s), error);
        }

        // Errors mensagens
        public static ErrorDescription InvalidId = new ErrorDescription("Identificador inválido!!!", new Critical());
        public static ErrorDescription InvalidName = new ErrorDescription("O nome é inválido!!!", new Critical());
    }
}