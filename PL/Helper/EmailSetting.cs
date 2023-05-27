using DAL.Entities;
using Microsoft.Extensions.Options;
using MimeKit;
using PL.eSettings;
using System.Threading.Tasks;

namespace PL.Helper
{
    public class EmailSetting : IEmailSettings
    {
        private readonly EmailSet options;

        public EmailSetting(IOptions<EmailSet> _options) 
        {
            options = _options.Value;
        }
        public Task SendEmail(Email email)
        {
            var mail = new MimeMessage
            {
                Sender = MailboxAddress.Parse(options.Email),
                Subject = email.title,
            };

            mail.To.Add(MailboxAddress.Parse(email.to));

            
        }
    }
}
