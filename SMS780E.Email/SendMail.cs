using MimeKit;
using MailKit.Net.Smtp;

namespace SMS780E.Email
{
    public class SendEmail
    {
        SmtpConfig smtpcfg;
        public SendEmail(SmtpConfig smtpcfg)
        {
            this.smtpcfg = smtpcfg;
        }

        public void Send(MailEntity mail)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(mail.fromName,mail.fromMailAddress));
            message.To.Add(new MailboxAddress(mail.toName, mail.toMailAddress));
            message.Subject = mail.subject;

            message.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = mail.body
            };

            using (var client = new SmtpClient())
            {
                client.Connect(smtpcfg.host, smtpcfg.port, smtpcfg.useSsl, smtpcfg.cancellationToken);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate(smtpcfg.username, smtpcfg.password);

                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}
