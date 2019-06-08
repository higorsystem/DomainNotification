namespace DomainNotification.Domain.Errors
{
    using System.Collections.Generic;
    using System.Linq;

    using DomainNotification.Domain.Notifications;

    /// <summary>
    /// The error.
    /// </summary>
    public class Error : Notification
    {
        public IList<ErrorDescription> Errors => 
            this.List.Cast<ErrorDescription>().Where(x => x.Level is Critical).ToList();

        public IList<ErrorDescription> Warnings => 
            this.List.Cast<ErrorDescription>().Where(x => x.Level is Warning).ToList();

        public IList<ErrorDescription> Information =>
            this.List.Cast<ErrorDescription>().Where(x => x.Level is Information).ToList();

        public bool HasErrors => this.List.Cast<ErrorDescription>().Any(x => x.Level is Critical);

        public bool HasWarnings => this.List.Cast<ErrorDescription>().Any(x => x.Level is Warning);

        public bool HasInformation => this.List.Cast<ErrorDescription>().Any(x => x.Level is Information);


    }
}