using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Helpers;

public static class EmailSender
{
    private static readonly SecretConf EmailConfig = SecretConf.Instance;

    public static string GetEmailAddress()
    {
        return $"{EmailConfig["Username"]}{EmailConfig["Domain"]}";
    }


    public static void SendEmail(string recevier, string receiverAddress, string subject, TextFormat type, string msg)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(EmailConfig["DisplayedName"], GetEmailAddress()));
        message.To.Add(new MailboxAddress(recevier, receiverAddress));
        message.Subject = subject;
        message.Body = new TextPart(type)
        {
            Text = msg
        };


        using (var client = new SmtpClient())
        {
            client.Connect(EmailConfig["ServerURL"], int.Parse(EmailConfig["Port"]), false);
            client.Authenticate(GetEmailAddress(), EmailConfig["Password"]);

            if (client.IsConnected)
            {
                client.Send(message);
                client.Disconnect(true);
            }
            else
            {
                throw new OperationFailException("Sent Email Fail");
            }
        }
    }
}