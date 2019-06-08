namespace DomainNotification.Domain.Notifications
{
    using DomainNotification.Domain.Interfaces.Notifications;

    public abstract class Description :  IDescription
    {
        public string Message { get; }

        protected Description(string message, params string[] args)
        {
            this.Message = message;

            for (int i = 0; i < args.Length; i++)
            {
                this.Message = this.Message.Replace("{" + i + "}", args[i]);
            }
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A string that represents the current object.
        /// </returns>
        public override string ToString() => this.Message;

    }
}