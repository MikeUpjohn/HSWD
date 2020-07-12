using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using artefact.classes;

namespace artefact
{
    public class User
    {
        private SqlConnection connection = new SqlConnection("Data Source=www.mike-upjohn.com;Initial Catalog=hswd;User ID=mikeofmacc;Password=-Bbq~%4-W5U(");
        private int userID;
        private Guid guid;
        private string title;
        private string forename;
        private string surname;
        private string emailAddress;
        private Username username;
        private Password password;
        private Password temporaryPassword;
        private bool isLoggedIn;
        private Random random = new Random();

        #region Properties
        /// <summary>
        /// User ID Property
        /// </summary>
        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                this.userID = value;
            }
        }

        /// <summary>
        /// GUID Property
        /// </summary>
        public Guid Guid
        {
            get
            {
                return guid;
            }

            set
            {
                this.guid = value;
            }
        }

        /// <summary>
        /// Title Property
        /// </summary>
        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                this.title = value;
            }
        }

        /// <summary>
        /// Forename Property
        /// </summary>
        public string Forename
        {
            get
            {
                return forename;
            }

            set
            {
                this.forename = value;
            }
        }

        /// <summary>
        /// Surname Property
        /// </summary>
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                this.surname = value;
            }
        }

        /// <summary>
        /// E-Mail Address Property
        /// </summary>
        public string EmailAddress
        {
            get
            {
                return emailAddress;
            }

            set
            {
                this.emailAddress = value;
            }
        }

        /// <summary>
        /// Username Property
        /// </summary>
        public Username Username
        {
            get
            {
                return username;
            }

            set
            {
                this.username = value;
            }
        }

        /// <summary>
        /// Password Property
        /// </summary>
        public Password Password
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Temporary Password Property
        /// </summary>
        public Password TemporaryPassword
        {
            get
            {
                return temporaryPassword;
            }

            set
            {
                this.temporaryPassword = value;
            }
        }

        /// <summary>
        /// Is Logged In Property
        /// </summary>
        public bool IsLoggedIn
        {
            get
            {
                return isLoggedIn;
            }

            set
            {
                this.isLoggedIn = value;
            }
        }
        #endregion

        /// <summary>
        /// User Empty Constructor
        /// </summary>
        public User()
        {
            username = new Username();
            password = new Password();
            temporaryPassword = new Password();
        }

        /// <summary>
        /// Add this user and create them a profile, but do not activate it. Send a mail to the user's e-mail address to ask them to confirm their account.
        /// </summary>
        /// <returns>True if the user was added and the mail sent successfully, else false.</returns>
        public bool AddUser()
        {
            int userID = 0;
            userID = RegisterUser();

            if (userID != 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Register a user with the database.
        /// </summary>
        /// <returns>The ID of the user that was just registered. If the user is not registered correctly, be default return 0.</returns>
        private int RegisterUser()
        {
            if (this.Guid != null && this.Title != null && this.Forename != null && this.Surname != null && this.EmailAddress != null && this.Username != null && this.Password != null)
            {
                int rows = -99;
                int assignedUserID = 0;

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO [dbo].[User] (GUID, Title, Forename, Surname, EmailAddress, Username, Password, UserCreated) VALUES ('" + this.guid.ToString() + "', '" + this.Title + "', '" + this.Forename + "', '" + this.Surname + "', '" + this.EmailAddress + "', '" + this.Username.UserName + "', '" + this.Password.PassWord + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "')";
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    assignedUserID = GetUserIDFromGUID();
                }
                else
                {
                    throw new Exception("Error 4030: Your record was inserted twice or more.");
                }

                return assignedUserID;
            }
            else
            {
                throw new Exception("Error 4001: The minimum required data for adding a new user was partially or totally null.");
            }
        }

        /// <summary>
        /// Check this username to make sure it doesn't already exist.
        /// </summary>
        /// <param name="username">The username to check for its' existence.</param>
        /// <returns>True if the username was found, false if it was not, else throw an exception because there is more than one record of this username found.</returns>
        public bool CheckUsernameExistence() {
            if (this.Username != null)
            {
                int rows = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] WHERE Username='" + this.Username.UserName + "'");
                command.Connection = connection;

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                rows = int.Parse(table.Rows[0][0].ToString());

                if (rows == 0)
                {
                    return false;
                }
                else if (rows == 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error 4029: There are two users on record for this username in the database!");
                }
            }
            else
            {
                throw new Exception("Error 4005: The username was left null.");
            }
        }

        /// <summary>
        /// Check to see whether the GUID is valid
        /// </summary>
        /// <param name="guid">The GUID to be checked.</param>
        /// <returns>True if the GUID is found, else false.</returns>
        public bool CheckGUIDExistence()
        {
            if (guid != null)
            {
                int rows = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] WHERE GUID='" + this.Guid.ToString() + "'");
                command.Connection = connection;

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                rows = int.Parse(table.Rows[0][0].ToString());

                if (rows == 0)
                {
                    return false;
                }
                else if (rows == 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error 4028: There are two users on record for this username in the database!");
                }
            }
            else
            {
                throw new Exception("Error 4003: The GUID was left null.");
            }
        }

        /// <summary>
        /// Check this e-mail address to make sure it doesn't already exist.
        /// </summary>
        /// <returns>True if the e-mail address was found, false if the e-mail address wasn't found, else throw an exception as there is more than 1 record of this e-mail address in the database.</returns>
        public bool CheckEmailAddressExistence()
        {
            if (this.EmailAddress != null)
            {
                int rows = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] WHERE EmailAddress='" + this.EmailAddress + "'");
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                rows = int.Parse(table.Rows[0][0].ToString());

                if (rows == 0)
                {
                    return false;
                }
                else if (rows == 1)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error 4027: There are two users on record for this e-mail address in the database!");
                }
            }
            else
            {
                throw new Exception("Error 4002: The e-mail address was left null.");
            }
        }

        /// <summary>
        /// Gets the user ID of the user just added, searching by the unique GUID.
        /// </summary>
        /// <returns>The integer representation of the user ID of the user just added.</returns>
        private int GetUserIDFromGUID()
        {
            if (this.Guid != Guid.Empty)
            {
                int userID = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT UserID FROM [dbo].[User] WHERE GUID = '" + this.Guid.ToString() + "'");
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
                    throw new Exception("Error 4016: This GUID does not exist.");
                }

                return userID;
            }
            else
            {
                throw new Exception("Error 4015: The GUID was left null.");
            }
        }

        /// <summary>
        /// Log this user in if credentials supplied are valid.
        /// </summary>
        /// <param name="loginErrors">A string representation of the current validation errors with the login form.</param>
        /// <returns>True if the login was successful, else false</returns>
        public bool Login(ref string loginErrors)
        {
            if (CheckUsernameExistence())
            {
                if (CheckPasswordForThisUsername())
                {
                    this.isLoggedIn = true;
                    return true;
                }
                else
                {
                    loginErrors += "The login credentials supplied are invalid or the account is not yet active. Please try again.<br/>";
                    return false;
                }
            }
            else
            {
                loginErrors += "The login credentials supplied are invalid. Please try again.<br/>";
                return false;
            }

        }

        /// <summary>
        /// Check that the password entered for this username is valid.
        /// </summary>
        /// <returns>True if the credentials are valid, else false.</returns>
        private bool CheckPasswordForThisUsername()
        {
            if (this.Username != null && this.Password != null)
            {
                int rows = -99;

                DataTable table = new DataTable();
                //SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] WHERE Username='" + this.Username.UserName + "' AND Password='" + this.Password.PassWord + "'");

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] INNER JOIN [dbo].[UserProfile] ON [dbo].[User].[UserID] = [dbo].[UserProfile].[UserID] INNER JOIN [dbo].[Profile] ON [dbo].[UserProfile].[ProfileID] = [dbo].[Profile].[ProfileID] WHERE [dbo].[User].[Username] = '" + this.Username.UserName + "' AND [dbo].[User].[Password] = '" + this.Password.PassWord + "' AND [dbo].[Profile].[ProfileActivityStatus] = 'Active'");

                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connection.Open();
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                rows = int.Parse(table.Rows[0][0].ToString());

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
                throw new Exception("Error 4004: Either the username of password was left null.");
            }
        }

        /// <summary>
        /// Generates a temporary password that can be used to reset a password in future and mails this to the user.
        /// </summary>
        /// <returns>True if the temporary password was generated and a mail sent</returns>
        public bool GenerateTemporaryUserPassword()
        {
            this.TemporaryPassword = new Password();
            this.TemporaryPassword.GenerateTemporaryPassword();
            return true;
        }

        /// <summary>
        /// Mail the user the password reset e-mail.
        /// </summary>
        public void MailUserPasswordResetEmail()
        {
            if (this.EmailAddress != null && this.Forename != null && this.TemporaryPassword != null)
            {
                // Mail the user the new password
                Mail resetPasswordMail = new Mail();
                resetPasswordMail.FromAddress = "historical-severe-weather-database@hotmail.com";
                resetPasswordMail.ToAddress = this.EmailAddress;
                resetPasswordMail.Subject = "Historical Severe Weather Database - Password Reset Request";
                resetPasswordMail.Body =
                    "Dear " + this.Forename + ",\n\n" +
                    "We believe that you have requested your password to be reset. Your new temporary password is below:-\n\n" +
                    this.TemporaryPassword.PassWord + "\n\n" +
                    "If this was not you making this request, please contact our administrator through the website. To continue please" +
                    "continue to the next step on the website and exchange the temporary password for a new password of your choice.\n\n" +
                    "Thank you,\n" +
                    "HSWD";

                resetPasswordMail.SendMail();
            }
            else
            {
                throw new Exception("Error 4012: The minimum credentials to mail a user the password reset e-mail were null.");
            }
        }

        /// <summary>
        /// Store the newly generated temporary password in the database.
        /// </summary>
        /// <returns>True if the temporary password was stored successfully.</returns>
        public bool StoreTemporaryPassword()
        {
            if (this.TemporaryPassword != null && this.Username != null)
            {
                int rows = -99;

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [User] SET [TemporaryPassword] = '" + this.TemporaryPassword.PassWord + "' WHERE [Username] = '" + this.Username.UserName + "'";
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    return true;
                }

                return false;
            }
            else
            {
                throw new Exception("Error 4014: The data required to store the temporary password was partially or fully null.");
            }
        }

        /// <summary>
        /// Get a GUID of a user given the username
        /// </summary>
        public void GetGUIDFromUsername()
        {
            if (this.username != null)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [GUID] FROM [dbo].[User] WHERE [Username] = '" + this.Username.UserName + "'");

                command.Connection = connection;
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    this.Guid = Guid.Parse(table.Rows[0][0].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4009: This username does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4010: This username is null.");
            }
        }

        /// <summary>
        /// Get an e-mail address based on the GUID.
        /// </summary>
        public void GetEmailFromGUID()
        {
            if (this.Guid != Guid.Empty)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [EmailAddress] FROM [dbo].[User] WHERE [GUID] = '" + this.Guid.ToString() + "'");

                command.Connection = connection;
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    this.EmailAddress = table.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4006: This GUID does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4017: The GUID was left null.");
            }
        }

        /// <summary>
        /// Get the users forename given the GUID
        /// </summary>
        public void GetForenameFromGUID()
        {
            if (this.Guid != Guid.Empty)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [Forename] FROM [dbo].[User] WHERE [GUID] = '" + this.Guid.ToString() + "'");

                command.Connection = connection;
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    this.Forename = table.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4007: This GUID does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4018: This GUID was left null.");
            }
        }

        /// <summary>
        /// Get the users temporary password from their GUID.
        /// </summary>
        public void GetTemporaryPasswordFromGUID()
        {
            if (this.Guid != Guid.Empty)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [TemporaryPassword] FROm [dbo].[User] WHERE [GUID] = '" + this.Guid.ToString() + "'");

                command.Connection = connection;
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    this.TemporaryPassword = new Password(table.Rows[0][0].ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4020: This GUID does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4019: The GUID was left null.");
            }
        }

        /// <summary>
        /// Resets a password for a user, given a good temporary password.
        /// </summary>
        /// <returns>True if the password was succesfully reset, else false.</returns>
        public bool ResetPassword()
        {
            if (this.Password != null && this.Guid != null)
            {
                int rows = -99;
                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "UPDATE [User] SET [Password] = '" + this.Password.PassWord + "' WHERE [GUID] = '" + this.Guid.ToString() + "'";
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    command.CommandText = "UPDATE [User] SET [TemporaryPassword] = '' WHERE [GUID] = '" + this.Guid.ToString() + "'";

                    connection.Open();
                    rows = command.ExecuteNonQuery();
                    connection.Close();

                    if (rows == 1)
                    {
                        return true;
                    }

                    return false;
                }

                return false;
            }
            else
            {
                throw new Exception("Error 4013: The required data to reset a password was partially or fully null.");
            }
        }

        /// <summary>
        /// Retrieve this users username
        /// </summary>
        /// <returns>True if the username was retrieved successfully, else false.</returns>
        public bool RetrieveUsername()
        {
            if (this.EmailAddress != null)
            {
                this.username = new Username(GetUsernameFromEmailAddress());
                this.forename = GetForenameFromEmailAddress();

                // Mail the user the new password
                Mail usernameReminderMail = new Mail();
                usernameReminderMail.FromAddress = "historical-severe-weather-database@hotmail.com";
                usernameReminderMail.ToAddress = this.EmailAddress;
                usernameReminderMail.Subject = "Historical Severe Weather Database - Username Reminder Request";
                usernameReminderMail.Body =
                    "Dear " + this.Forename + ",\n\n" +
                    "We believe that you have requested a reminder of your username. Your username is:-\n\n" +
                    this.Username.UserName + "\n\n" +
                    "If this was not you making this request, please contact our administrator through the website.\n\n" +
                    "Thank you,\n" +
                    "HSWD";

                usernameReminderMail.SendMail();

                return true;
            }
            else
            {
                throw new Exception("Error 4021: The e-mail address was left null.");
            }
        }

        /// <summary>
        /// Get the username linked with an e-mail address.
        /// </summary>
        /// <returns></returns>
        private string GetUsernameFromEmailAddress()
        {
            string username = "";

            if (GetCountOfEmailAddress())
            {
                username = GetUsername();
            }
            else
            {
                throw new Exception("Error 4026: This e-mail address was not found.");
            }

            return username;
        }

        /// <summary>
        /// Get a count of the number of users with this e-mail address.
        /// </summary>
        /// <returns>True if only one user is found, else false.</returns>
        private bool GetCountOfEmailAddress()
        {
            if (this.EmailAddress != null)
            {
                int rows = -99;

                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM [dbo].[User] WHERE [EmailAddress] = '" + this.EmailAddress + "'");
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
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
                throw new Exception("Error 4022: The e-mail address was left null.");
            }
        }
        
        /// <summary>
        /// Get the username for a specific e-mail address.
        /// </summary>
        /// <returns>The username of the specified e-mail address.</returns>
        private string GetUsername()
        {
            if (this.EmailAddress != null)
            {
                DataTable table = new DataTable();

                SqlCommand command = new SqlCommand("SELECT [Username] FROM [dbo].[User] WHERE [EmailAddress] = '" + this.EmailAddress + "'");
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    return table.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4011: This e-mail address does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4023: The e-mail address was left null.");
            }
        }

        /// <summary>
        /// Get a users forename from the specified e-mail address.
        /// </summary>
        /// <returns>The users forename</returns>
        private string GetForenameFromEmailAddress()
        {
            string forename = "";

            if (GetCountOfEmailAddress())
            {
                forename = GetForename();
            }
            else
            {
                throw new Exception("Error 4025: This e-mail address was not found.");
            }

            return forename;
        }

        /// <summary>
        /// Get the forename from a specified e-mail address.
        /// </summary>
        /// <returns>The forename of the specified e-mail address.</returns>
        private string GetForename()
        {
            if (this.EmailAddress != null)
            {
                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [Forename] FROM [dbo].[User] WHERE [EmailAddress] ='" + this.EmailAddress + "'");
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                try
                {
                    return table.Rows[0][0].ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.StackTrace);
                    throw new Exception("Error 4008: This e-mail address does not exist.");
                }
            }
            else
            {
                throw new Exception("Error 4024: The e-mail address was left null.");
            }
        }

        /// <summary>
        /// Get User ID from a specified username.
        /// </summary>
        /// <returns>A user ID.</returns>
        public int GetUserIDFromUsername()
        {
            if (this.Username != null)
            {
                int userID = -99;

                DataTable table = new DataTable();
                SqlCommand command = new SqlCommand("SELECT [UserID] FROM [dbo].[User] WHERE Username='" + this.Username.UserName + "'");
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
                    throw new Exception("Error 4032: This username does not exist.");
                }

                return userID;
            }
            else
            {
                throw new Exception("Error 4031: The username is null.");
            }
        }
    }
}