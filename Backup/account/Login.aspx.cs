using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using artefact.enums;

namespace artefact.account
{
    public partial class Login : System.Web.UI.Page
    {
        User user;
        Profile profile;

        /// <summary>
        /// Executed when the Login page loads.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                Response.Redirect("../Default.aspx"); 
            }
            else
            {
                user = new User();
                profile = new Profile();
            }
        }

        /// <summary>
        /// Executed when the Login button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_Login_Click(object sender, EventArgs e)
        {
            string loginCredentialErrors = "";
            string validationErrors = "";
            int userID = 0;
            int profileID = 0;

            Label_ValidationErrors.Text = "";

            user.Username = new Username(TextBox_Username.Text);
            user.Password = new Password(TextBox_Password.Text);

            if (ValidateLoginForm(user, ref validationErrors))
            {
                user.Password.HashPassword();
                if (user.Login(ref loginCredentialErrors))
                {
                    userID = user.GetUserIDFromUsername();
                    profileID = profile.GetProfileIDOfUserID(userID);
                    if (profile.UpdateProfileLastLoginTime(profileID))
                    {
                        Session["loggedIn"] = 1;
                        Session["username"] = user.Username.UserName;
                        Response.Redirect("../Default.aspx");
                    }
                }
                else
                {
                    Panel_ValidationErrors.Visible = true;
                    Label_ValidationErrors.Visible = true;
                    Label_ValidationErrors.Text += loginCredentialErrors;
                }
            }
            else
            {
                Panel_ValidationErrors.Visible = true;
                Label_ValidationErrors.Visible = true;
                Label_ValidationErrors.Text = validationErrors;
            }
        }

        /// <summary>
        /// Validate the login form credentials.
        /// </summary>
        /// <param name="user">The user who is attempting to log in.</param>
        /// <returns>True if all the fields on the form validate, else false.</returns>
        private bool ValidateLoginForm(User user, ref string validationErrors)
        {
            bool validRegistration = true;

            // Validating username field
            // Setting up the Regex for the username field
            Match usernameMatch = Regex.Match(user.Username.UserName, "^[a-zA-Z0-9-]+$", RegexOptions.IgnoreCase);

            if (user.Username.UserName == "")
            {
                validationErrors += "The <b>username</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }
            /*else if (user.Username.UserName.Length > 0 && user.Username.UserName.Length < 6)
            {
                validationErrors += "The <b>username</b> entered is too short. Please try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }*/
            else if (user.Username.UserName.Length > 30)
            {
                validationErrors += "The <b>username</b> entered is too long. Please shorten the username and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }

            // Don't want to see this error too if we already know that the username field is blank.
            if (user.Username.UserName != "")
            {
                if (!usernameMatch.Success)
                {
                    validationErrors += "The <b>username</b> entered contains invalid characters. Please remove these characters and try again.<br/>";
                    TextBox_Username.Focus();
                    validRegistration = false;
                }
            }

            // Validate password field
            // Settings up the Regex for the password field
            /**
             * With thanks to http://stackoverflow.com/questions/9477906/password-must-be-8-characters-including-1-uppercase-letter-1-special-character
             **/
            Match passwordMatch = Regex.Match(user.Password.PassWord, "^[a-zA-Z0-9-+/*]+$", RegexOptions.IgnoreCase);
            if (user.Password.PassWord == "")
            {
                validationErrors += "The <b>password</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }
            else if (user.Password.PassWord.Length > 0 && user.Password.PassWord.Length < 8)
            {
                validationErrors += "The <b>password</b> field is too short. Please try again.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }
            else if (user.Password.PassWord.Length > 50)
            {
                validationErrors += "The <b>password</b> entered is too long. Please shorten the password and try again.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }

            if (user.Password.PassWord != null)
            {
                if (!passwordMatch.Success)
                {
                    validationErrors += "The <b>password</b> you entered contains invalid characters. Please try again.<br/>";
                    TextBox_Password.Focus();
                    validRegistration = false;
                }
            }

            // Don't want to see this error if we already know that the username or password is null.
            if (validRegistration)
            {
                // As these have the same resulting error message for security reasons, test both the username and password condition together and display the error only once.
                if (!user.CheckUsernameExistence())
                {
                    validationErrors += "The credentials you entered are not found. Please try again.<br/>";
                    TextBox_Password.Focus();
                    validRegistration = false;
                }
            }

            return validRegistration;
        }
    }
}