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


    public static void SendEmail(string recevier, string receiverAddress, string subject, TextFormat type, string msg)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress(_Secret["DisplayedName"], GetEmailAddress()));
        message.To.Add(new MailboxAddress(recevier, receiverAddress));
        message.Subject = subject;
        message.Body = new TextPart(type)
        {
            Text = msg
        };


        using (var client = new SmtpClient())
        {
            client.Connect(_Secret["ServerURL"], int.Parse(_Secret["Port"]), false);
            client.Authenticate(GetEmailAddress(), _Secret["Password"]);

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