using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VrMarketim.MailService
{
    public class MailSender : IMailSender
    {
        private readonly MailConfiguration _configuration;

        public MailSender(MailConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendMail(Message message)
        {
            var mailMessage = CreateMailMessage(message);

            Send(mailMessage);
        }

        public async Task SendMailAsync(Message message)
        {
            var mailMessage = CreateMailMessage(message);
            await SendAsync(mailMessage);
        }

        private MimeMessage CreateMailMessage(Message message)
        {
            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress(_configuration.From));
            mailMessage.To.AddRange(message.To);
            mailMessage.Subject = message.Subject;
            mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };

            return mailMessage;
        }

        private void Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(_configuration.SmtpServer, _configuration.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    client.Authenticate(_configuration.Username, _configuration.Password);

                    client.Send(mailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }

        private async Task SendAsync(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    await client.ConnectAsync(_configuration.SmtpServer, _configuration.Port, true);
                    client.AuthenticationMechanisms.Remove("XOAUTH2");
                    await client.AuthenticateAsync(_configuration.Username, _configuration.Password);

                    await client.SendAsync(mailMessage);
                }
                catch
                {
                    throw;
                }
                finally
                {
                    await client.DisconnectAsync(true);
                    client.Dispose();
                }
            }
        }
    }
}
