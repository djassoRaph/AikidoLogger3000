using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net.Mime;
using System.Windows.Forms;

namespace AikidoLog
{
    public static class Tools
    {
        public static string SendEmail(string toAdress, string subject, string body)
        {
            string result = "Message Sent Successfully!";
            string senderID = "tryotestvietalpha@gmail.com"; // use sender's e-mail id here...
            const string senderPassword = "NK;`3F8h]RZLH8pU"; // Sender password here...
            MessageBox.Show(body);
            try
            {
                SmtpClient smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com", // smtp server adress here...
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new System.Net.NetworkCredential(senderID, senderPassword),
                    Timeout = 30000,

                };
                MailMessage message = new MailMessage(senderID, toAdress, subject, body);
                smtp.Send(message);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : \n" + ex.Message, "Sending ERROR!");

            }
            MessageBox.Show(result);
            return result;
        }/*
        public static string DelayEmail(string today, string delay)

        {

        }*/




    }





}
