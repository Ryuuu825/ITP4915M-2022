using System;
using Newtonsoft.Json.Linq;
using MailKit.Net.Smtp;
using MimeKit;
using System.Net.Mail;
using TheBetterLimited_Server.AppLogic.Exceptions;

namespace TheBetterLimited_Server.Helpers
{
    public static class EmailSender
    {
        private static Helpers.SecretConf EmailConfig = Helpers.SecretConf.Instance;

        public static string GetEmailAddress()
        {
            return $"{EmailConfig["Username"]}{EmailConfig["Domain"]}";
        }


        public static void SendEmail(string recevier , string receiverAddress , string subject , MimeKit.Text.TextFormat type ,  string msg )
        {

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress( EmailConfig["DisplayedName"] , GetEmailAddress() ));
            message.To.Add(new MailboxAddress(recevier, receiverAddress));
            message.Subject = subject;
            message.Body = new TextPart(type)
            {
                Text = msg
            };
            

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(EmailConfig["ServerURL"] , Int32.Parse(EmailConfig["Port"]) , false);
                client.Authenticate(GetEmailAddress() , EmailConfig["Password"].ToString());

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
}

