using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class ProfileTesting
    {
        // As all credentials are required for a successful transaction, only one test for missing credentials is needed.

        [Test]
        public void RegisterProfileNoCredentialsSpecified()
        {
            Profile profile = new Profile();
            profile.RegisterProfile();
        }

        [Test]
        public void RegisterProfileCredentialsSpecifiedStandardAccountSpecified()
        {
            Profile profile = new Profile();
            profile.IsAdministrator = false;
            profile.AccountStatus = "Disabled";
            profile.ProfileLastUsed = DateTime.Now;
            profile.ProfileCreated = DateTime.Now;
            profile.RegisterProfile();
        }

        [Test]
        public void RegisterProfileCredentialsSpecifiedAdministratorAccountSpecified()
        {
            Profile profile = new Profile();
            profile.IsAdministrator = true;
            profile.AccountStatus = "Disabled";
            profile.ProfileLastUsed = DateTime.Now;
            profile.ProfileCreated = DateTime.Now;
            profile.RegisterProfile();
        }

        [Test]
        public void GetProfileIDForUserProfileNoProfileCreatedDateSpecified()
        {
            Profile profile = new Profile();
            profile.GetProfileIDForUserProfile();
        }

        [Test]
        public void GetProfileIDForUserProfileProfileCreatedDateSpecified()
        {
            Profile profile = new Profile();
            profile.ProfileCreated = DateTime.Parse("05/03/2013 05:10:29");
            profile.GetProfileIDForUserProfile();
        }

        [Test]
        public void GetCountOfUsersWithThisGUIDNoGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetCountOfUsersWithThisGUID(Guid.Parse(null));
        }

        [Test]
        public void GetCountOfUsersWithThisGUIDValidGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetCountOfUsersWithThisGUID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a"));
        }

        [Test]
        public void GetCountOfUsersWithThisGUIDInvalidGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetCountOfUsersWithThisGUID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b"));
        }

        [Test]
        public void GetUserIDNoGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetUserID(Guid.Parse(null));
        }

        [Test]
        public void GetUserIDValidGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetUserID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a"));
        }

        [Test]
        public void GetUserIDInvalidGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetUserID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b"));
        }

        [Test]
        public void GetUserIDOfGUIDNoGUIDSpecified() {
            Profile profile = new Profile();
            profile.GetUserIDOfGUID(Guid.Parse(null));
        }

        [Test]
        public void GetUserIDOfGUIDValidGUIDSpecified() {
            Profile profile = new Profile();
            profile.GetUserIDOfGUID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3a"));
        }

        [Test]
        public void GetUserIDOfGUIDInvalidGUIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetUserIDOfGUID(Guid.Parse("e4c921eb-e359-44cd-86de-6f27d68fec3b"));
        }

        [Test]
        public void RegisterUserProfileNoUserIDNoProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.RegisterUserProfile(int.Parse(null), int.Parse(null));
        }

        [Test]
        public void RegisterUserProfileUserIDNoProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.RegisterUserProfile(999, int.Parse(null));
        }

        [Test]
        public void RegisterUserProfileNoUserIDProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.RegisterUserProfile(int.Parse(null), 999);
        }

        [Test]
        public void RegisterUserProfileUserIDProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.RegisterUserProfile(1000, 1000);
        }

        [Test]
        public void GetProfileIDOfUserIDNoUserIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetProfileIDOfUserID(int.Parse(null));
        }

        [Test]
        public void GetProfileIDOfUserIDValidUserIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetProfileIDOfUserID(13);
        }

        [Test]
        public void GetProfileIDOfUserIDInvalidUserIDSpecified()
        {
            Profile profile = new Profile();
            profile.GetProfileIDOfUserID(999);
        }

        [Test]
        public void IsProfileDisabledNoProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.IsProfileDisabled(int.Parse(null));
        }

        [Test]
        public void IsProfileDisabledProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.IsProfileDisabled(13);
        }

        [Test]
        public void IsProfileDisabledInvalidProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.IsProfileDisabled(999);
        }

        [Test]
        public void ActivateProfileNoProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.ActivateProfile(int.Parse(null));
        }

        [Test]
        public void ActivateProfileProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.ActivateProfile(13);
        }

        [Test]
        public void ActivateProfileInvalidProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.ActivateProfile(999);
        }

        [Test]
        public void UpdateProfileLastLoginTimeNoProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.UpdateProfileLastLoginTime(int.Parse(null));
        }

        [Test]
        public void UpdateProfileLastLoginTimeValidProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.UpdateProfileLastLoginTime(40);
        }

        [Test]
        public void UpdateProfileLastLoginTimeInvalidProfileIDSpecified()
        {
            Profile profile = new Profile();
            profile.UpdateProfileLastLoginTime(999);
        }
    }
}