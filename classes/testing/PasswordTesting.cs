using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class PasswordTesting
    {
        [Test]
        public void HashPasswordNoPasswordSet()
        {
            Password password = new Password();
            password.HashPassword();
        }

        [Test]
        public void HashPasswordPasswordSet()
        {
            Password password = new Password();
            password.PassWord = "Test1234";
            password.HashPassword();
        }

        [Test]
        public void GenerateTemporaryPassword()
        {
            Password password = new Password();
            password.GenerateTemporaryPassword();
        }
    }
}