using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

using eShop.Common.Core.Entities;
using eShop.Common.Core.Interfaces;
using eShop.Common.Infrastructure.Settings;

namespace eShop.Common.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public MailSetting _mailSettings { get; }
        public ILoggerManager _logger { get; }

        public EmailService(IOptions<MailSetting> mailSettings, ILoggerManager logger)
        {
            _mailSettings = mailSettings.Value;
            _logger = logger;
        }

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            try
            {
                // create message
                var email = new MimeMessage();
                email.Sender = MailboxAddress.Parse(emailRequest.From ?? _mailSettings.EmailFrom);
                email.To.Add(MailboxAddress.Parse(emailRequest.To));
                email.Subject = emailRequest.Subject;

                var builder = new BodyBuilder();
                if (emailRequest.Attachments != null)
                {
                    byte[] fileBytes;
                    foreach (var file in emailRequest.Attachments)
                    {
                        if (file.Length > 0)
                        {
                            using (var ms = new MemoryStream())
                            {
                                file.CopyTo(ms);
                                fileBytes = ms.ToArray();
                            }
                            builder.Attachments.Add(file.FileName, fileBytes, ContentType.Parse(file.ContentType));
                        }
                    }
                }

                builder.HtmlBody = emailRequest.Body;
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
                smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPassword);
                await smtp.SendAsync(email);
                smtp.Disconnect(true);

            }
            catch (System.Exception ex)
            {
                _logger.LogError(ex.Message);
                //throw new ApiException(ex.Message);
            }
        }

        public async Task SendWelcomeEmailAsync(WelcomeEmailRequest emailRequest)
        {
            string FilePath = Directory.GetCurrentDirectory() + "\\Templates\\WelcomeTemplate.html";
            StreamReader str = new StreamReader(FilePath);
            string MailText = str.ReadToEnd();
            str.Close();

            MailText = MailText.Replace("[username]", emailRequest.UserName).Replace("[email]", emailRequest.ToEmail);
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.SmtpUser);
            email.To.Add(MailboxAddress.Parse(emailRequest.ToEmail));
            email.Subject = $"Welcome {emailRequest.UserName}";
            var builder = new BodyBuilder();
            builder.HtmlBody = MailText;
            email.Body = builder.ToMessageBody();
            using var smtp = new SmtpClient();
            smtp.Connect(_mailSettings.SmtpHost, _mailSettings.SmtpPort, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.SmtpUser, _mailSettings.SmtpPassword);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
