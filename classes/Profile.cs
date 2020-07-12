using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace artefact
{
    public class Profile
    {
        private SqlConnection connection = new SqlConnection("Data Source=www.mike-upjohn.com;Initial Catalog=hswd;User ID=mikeofmacc;Password=F1b8leSurtSH");
        private User user;
        private string accountStatus;
        private bool isAdministrator;
        private DateTime profileCreated;
        private DateTime profileLastUsed;

        #region Properties
        /// <summary>
        /// User Property
        /// </summary>
        public User User
        {
            get
            {
                return user;
            }

            set
            {
                this.user = value;
            }
        }

        /// <summary>
        /// Account Status Property
        /// </summary>
        public string AccountStatus
        {
            get
            {
                return accountStatus;
            }

            set
            {
                this.accountStatus = value;
            }
        }

        /// <summary>
        /// Is Administrator Property
        /// </summary>
        public bool IsAdministrator
        {
            get
            {
                return isAdministrator;
            }

            set
            {
                this.isAdministrator = value;
            }
        }

        /// <summary>
        /// Profile Created Property
        /// </summary>
        public DateTime ProfileCreated
        {
            get
            {
                return profileCreated;
            }

            set
            {
                this.profileCreated = value;
            }
        }

        /// <summary>
        /// Profile Last User Property
        /// </summary>
        public DateTime ProfileLastUsed
        {
            get
            {
                return profileLastUsed;
            }

            set
            {
                this.profileLastUsed = value;
            }
        }
        #endregion

        #region Assigning a User to a Profile

        /// <summary>
        /// Assigns a user to this account.
        /// </summary>
        public void AssignUserToProfile()
        {
            DateTime now = DateTime.Now;
            int profileID = 0;
            int userID = 0;

            this.ProfileCreated = now;
            this.ProfileLastUsed = now;

            profileID = RegisterProfile();
            userID = GetUserIDOfGUID(user.Guid);
            RegisterUserProfile(userID, profileID);
        }
        #endregion

        #region Enabling a Profile

        /// <summary>
        /// Enable a users profile.
        /// </summary>
        /// <param name="guid">The GUID linked to this account.</param>
        /// <returns>True if the profile was enabled successfully, else false.</returns>
        public bool EnableProfile(Guid guid)
        {
            int userID = 0;
            int profileID = 0;

            userID = GetUserIDOfGUID(guid);

            if (userID != 0)
            {
                profileID = GetProfileIDOfUserID(userID);
            }

            if (profileID != 0)
            {
                if (IsProfileDisabled(profileID))
                {
                    if (ActivateProfile(profileID))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Get a count of the number of users that have this GUID.
        /// </summary>
        /// <param name="guid">The GUID of this user.</param>
        /// <returns>True if only one user is found with this GUID, else false.</returns>
        private bool GetCountOfUsersWithThisGUID(Guid guid)
        {
            if (guid != null)
            {
                int rows = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT COUNT([UserID]) FROM [dbo].[User] WHERE GUID='" + guid.ToString() + "'");
                command.Connection = connection;

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                rows = int.Parse(table.Rows[0][0].ToString());

                if (rows == 1)
                {
                    return true;
                }

                return false;
            }
            else
            {
                throw new Exception("Error 3002: When finding the number of users with a GUID, the GUID must not be left null.");
            }
        }

        /// <summary>
        /// Get the user ID of the user with this GUID.
        /// </summary>
        /// <param name="guid">The users GUID</param>
        /// <returns>The users ID</returns>
        private int GetUserID(Guid guid)
        {
            if (guid != null)
            {
                int userID = 0;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [UserID] FROM [dbo].[User] WHERE GUID ='" + guid.ToString() + "'");
                command.Connection = connection;

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    userID = int.Parse(table.Rows[0][0].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 3006: This user ID does not exist.");
                }

                return userID;
            }
            else
            {
                throw new Exception("Error 3007: The GUID was left null.");
            }
        }

        /// <summary>
        /// Gets the profile ID linked to this user ID.
        /// </summary>
        /// <param name="userID">The user ID of which to find the profile ID</param>
        /// <returns>The profile ID linked with this user ID.</returns>
        public int GetProfileIDOfUserID(int userID)
        {
            if (userID != int.MinValue)
            {
                int profileID = 0;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [ProfileID] FROM [dbo].[UserProfile] WHERE [UserID] = " + userID);
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    profileID = int.Parse(table.Rows[0][0].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 3005: This user ID for which you are retrieving the profile ID, does not exist.");
                }

                return profileID;
            }
            else
            {
                throw new Exception("Error 3004: When retrieving a profile ID of a user, the user ID must not be left null.");
            }
        }

        /// <summary>
        /// Check whether the profile is disabled or not.
        /// </summary>
        /// <param name="profileID">The profile ID to check the status of.</param>
        /// <returns>True if the profile is disabled still, else false.</returns>
        private bool IsProfileDisabled(int profileID)
        {
            if (profileID != int.MinValue)
            {
                string profileStatus = "";

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [ProfileActivityStatus] FROM [dbo].[Profile] WHERE [ProfileID] = " + profileID);
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    profileStatus = table.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 3009: No profile exists with this profile ID.");
                }

                if (profileStatus == "Disabled")
                {
                    return true;
                }

                return false;
            }
            else
            {
                throw new Exception("Error 3010: Profile ID was left null.");
            }
        }

        /// <summary>
        /// Activate this profile.
        /// </summary>
        /// <param name="profileID">The profile ID of the profile to activate.</param>
        /// <returns>True if the profile was activated, else false.</returns>
        private bool ActivateProfile(int profileID)
        {
            if (profileID != int.MinValue)
            {
                int rows = -99;

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [Profile] SET [ProfileActivityStatus] = 'Active' WHERE [ProfileID] = " + profileID;
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception("Error 3001: When activating a profile, the profile ID must not be null.");
            }
        }
        #endregion

        /// <summary>
        /// Get the user ID of the user with this GUID.
        /// </summary>
        /// <param name="guid">The GUID linked with this user.</param>
        /// <returns>The user ID, an integer value above zero, else zero to indicate an error.</returns>
        private int GetUserIDOfGUID(Guid guid)
        {
            if (guid != null)
            {
                int userID = -99;

                if (GetCountOfUsersWithThisGUID(guid))
                {
                    return GetUserID(guid);
                }

                return userID;
            }
            else
            {
                throw new Exception("Error 3008: The GUID was left null.");
            }
        }

        /// <summary>
        /// Disable this account
        /// </summary>
        /// <returns>True if the account was disabled successfully, else false.</returns>
        public bool DisableAccount()
        {
            // Not implemented yet. Will work exactly the same as ActivateProfile().
            return false;
        }

        /// <summary>
        /// Register a profile to a user.
        /// </summary>
        /// <returns>The registered profile ID.</returns>
        private int RegisterProfile()
        {
            if (this.AccountStatus != null && this.ProfileLastUsed != null && this.profileCreated != null)
            {
                int rows = -99;
                int profileID = 0;
                string profileType = "";

                if (!this.isAdministrator)
                {
                    profileType = "Standard";
                }
                else
                {
                    profileType = "Administrator";
                }

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO [dbo].[Profile] (ProfileType, ProfileActivityStatus, ProfileLastUsed, ProfileCreated) VALUES ('" + profileType + "','" + this.AccountStatus + "', '" + this.ProfileLastUsed.ToString("yyyy-MM-dd hh:mm:ss") + "', '" + this.ProfileCreated.ToString("yyyy-MM-dd hh:mm:ss") + "')";
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    profileID = GetProfileIDForUserProfile();
                }
                else
                {
                    throw new Exception("Contact an administrator! More than one row was inserted into the database for only one profile registration.");
                }

                return profileID;
            }
            else
            {
                throw new Exception("Error 3011: The minimum required values to register a profile were partly or fully null.");
            }
        }

        /// <summary>
        /// Get the profile ID of the profile that was inserted at a specified date and time.
        /// </summary>
        /// <returns>The profile ID.</returns>
        private int GetProfileIDForUserProfile()
        {
            if (this.ProfileCreated != DateTime.MinValue)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT ProfileID FROM Profile WHERE ProfileCreated = '" + this.ProfileCreated.ToString("yyyy-MM-dd hh:mm:ss") + "'");
                command.Connection = connection;

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                return int.Parse(table.Rows[0][0].ToString());
            }
            else
            {
                throw new Exception("Error 3003: To retrieve a profile ID, the profile created date must not be left null.");
            }
        } 

        /// <summary>
        /// Create a link between a user and their profile.
        /// </summary>
        /// <param name="userID">The user ID.</param>
        /// <param name="profileID">The profile ID.</param>
        private void RegisterUserProfile(int userID, int profileID)
        {
            if (userID != int.MinValue && profileID != int.MinValue)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO [dbo].[UserProfile] (UserID, ProfileID) VALUES (" + userID + ", " + profileID + ")";
                command.Connection = connection;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                throw new Exception("Error 3012: Either the user ID or the profile ID, or both were left null.");
            }
        }

        /// <summary>
        /// Update the last time this profile was logged in to, to now.
        /// </summary>
        /// <param name="profileID">The profile ID that has been logged in to.</param>
        /// <returns>True if the last log in time for this profile was updated succesfully, else false.</returns>
        public bool UpdateProfileLastLoginTime(int profileID) {
            if (profileID != int.MinValue)
            {
                int rows = -99;

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [Profile] SET [ProfileLastUsed] = '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "' WHERE [ProfileID] = " + profileID;
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error 3016: The profile ID does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 3015: The profile ID was null.");
            }
        }
    }
}