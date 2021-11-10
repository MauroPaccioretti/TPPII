using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace EquiposBackend.Datos.MailServices
{
    public abstract class MasterMailServices
    {
        private SmtpClient SmtpClient;
        protected string SenderMail { get; set; }
        protected string Password { get; set; }
        protected string Host { get; set; }
        protected int Port { get; set; }
        protected bool Ssl { get; set; }

        protected void initializeSmtpClient()
        {
            SmtpClient = new SmtpClient();
            SmtpClient.Credentials = new NetworkCredential(SenderMail, Password);
            SmtpClient.Host = this.Host;
            SmtpClient.Port = this.Port;
            SmtpClient.EnableSsl = this.Ssl;

        }


        public void SendEmail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            {
                mailMessage.From = new MailAddress(SenderMail);
                foreach (string mail in recipientMail)
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                SmtpClient.Send(mailMessage);               
            }
            catch (Exception)
            {
            }
            finally 
            {
                mailMessage.Dispose();
                SmtpClient.Dispose();
            }
        }
    }
}
