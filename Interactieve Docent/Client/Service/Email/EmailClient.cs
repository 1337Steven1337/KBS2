﻿using System.Net;
using System.Net.Mail;

namespace Client.Service.Email
{
    public class EmailClient : IEmailClient
    {
        private SmtpClient Client = new SmtpClient();

        public EmailClient()
        {
            this.Client.Port = 26;
            this.Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            this.Client.UseDefaultCredentials = false;
            this.Client.Credentials = new NetworkCredential("test@remcoschipper.com", "<redacted>");
            this.Client.Host = "mail.remcoschipper.com";
        }

        public void Send(string student, string password)
        {
            MailMessage mail = new MailMessage("test@remcoschipper.com", student + "@student.windesheim.nl");
            mail.Subject = "Interactieve Docent - Account Created.";
            mail.Body = "U kunt nu inloggen met uw leerlingnummer en het gegenereerde wachtwoord (" + password + ") deze blijft geldig tot het einde van het college";

            this.Client.Send(mail);
        }
    }
}
