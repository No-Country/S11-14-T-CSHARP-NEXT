using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Options;
using S11.Services.DTO;

public class EmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }

    public void SendEmail(string to, string subject, string body)
    {
        using (var client = new SmtpClient(_emailSettings.SmtpServer))
        {
            client.Port = _emailSettings.SmtpPort;
            client.Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword);
            client.EnableSsl = true;

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName);
                message.To.Add(to);
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                client.Send(message);
            }
        }
    }
}