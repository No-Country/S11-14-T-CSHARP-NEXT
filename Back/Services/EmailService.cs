using System.Net;
using System.Net.Mail;
using HotelWiz.Back.Services.DTO;
using Humanizer;
using MailKit;
using MailKit.Net.Imap;
using Microsoft.Extensions.Options;

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


    public List<string> GetMessagesTitles()
    {
        using (var client = new ImapClient())
        {
            client.Connect("imap.gmail.com", 993 /*_emailSettings.SmtpPort*/, true);
            client.Authenticate(_emailSettings.FromEmail, _emailSettings.SmtpPassword);

            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);

            Console.WriteLine("Total messages: {0}", inbox.Count);
            Console.WriteLine("Recent messages: {0}", inbox.Recent);

            for (int i = 0; i < inbox.Count; i++)
            {
                var message = inbox.GetMessage(i);
                Console.WriteLine("Subject: {0}", message.Subject);
            }
            client.Disconnect(true);
        }
        return new();
    }
}