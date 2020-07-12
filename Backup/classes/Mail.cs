using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace artefact
{
    public class Mail
    {
        private string fromAddress;
        private string toAddress;
        private string subject;
        private string body;

        /// <summary>
        /// From Address Property
        /// </summary>
        public string FromAddress
        {
            get
            {
                return fromAddress;
            }
            set
            {
                this.fromAddress = value;
            }
        }

        /// <summary>
        /// To Address Property
        /// </summary>
        public string ToAddress
        {
            get
            {
                return toAddress;
            }
            set
            {
                this.toAddress = value;
            }

        }

        /// <summary>
        /// Subject Property
        /// </summary>
        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                this.subject = value;
            }
        }

        /// <summary>
        /// Body Property
        /// </summary>
        public string Body
        {
            get
            {
                return body;
            }

            set
            {
                this.body = value;
            }
        }

        /// <summary>
        /// Send a mail to a user
        /// </summary>
        public void SendMail()
        {
            /**
             * With thanks to http://weblogs.asp.net/scottgu/archive/2005/12/10/432854.aspx
             **/
            MailMessage message = new MailMessage();

            if (this.FromAddress != null && this.ToAddress != null && this.Subject != null && this.Body != null)
            {
                message.From = new MailAddress(this.FromAddress);
                message.To.Add(this.ToAddress);
                message.Subject = this.Subject;
                message.Body = this.Body;

                SmtpClient client = new SmtpClient();
                client.Send(message);
            }
            else
            {
                throw new Exception("Error 1001: Some of the required fields to send a mail were left blank.");
            }
        }
    }
}