using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using TheBetterLimited_Server.AppLogic.Exceptions;
using static TheBetterLimited_Server.Helpers.SecretConf;

namespace TheBetterLimited_Server.Helpers;

public static class EmailSender
{

    public static string GetEmailAddress()
    {
        return $"{_Secret["Username"]}{_Secret["Domain"]}";
    }

    public static MimeMessage CreateEmail(string recevier, string receiverAddress, string subject, in string msg)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(_Secret["DisplayedName"], GetEmailAddress()));
        message.To.Add(new MailboxAddress(recevier, receiverAddress));
        message.Subject = subject;
        message.Body = new TextPart(TextFormat.Html)
        {
            Text = msg
        };

        return message;
    }


    public static async Task SendEmail(string recevier, string receiverAddress, string subject, string msg)
    {
        
        var message = CreateEmail(recevier, receiverAddress, subject, in msg);

        using (var client = new SmtpClient())
        {
            await client.ConnectAsync(_Secret["ServerURL"], int.Parse(_Secret["Port"]), false);
            await client.AuthenticateAsync(GetEmailAddress(), _Secret["Password"]);

            if (client.IsConnected)
            {
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            else
            {
                throw new OperationFailException("Sent Email Fail");
            }
        }
    }
}