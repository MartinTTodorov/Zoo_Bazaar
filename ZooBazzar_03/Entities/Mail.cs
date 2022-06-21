using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entities
{
    public static class Mail
    {
        public static async Task SendAsync( string name, string clientEmail, Ticket product)
        {
            //const string smtpHostAddress = "appssmtp.abv.bg";
            //const string adminEmailAddress = "georgi.antoanov@abv.bg";
            //const string adminEmailPassword = "proba-greshka";
            //MailMessage message = new MailMessage(adminEmailAddress, clientEmail, "Test", $"{product.DateOfPurchase.ToString()}");

            ////FINALLY LETS CREATE SMTP OBJECT TO SEND THE EMAILS TO ADMIN AND THE USERvar
            //SmtpClient smtp = new SmtpClient
            //{
            //    Host = smtpHostAddress,
            //    Port = 465,
            //    UseDefaultCredentials = false,
            //    Credentials = new System.Net.NetworkCredential
            //            (adminEmailAddress, adminEmailPassword),
            //    EnableSsl = true,
            //};


            ////SEND THE EMAILS OUT
            //smtp.Send(message);

            //var smtpClient = new SmtpClient("smtp.abv.bg", 465)
            //{
            //    Credentials = new NetworkCredential("zoobazzar@abv.bg", "bitcoinaMarti"),
            //    EnableSsl = true,
            //};

            //smtpClient.Send("zoobazzar@abv.bg", clientEmail, "Test", $"  ");

            var messageToSend = new MimeMessage
            {
                Sender = new MailboxAddress(name, clientEmail),
                Subject = "Your Subject",
            };
            if (messageToSend == null) throw new ArgumentNullException(nameof(messageToSend));
            messageToSend.Body = new TextPart(TextFormat.Html) { Text = "test" };
            messageToSend.From.Add(new MailboxAddress("i463263@student.fontys.nl", "Georgi Zhizgov"));
            messageToSend.To.Add(new MailboxAddress(clientEmail, name)); //important!!


            using (var smtp = new MailKit.Net.Smtp.SmtpClient())
            {
                smtp.MessageSent += (sender, args) =>
                {
                    Console.WriteLine(args.Response);
                };
                smtp.ServerCertificateValidationCallback = (s, c, h, e) => true;
                await smtp.ConnectAsync("mailrelay.fhict.local", 25, SecureSocketOptions.None);
                //await smtp.AuthenticateAsync("Username", "Password");
                await smtp.SendAsync(messageToSend);
                await smtp.DisconnectAsync(true);
            };



        }


        //public static void SendAbvBg(string message, string clientEmail)
        //{
        //    var Smtp = new SmtpClient("smtp.abv.bg", 465);
        //    Smtp.UseDefaultCredentials = false;
        //    Smtp.EnableSsl = true;
        //    Smtp.Timeout = 80000;
        //    Smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        //    Smtp.Credentials = new System.Net.NetworkCredential("zoobazzar@abv.bg", "bitcoinaMarti");

        //    MailMessage msg = new MailMessage();
        //    msg.Body = message;
        //    msg.From = new MailAddress("zoobazzar@abv.bg", "Zoo Bazzar");
        //    msg.To.Add(clientEmail);
        //    msg.HeadersEncoding = Encoding.UTF8;
        //    msg.BodyEncoding = Encoding.UTF8;
        //    msg.IsBodyHtml = true;
        //    msg.Subject = "Form";
        //    msg.SubjectEncoding = Encoding.UTF8;

        //    msg.Headers.Add("MIME-Version", "1.0");
        //    msg.Headers.Add("Content-Language", "en-us");

        //    try
        //    {
        //        Smtp.Send(msg);
        //    }
        //    catch (Exception e)
        //    {
        //        // timeout exception
        //        throw e;
        //    }
        //}





    }
}
