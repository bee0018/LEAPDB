using System.Net.Mail;
using System.Net;

namespace LEAP_DB_Web.Pages.Login.Util
{
    public class EmailUtil
    {
        // Email placeholder 
        private static string GetUserName()
        {
            return "csseaffinity.noreply@gmail.com";
        }

        // Email Password placeholder
        private static string GetPassword()
        {
            return "dqhxjarjmqfzfieu";
        }

        /// <summary>
        /// Sends the email to the user of choice with a custom message.
        /// </summary>
        /// <param name="toAddress"></param>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        public static void SendEmail(string toAddress, string subject, string body)
        {
            // Constructs email object
            var email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential(GetUserName(), GetPassword())
            };

            // Attempts to send email address
            try
            {
                email.Send(GetUserName(), toAddress, subject, body);
                Console.WriteLine("\nEmail sent successfully!");
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

