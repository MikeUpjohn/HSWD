using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class MailTesting
    {
        [Test]
        public void SendMailFullSetOfCredentialsNotSupplied()
        {
            Mail mail = new Mail();
            mail.SendMail();
        }

        [Test]
        public void SendMailFullSetOfCredentialsSupplied()
        {
            Mail mail = new Mail();
            mail.FromAddress = "historical-severe-weather-database@hotmail.com";
            mail.ToAddress = "michael.upjohn@hotmail.co.uk";
            mail.Subject = "Historical Severe Weather Database - Password Reset Request";
            mail.Body = "This is a test";

            mail.SendMail();
        }
    }
}