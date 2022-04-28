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

        public readonly static JToken EmailConfig = SecretConfig.Instance.GetEmailDetail();


        public static string GetEmailAddress()
        {
            return $"{EmailConfig["Username"]}{EmailConfig["Domain"]}";
        }

        public static MailboxAddress GetMailBoxAddress()
        {
            return new MailboxAddress(EmailConfig["DisplayUserName"].ToString(), GetEmailAddress());
        }

        public static void SentEmail(MailboxAddress destination , string subject , MimeKit.Text.TextFormat type ,  string msg )
        {
            var message = new MimeMessage();
            message.From.Add(GetMailBoxAddress());
            message.To.Add(destination);
            message.Body = new TextPart(type)
            {
                Text = msg
            };
            

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect(EmailConfig["ServerName"].ToString() , 587, false);
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

