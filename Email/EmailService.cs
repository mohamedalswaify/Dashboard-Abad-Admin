using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net.Mail;

namespace WebApplicationAbad.Email
{
    public class EmailService:IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings?.Value ?? throw new ArgumentNullException(nameof(emailSettings));
        }
        [HttpPost]
        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            try
            {
                // Validate the 'recipient' parameter as a proper email address
                if (string.IsNullOrEmpty(recipient) || !IsValidEmail(recipient))
                {
                    throw new ArgumentException("Invalid or empty email address.", nameof(recipient));
                }

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("StarShield", "sale@starshieldsa.com"));

                // Validate the 'recipient' address before setting it
                var recipientAddress = new MailboxAddress("", "sale@starshieldsa.com");
                message.To.Add(recipientAddress);

                message.Subject = subject;

                var builder = new BodyBuilder { HtmlBody = body };
                message.Body = builder.ToMessageBody();

                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync(_emailSettings.Username, _emailSettings.Password);
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
            }
            catch (Exception ex)
            {
                // Log and handle the exception as needed
                throw new Exception("Failed to send email.", ex);
            }
        }


        // Validate email address format
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
