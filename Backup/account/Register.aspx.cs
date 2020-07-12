using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using artefact.classes;

namespace artefact.account
{
    public partial class Register : System.Web.UI.Page
    {
        User user;
        Profile profile;

        /// <summary>
        /// Executed when the Register page loads.
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
                int screen = 0;
                string screenValue = Request.QueryString["screen"];

                // Initialise this here so that it is available on screen 3
                profile = new Profile();

                if (screenValue != null)
                {
                    screen = int.Parse(screenValue);
                }

                if (screen == 1)
                {
                    Panel_FirstScreen.Visible = true;
                    Panel_SecondScreen.Visible = false;
                    Panel_ThirdScreen.Visible = false;
                }
                else if (screen == 2)
                {
                    Panel_FirstScreen.Visible = false;
                    Panel_SecondScreen.Visible = true;
                    Panel_ThirdScreen.Visible = false;
                }
                else if (screen == 3)
                {
                    Panel_FirstScreen.Visible = false;
                    Panel_SecondScreen.Visible = false;
                    Panel_ThirdScreen.Visible = true;

                    if (profile.EnableProfile(Guid.Parse(Request.QueryString["guid"])))
                    {
                        Response.Redirect("Login.aspx");
                    }
                }
                else
                {
                    Response.Redirect("Register.aspx?screen=1");
                }
            }
        }

        /// <summary>
        /// Executed when the Register button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_Register_Click(object sender, EventArgs e)
        {
            string validationErrors = "";
            string title = DropDownList_Title.SelectedValue;
            string forename = TextBox_Forename.Text;
            string surname = TextBox_Surname.Text;
            string emailAddress = TextBox_EmailAddress.Text;
            string userName = TextBox_Username.Text;
            string password = TextBox_Password.Text;

            Password passWord = new Password(password);
            Username username = CreateUsername(userName);

            // Create this user
            user = new User();
            user.Title = title;
            user.Forename = forename;
            user.Surname = surname;
            user.EmailAddress = emailAddress;
            user.Username = username;
            user.Password = passWord;
            user.IsLoggedIn = false;

            CreateProfile();

            if (ValidateRegistrationForm(ref validationErrors))
            {
                
                Guid guid = Guid.NewGuid();
                bool userAdded;

                user.Password.HashPassword();

                user.Guid = guid;
                userAdded = user.AddUser();

                if (userAdded)
                {
                    profile.User = user;
                    profile.AssignUserToProfile();

                    SendRegistrationConfirmationEmail(guid);
                    Response.Redirect("Register.aspx?screen=2");
                }
            }
            else
            {
                PrintValidationErrors(validationErrors);
            }
        }

        /// <summary>
        /// Create the users chosen username
        /// </summary>
        /// <param name="userName">The string representation of the username</param>
        /// <returns>The users username</returns>
        private Username CreateUsername(string userName)
        {
            Username username = new Username();
            username.UserName = userName;
            return username;
        }

        /// <summary>
        /// Create a profile for this user.
        /// </summary>
        private void CreateProfile()
        {
            profile.IsAdministrator = false;
            profile.User = user;
            profile.AccountStatus = "Disabled";
            profile.ProfileCreated = DateTime.Now;
            profile.ProfileLastUsed = DateTime.Now;
        }

        /// <summary>
        /// Print any validation errors that occur as a result of bad data in the form. Only gets called if there are validation errors.
        /// </summary>
        /// <param name="validationErrors">The string of validation errors.</param>
        private void PrintValidationErrors(string validationErrors)
        {
            Panel_ValidationErrors.Visible = true;
            Label_ValidationErrors.Visible = true;

            Label_ValidationErrors.Text = validationErrors;
        }

        /// <summary>
        /// Send a confirmation e-mail message of registration with a link to activate the account.
        /// </summary>
        /// <param name="guid">The GUID of this user.</param>
        private void SendRegistrationConfirmationEmail(Guid guid)
        {
            Mail confirmationMail = new Mail();
            confirmationMail.FromAddress = "historical-severe-weather-database@hotmail.com";
            confirmationMail.ToAddress = user.EmailAddress;
            confirmationMail.Subject = "Historical Severe Weather Database - Account Verification";
            confirmationMail.Body =
                "Dear " + user.Forename + "," +
                "\n\n" +
                "Thank-you very much for registering with HSWD. We hope you enjoy future use of the site." +
                "To verify that you are not a robot please visit the following link to activate the account:-\n" +
                "http://www.mike-upjohn.com/account/Register.aspx?screen=3&guid=" + guid +
                "\n\n" +
                "Thank-you and best regards,\nHSWD Team";

            confirmationMail.SendMail();
        }

        /// <summary>
        /// Validate the fields in the registration form an issue appropriate errors if necessary.
        /// </summary>
        /// <param name="validationErrors">A string representation that will hold all validation errors for output to the screen.</param>
        /// <returns>True if the registration form validates, else false.</returns>
        private bool ValidateRegistrationForm(ref string validationErrors)
        {
            bool validRegistration = true;
            bool termsAndConditionsAccepted = false;
            string confirmEmailAddress = TextBox_ConfirmEmailAddress.Text;
            string confirmPassword = TextBox_ConfirmPassword.Text;

            // Validating the Title field
            if (user.Title == "---")
            {
                validationErrors += "The <b>title</b> field was left blank. Please select a title and try again.<br/>";
                DropDownList_Title.Focus();
                validRegistration = false;
            }

            // Validating the Forename field
            // Setting up the Regex for detecting invalid characters in the forename field
            Match forenameMatch = Regex.Match(user.Forename, "^[A-Za-z]+$", RegexOptions.IgnoreCase);

            if (user.Forename == "")
            {
                validationErrors += "The <b>forename</b> field was left blank. Please enter your forename and try again.<br/>";
                TextBox_Forename.Focus();
                validRegistration = false;
            }
            else if (user.Forename.Length > 50)
            {
                validationErrors += "The <b>forename</b> field is too long. Please shorten your forename and try again.<br/>";
                TextBox_Forename.Focus();
                validRegistration = false;
            }

            if (user.Forename != "")
            {
                if (!forenameMatch.Success)
                {
                    validationErrors += "The <b>forename</b> field contains invalid characters. Please remove these characters and try again.<br/>";
                    TextBox_Forename.Focus();
                    validRegistration = false;
                }
            }

            // Validating the Surname field
            // Setting up the Regex for detecting invalid characters in the surname field
            Match surnameMatch = Regex.Match(user.Surname, "^[A-Za-z]+$", RegexOptions.IgnoreCase);
            if (user.Surname == "")
            {
                validationErrors += "The <b>surname</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Surname.Focus();
                validRegistration = false;
            }
            else if (user.Surname.Length > 50)
            {
                validationErrors += "The <b>surname</b> field is too long. Please shorten your surname and try again.<br/>";
                TextBox_Surname.Focus();
                validRegistration = false;
            }

            if (user.Surname != "")
            {
                if (!surnameMatch.Success)
                {
                    validationErrors += "The <b>surname</b> field contains invalid characters. Please remove these characters and try again.<br/>";
                    TextBox_Surname.Focus();
                    validRegistration = false;
                }
            }

            // Validating the E-mail address field
            // Setting up the Regex for detecting invalid characters in the email address
            //Match emailAddressMatch = Regex.Match(user.EmailAddress, "^[a-zA-Z0-9@._]+$", RegexOptions.IgnoreCase);

            if (user.EmailAddress == "")
            {
                validationErrors += "The <b>e-mail address</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_EmailAddress.Focus();
                validRegistration = false;
            }
            else if (user.EmailAddress.Length > 150)
            {
                validationErrors += "The <b>e-mail address</b> field is too long. Please shorten your e-mail address and try again.<br/>";
                TextBox_EmailAddress.Focus();
                validRegistration = false;
            }

            /*if (user.EmailAddress != "")
            {
                if (!emailAddressMatch.Success)
                {
                    validationErrors += "The <b>e-mail address</b> did not contain the required characters for a valid e-mail address. Please alter your e-mail address and then try again.<br/>";
                    TextBox_EmailAddress.Focus();
                    validRegistration = false;
                }
            }*/

            /*if (user.EmailAddress != "")
            {
                if (!(user.EmailAddress.Contains(".") && user.EmailAddress.Contains("@")))
                {
                    validationErrors += "The <b>e-mail address</b> did not conform to the standard e-mail address format. Please alter your e-mail address and then try again.<br/>";
                    TextBox_EmailAddress.Focus();
                    validRegistration = false;
                }
            }*/

            if (user.CheckEmailAddressExistence())
            {
                validationErrors += "The <b>e-mail address</b> entered is already registered. Please choose a different e-mail address and try again.<br/>";
                TextBox_EmailAddress.Focus();
                validRegistration = false;
            }

            // Validating the confirm email address field
            // Setting up the Regex for detecting invalid characters in the confirm email address
            /**
             * With thanks to http://stackoverflow.com/questions/2652500/email-regular-expression-validation
             **/
           //Match confirmEmailAddressMatch = Regex.Match(confirmEmailAddress, "^[a-zA-Z0-9@._]+$", RegexOptions.IgnoreCase);

            if (confirmEmailAddress == "")
            {
                validationErrors += "The <b>confirmation e-mail address</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_ConfirmEmailAddress.Focus();
                validRegistration = false;
            }
            else if (confirmEmailAddress.Length > 150)
            {
                validationErrors += "The <b>confirmation e-mail address</b> field is too long. Please shorten this and try again.<br/>";
                TextBox_ConfirmEmailAddress.Focus();
                validRegistration = false;
            }

            /*if (user.EmailAddress != "")
            {
                if (!confirmEmailAddressMatch.Success)
                {
                    validationErrors += "The <b>confirmation e-mail address</b> field cdid not contain the required characters for a valid e-mail address. Please alter your e-mail address and then try again.<br/>";
                    TextBox_ConfirmEmailAddress.Focus();
                    validRegistration = false;
                }
            }*/

            if (user.EmailAddress != confirmEmailAddress)
            {
                validationErrors += "The <b>e-mail address</b> and <b>confirmation e-mail address</b> you entered do not match. Please re-enter these and try again.<br/>";
                TextBox_EmailAddress.Text = "";
                TextBox_ConfirmEmailAddress.Text = "";
                TextBox_EmailAddress.Focus();
                validRegistration = false;
            }

            // Validating username field
            // Setting up the Regex for the username field
            Match usernameMatch = Regex.Match(user.Username.UserName, "^[A-Za-z0-9-]+$", RegexOptions.IgnoreCase);

            if (user.Username.UserName == "")
            {
                validationErrors += "The <b>username</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }
            else if (user.Username.UserName.Length > 30)
            {
                validationErrors += "The <b>username</b> entered is too long. Please shorten the username and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }

            if (user.Username.UserName != "")
            {
                if (!usernameMatch.Success)
                {
                    validationErrors += "The <b>username</b> entered contains invalid characters. Please remove these characters and try again.<br/>";
                    TextBox_Username.Focus();
                    validRegistration = false;
                }
            }

            if (user.CheckUsernameExistence())
            {
                validationErrors += "The <b>username</b> entered is already taken. Please choose another username and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }

            // Validate password field
            // Settings up the Regex for the password field
            /**
             * With thanks to http://stackoverflow.com/questions/9477906/password-must-be-8-characters-including-1-uppercase-letter-1-special-character
             **/
            Match passwordMatch = Regex.Match(user.Password.PassWord, "^[A-Za-z0-9+-/*]+$", RegexOptions.IgnoreCase);
            if (user.Password.PassWord == "")
            {
                validationErrors += "The <b>password</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }
            else if (user.Password.PassWord.Length > 0 && user.Password.PassWord.Length < 8)
            {
                validationErrors += "The <b>password</b> field is too short. Please choose a pasword of at least 8 characters.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }
            else if (user.Password.PassWord.Length > 50)
            {
                validationErrors += "The <b>password</b> entered is too long. Please shorten the password and try again.<br/>";
                TextBox_Password.Focus();
                validRegistration = false;
            }

            if (user.Password.PassWord != "")
            {
                if (!passwordMatch.Success)
                {
                    validationErrors += "The <b>password</b> entered contains some invalid characters. Please ensure the password contains a minimum of 8 characters of which one is an uppercase English character, a lowercase English character and a digit.<br/>";
                    TextBox_Password.Focus();
                    validRegistration = false;
                }
            }

            // Validate confirm password field
            // Settings up the Regex for the confirm password field
            /**
             * With thanks to http://stackoverflow.com/questions/9477906/password-must-be-8-characters-including-1-uppercase-letter-1-special-character
             **/
            Match confirmPasswordMatch = Regex.Match(confirmPassword, @"[A-Za-z0-9]", RegexOptions.IgnoreCase);

            if (confirmPassword == "")
            {
                validationErrors += "The <b>confirmation password</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_ConfirmPassword.Focus();
                validRegistration = false;
            }
            else if (confirmPassword.Length > 0 && confirmPassword.Length < 8)
            {
                validationErrors += "The <b>confirmation password</b> field is too short. Please choose a password of at least 8 characters.<br/>";
                TextBox_ConfirmPassword.Focus();
                validRegistration = false;
            }
            else if (confirmPassword.Length > 50)
            {
                validationErrors += "The <b>confirmation password</b> field is too long. Please shorten the password and try again.<br/>";
                TextBox_ConfirmPassword.Focus();
                validRegistration = false;
            }

            if (!confirmPasswordMatch.Success)
            {
                validationErrors += "The <b>confirmation password</b> entered contains some invalid characters. Please ensure the confirmation password contains a minimum of 8 characters of which one is an uppercase English character, a lowercase English character and a digit.<br/>";
                TextBox_ConfirmPassword.Focus();
                validRegistration = false;
            }

            // Check the password and confirm password fields match.
            if (user.Password.PassWord != confirmPassword)
            {
                validationErrors += "The <b>password</b> and <b>confirmation password</b> you entered do not match. Please re-enter these and try again.<br/>";
                TextBox_Password.Text = "";
                TextBox_ConfirmPassword.Text = "";
                TextBox_Password.Focus();
                validRegistration = false;
            }

            if (CheckBox_TermsAndConditions.Checked)
            {
                termsAndConditionsAccepted = true;
            }
            else
            {
                termsAndConditionsAccepted = false;
            }

            if (!termsAndConditionsAccepted)
            {
                validationErrors += "The <b>terms and conditions</b> were not accepted. Please read and accept these and then try again.<br/>";
                validRegistration = false;
            }

            return validRegistration;
        }
    }
}