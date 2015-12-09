using System;
using System.Net;
using System.Net.Mail;

namespace Client.Service.Email
{
    public class EmailClient : IEmailClient
    {
        private const string FROM_ADDRESS = null;
        private const string FROM_PASSWORD = null;
        private const string FROM_HOST = null;
        private const int FROM_PORT = -1;
        private const string TO_HOST = null;

        private SmtpClient Client = new SmtpClient();

        public EmailClient()
        {
            if (FROM_ADDRESS == null || FROM_PASSWORD == null || FROM_HOST == null || FROM_PORT <= 0 || TO_HOST == null)
            {
                throw new ArgumentException("Invalid arguments, please fill in your e-mail information.");
            }
            else
            {
                this.Client.Port = FROM_PORT;
                this.Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                this.Client.UseDefaultCredentials = false;
                this.Client.Credentials = new NetworkCredential(FROM_ADDRESS, FROM_PASSWORD);
                this.Client.Host = FROM_HOST;
            }
        }

        public void Send(string student, string password)
        {
            MailMessage mail = new MailMessage(FROM_ADDRESS, student + "@" + TO_HOST);
            mail.Subject = "Interactieve Docent - Account Created.";
            mail.Body = "U kunt nu inloggen met uw leerlingnummer en het gegenereerde wachtwoord (" + password + ") deze blijft geldig tot het einde van het college";

            this.Client.Send(mail);
        }
    }
}
