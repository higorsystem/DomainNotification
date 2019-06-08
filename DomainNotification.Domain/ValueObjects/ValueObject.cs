namespace DomainNotification.Domain.ValueObjects
{
    using System.Security;
    using System.Text.RegularExpressions;

    using DomainNotification.Domain.Errors;

    public class ValueObject
    {
        public Error Notification { get; } = new Error();

        public virtual void Validate()
        {
        }

        protected void Fail(bool condition, ErrorDescription error)
        {
            if (condition)
            {
                this.Notification.Add(error);
            }
        }

        public bool IsValid()
        {
            return !this.Notification.HasErrors;
        }

        protected void IsInvalidEmail(string s, ErrorDescription error)
        {
            const string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            this.Fail(!Regex.IsMatch(s, pattern), error);
        }

        public static ErrorDescription InvalidEmail = new ErrorDescription("Endereço de e-mail inválido!!!", new Critical());

    }
}