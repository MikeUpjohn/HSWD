using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class UserTesting
    {
        [Test]
        public void RegisterUserNoCredentialsSpecified()
        {
            User user = new User();
            user.RegisterUser();
        }

        [Test]
        public void RegisterUserMinimumCredentialsSpecified()
        {
            User user = new User();
            user.Title = "Mr";
            user.Forename = "Tom";
            user.Surname = "Jones";
            user.EmailAddress = "tom.jones@email.com";
            user.Username = new Username("TomJones1");
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.RegisterUser();
        }

        [Test]
        public void AddUserNoCredentialsSpecified()
        {
            User user = new User();
            user.AddUser();
        }

        [Test]
        public void AddUserCredentialsSpecified()
        {
            User user = new User();
            Password password = new Password();
            user.Title = "Mr";
            user.Forename = "Tom";
            user.Surname = "Jones";
            user.EmailAddress = "tom.jones@email.com";
            user.Username = new Username("TomJones1");
            user.Password = new Password("Test1234");
            user.Password.HashPassword();

            user.AddUser();
        }

        [Test]
        public void GetUserIDFromGUIDNoGUIDSupplied()
        {
            User user = new User();
            user.GetUserIDFromGUID();
        }

        [Test]
        public void GetUserIDFromGUIDValidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("d9e266bc-63b6-42e9-a0c5-31c978f78877");
            user.GetUserIDFromGUID();
        }

        [Test]
        public void GetUserIDFromGUIDInvalidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("d9e266bc-63b6-42e9-a0c5-31c978f78878");
            user.GetUserIDFromGUID();
        }

        [Test]
        public void CheckUsernameExistenceNoUsernameSupplied()
        {
            User user = new User();
            user.CheckUsernameExistence();
        }

        [Test]
        public void CheckUsernameExistenceExistingUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("MarkSmith1");
            user.CheckUsernameExistence();
        }

        [Test]
        public void CheckUsernameExistenceNonExistantUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("NonExistant");
            user.CheckUsernameExistence();
        }

        [Test]
        public void CheckGUIDExistenceNoGUIDSupplied()
        {
            User user = new User();
            user.CheckGUIDExistence();
        }

        [Test]
        public void CheckGUIDExistenceExistingGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
            user.CheckGUIDExistence();
        }

        [Test]
        public void CheckGUIDExistenceNonExistantGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
            user.CheckGUIDExistence();
        }

        [Test]
        public void CheckEmailAddressExistanceNoEmailAddressSupplied()
        {
            User user = new User();
            user.CheckEmailAddressExistence();
        }

        [Test]
        public void CheckEmailAddressExistanceExistingEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "michael.upjohn@hotmail.co.uk";
            user.CheckEmailAddressExistence();
        }

        [Test]
        public void CheckEmailAddressExistanceNonExistantEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.CheckEmailAddressExistence();
        }

        [Test]
        public void CheckPasswordForThisUsernameNoCredentialsSupplied()
        {
            User user = new User();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameUsernameNoPasswordSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameNoUsernamePasswordSupplied()
        {
            User user = new User();
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameValidUsernameValidPasswordSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameValidUsernameInvalidPasswordSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.Password = new Password("Test12345");
            user.Password.HashPassword();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameInvalidUsernameValidPasswordSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones12");
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void CheckPasswordForThisUsernameInvalidUsernameInvalidPasswordSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones12");
            user.Password = new Password("Test12345");
            user.Password.HashPassword();
            user.CheckPasswordForThisUsername();
        }

        [Test]
        public void GenerateTemporaryPassword()
        {
            User user = new User();
            user.GenerateTemporaryUserPassword();
        }

        [Test]
        public void MailUserPasswordResetEmailNoCredentialsSpecified()
        {
            User user = new User();
            user.MailUserPasswordResetEmail();
        }

        [Test]
        public void MailUserPasswordResetEmail()
        {
            User user = new User();
            user.EmailAddress = "michael.upjohn@hotmail.co.uk";
            user.Forename = "Michael";
            user.TemporaryPassword = new Password("Test12");
        }

        [Test]
        public void StoreTemporaryPasswordNoCredentialsSupplied()
        {
            User user = new User();
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordNoTemporaryPasswordGoodUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordNoTemporaryPasswordBadUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones12");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordTemporaryPasswordGoodUsernameSupplied()
        {
            User user = new User();
            user.TemporaryPassword = new Password("Test12");
            user.Username = new Username("TomJones1");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordTemporaryPasswordBadUsernameSupplied()
        {
            User user = new User();
            user.TemporaryPassword = new Password("Test12");
            user.Username = new Username("TomJones12");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordNoTemporaryPasswordNoUsernameSupplied()
        {
            User user = new User();
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordTemporaryPasswordNoUsernameSupplied()
        {
            User user = new User();
            user.TemporaryPassword = new Password("Test12");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordNoTemporaryPasswordUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.StoreTemporaryPassword();
        }

        [Test]
        public void StoreTemporaryPasswordTemporaryPasswordUsernameSupplied()
        {
            User user = new User();
            user.TemporaryPassword = new Password("Test12");
            user.Username = new Username("TomJones1");
        }

        [Test]
        public void GetGUIDFromUsernameNoUsernameSupplied() {
            User user = new User();
            user.GetGUIDFromUsername();
        }

        [Test]
        public void GetGUIDFromUsernameValidUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones1");
            user.GetGUIDFromUsername();
        }

        [Test]
        public void GetGUIDFromUsernameInvalidUsernameSupplied()
        {
            User user = new User();
            user.Username = new Username("TomJones12");
            user.GetGUIDFromUsername();
        }

        [Test]
        public void GetEmailFromGUIDNoGUIDSupplied()
        {
            User user = new User();
            user.GetEmailFromGUID();
        }

        [Test]
        public void GetEmailFromGUIDValidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
            user.GetEmailFromGUID();
        }

        [Test]
        public void GetEmailFromGUIDInvalidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
            user.GetEmailFromGUID();
        }

        [Test]
        public void GetForenameFromGUIDNoGUIDSupplied()
        {
            User user = new User();
            user.GetForenameFromGUID();
        }

        [Test]
        public void GetForenameFromGUIDValidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
            user.GetForenameFromGUID();
        }

        [Test]
        public void GetForenameFromGUIDInvalidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
            user.GetForenameFromGUID();
        }

        [Test]
        public void GetTemporaryPasswordFromGUIDNoGUIDSupplied()
        {
            User user = new User();
            user.GetTemporaryPasswordFromGUID();
        }

        [Test]
        public void GetTemporaryPasswordFromGUIDValidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
            user.GetTemporaryPasswordFromGUID();
        }

        [Test]
        public void GetTemporaryPasswordFromGUIDInvalidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
            user.GetTemporaryPasswordFromGUID();
        }

        [Test]
        public void ResetPasswordNoPasswordNoGUIDSupplied()
        {
            User user = new User();
            user.ResetPassword();
        }

        [Test]
        public void ResetPasswordNoPasswordValidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
            user.ResetPassword();
        }

        [Test]
        public void ResetPasswordNoPasswordInvalidGUIDSupplied()
        {
            User user = new User();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
            user.ResetPassword();
        }

        [Test]
        public void ResetPasswordPasswordNoGUIDSupplied()
        {
            User user = new User();
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.ResetPassword();
        }

        [Test]
        public void ResetPasswordPasswordValidGUIDSupplied()
        {
            User user = new User();
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a");
        }

        [Test]
        public void ResetPasswordPasswordInvalidGUIDSupplied()
        {
            User user = new User();
            user.Password = new Password("Test1234");
            user.Password.HashPassword();
            user.Guid = Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b");
        }

        [Test]
        public void GetCountOfEmailAddressNoEmailAddressSupplied()
        {
            User user = new User();
            user.GetCountOfEmailAddress();
        }

        [Test]
        public void GetCountOfEmailAddressValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.GetCountOfEmailAddress();
        }

        [Test]
        public void GetCountOfEmailAddressInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones1@email.com";
            user.GetCountOfEmailAddress();
        }

        [Test]
        public void GetUsernameNoEmailAddressSupplied()
        {
            User user = new User();
            user.GetUsername();
        }

        [Test]
        public void GetUsernameValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.GetUsername();
        }

        [Test]
        public void GetUsernameInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones1@email.com";
            user.GetUsername();
        }

        [Test]
        public void GetUsernameFromEmailAddressNoEmailAddressSupplied()
        {
            User user = new User();
            user.GetUsernameFromEmailAddress();
        }

        [Test]
        public void GetUsernameFromEmailAddressValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.GetUsernameFromEmailAddress();
        }

        [Test]
        public void GetUsernameFromEmailAddressInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones1@email.com";
            user.GetUsernameFromEmailAddress();
        }

        [Test]
        public void GetForenameNoEmailAddressSupplied()
        {
            User user = new User();
            user.GetForename();
        }

        [Test]
        public void GetForenameValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.GetForename();
        }

        [Test]
        public void GetForenameInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones1@email.com";
            user.GetForename();
        }

        [Test]
        public void GetForenameFromEmailAddressNoEmailAddressSupplied()
        {
            User user = new User();
            user.GetForenameFromEmailAddress();
        }

        [Test]
        public void GetForenameFromEmailAddressValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones@email.com";
            user.GetForenameFromEmailAddress();
        }

        [Test]
        public void GetForenameFromEmailAddressInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "tom.jones1@email.com";
            user.GetForenameFromEmailAddress();
        }

        [Test]
        public void RetrieveUsernameNoEmailAddressSupplied()
        {
            User user = new User();
            user.RetrieveUsername();
        }

        [Test]
        public void RetrieveUsernameValidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "michael.upjohn@hotmail.co.uk";
            user.RetrieveUsername();
        }

        [Test]
        public void RetrieveUsernameInvalidEmailAddressSupplied()
        {
            User user = new User();
            user.EmailAddress = "michael.upjohn@hotmail.co.uk";
            user.RetrieveUsername();
        }

        [Test]
        public void GetUserIDFromUsernameNoUsernameSpecified()
        {
            User user = new User();
            user.GetUserIDFromUsername();
        }

        [Test]
        public void GetUserIDFromUsernameValidUsernameSpecified()
        {
            User user = new User();
            user.Username = new Username("mikeofmacc");
            user.GetUserIDFromUsername();
        }

        [Test]
        public void GetUserIDFromUsernameInvalidUsernameSpecified()
        {
            User user = new User();
            user.Username = new Username("mikeofmacc1");
            user.GetUserIDFromUsername();
        }
    }
}