using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;

namespace artefact.account.forgotten_password
{
    public partial class forgotten_password : System.Web.UI.Page
    {
        User user;

        /// <summary>
        /// Executed when the Forgotten Password page loads
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                Response.Redirect("../../Default.aspx");
            }
            else
            {
                int screen = 0;
                user = new User();

                string screenValue = Request.QueryString["screen"];

                if (screenValue != null)
                {
                    screen = int.Parse(Request.QueryString["screen"]);
                }

                if (screen == 1)
                {
                    Panel_ScreenOne.Visible = true;
                    Panel_ScreenTwo.Visible = false;
                    Panel_ScreenThree.Visible = false;
                    Panel_ScreenFour.Visible = false;
                }
                else if (screen == 2)
                {
                    Panel_ScreenOne.Visible = false;
                    Panel_ScreenTwo.Visible = true;
                    Panel_ScreenThree.Visible = false;
                    Panel_ScreenFour.Visible = false;
                }
                else if (screen == 3)
                {
                    Panel_ScreenOne.Visible = false;
                    Panel_ScreenTwo.Visible = false;
                    Panel_ScreenThree.Visible = true;
                    Panel_ScreenFour.Visible = false;
                }
                else if (screen == 4)
                {
                    Panel_ScreenOne.Visible = false;
                    Panel_ScreenTwo.Visible = false;
                    Panel_ScreenThree.Visible = false;
                    Panel_ScreenFour.Visible = true;

                    Label_FourthScreenValidationText.Text = "Your <b>password</b> has successfully been changed. You can now login.<br/>";
                }
                else
                {
                    Response.Redirect("../Login.aspx");
                }
            }
        }

        /// <summary>
        /// Executed when the reset password button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_ResetPassword_Click(object sender, EventArgs e)
        {
            string validationErrors = "";
            Label_FirstScreenValidationErrors.Text = "";
            
            user.Username = new Username(TextBox_Username.Text);

            if (ValidateResetPasswordFormFirstScreen(user.Username, ref validationErrors))
            {
                if (user.CheckUsernameExistence())
                {
                    if (user.GenerateTemporaryUserPassword())
                    {
                        if (user.StoreTemporaryPassword())
                        {
                            user.GetGUIDFromUsername();
                            user.GetEmailFromGUID();
                            user.GetForenameFromGUID();
                            user.MailUserPasswordResetEmail();
                            Response.Redirect("ForgottenPassword.aspx?screen=2&guid=" + user.Guid.ToString());
                        }
                    }
                }
                else
                {
                    Panel_FirstScreenValidationErrors.Visible = true;
                    Label_FirstScreenValidationErrors.Visible = true;
                    Label_FirstScreenValidationErrors.Text = "The <b>username</b> you entered was not found. Please try again.<br/>";
                }
            }
            else
            {
                Panel_FirstScreenValidationErrors.Visible = true;
                Label_FirstScreenValidationErrors.Visible = true;

                Label_FirstScreenValidationErrors.Text += validationErrors;
            }
        }

        /// <summary>
        /// Executed when the 'I Have The E-mail' button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_IHaveTheEmail_Click(object sender, EventArgs e)
        {
            user.Guid = Guid.Parse(Request.QueryString["guid"]);
            /*user.GetUser(true, true, true);*/
            Response.Redirect("ForgottenPassword.aspx?screen=3&guid=" + user.Guid.ToString());
        }

        /// <summary>
        /// Executed when the Change Password button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            string validationErrors = "";
            Password temporaryPassword = new Password(TextBox_TemporaryPassword.Text);
            Password newPassword = new Password(TextBox_NewPassword.Text);
            Password confirmNewPassword = new Password(TextBox_ConfirmNewPassword.Text);

            if (ValidateChangePasswordForm(temporaryPassword, newPassword, confirmNewPassword, ref validationErrors))
            {
                // Check the temporary password for a user with this GUID.
                user.Guid = Guid.Parse(Request.QueryString["guid"].ToString());
                user.GetTemporaryPasswordFromGUID();
                if (user.TemporaryPassword.PassWord == temporaryPassword.PassWord)
                {
                    user.Password = newPassword;
                    user.Password.HashPassword();

                    if (user.ResetPassword())
                    {
                        Response.Redirect("ForgottenPassword.aspx?screen=4");
                    }
                }
                else
                {
                    Panel_ThirdScreenValidationErrors.Visible = true;
                    Label_ThirdScreenValidationErrors.Visible = true;
                    validationErrors += "The <b>temporary password</b> specified is not recognised.<br/>";
                    Label_ThirdScreenValidationErrors.Text = validationErrors;
                }
            }
            else
            {
                Panel_ThirdScreenValidationErrors.Visible = true;
                Label_ThirdScreenValidationErrors.Visible = true;
                Label_ThirdScreenValidationErrors.Text = validationErrors;
            }
        }

        /// <summary>
        /// Validate the username entered into the forgotten password field.
        /// </summary>
        /// <param name="username">The username input to validate.</param>
        /// <returns>True if the form validates, else false.</returns>
        private bool ValidateResetPasswordFormFirstScreen(Username username, ref string validationErrors)
        {
            bool validRegistration = true;

            // Validating username field
            // Setting up the Regex for the username field
            Match usernameMatch = Regex.Match(username.UserName, "^[A-Za-z0-9-]+$", RegexOptions.IgnoreCase);

            if (username.UserName == "")
            {
                validationErrors += "The <b>username</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }
            else if (username.UserName.Length > 30)
            {
                validationErrors += "The <b>username</b> entered is too long. Please shorten the username and try again.<br/>";
                TextBox_Username.Focus();
                validRegistration = false;
            }

            if (username.UserName != "")
            {
                if (!usernameMatch.Success)
                {
                    validationErrors += "The <b>username</b> entered contains invalid characters. Please remove these characters and try again.<br/>";
                    TextBox_Username.Focus();
                    validRegistration = false;
                }
            }

            return validRegistration;
        }

        /// <summary>
        /// Validate the password form.
        /// </summary>
        /// <param name="temporaryPassword">The input temporary password.</param>
        /// <param name="newPassword">The new chosen password.</param>
        /// <param name="confirmNewPassword">The confirmed new chosen password.</param>
        /// <returns>True if the form validates successfully, else false.</returns>
        private bool ValidateChangePasswordForm(Password temporaryPassword, Password newPassword, Password confirmNewPassword, ref string validationErrors)
        {
            bool validRegistration = true; ;

            // Validating the temporary password field.
            if (temporaryPassword.PassWord == "")
            {
                validationErrors += "The <b>temporary password</b> field was left blank. Please fill this in using the temporary password sent to you in the e-mail and try again.<br/>";
                TextBox_TemporaryPassword.Focus();
                validRegistration = false;
            }
            else if (temporaryPassword.PassWord.Length != 8)
            {
                validationErrors += "The <b>temporary password</b> field is not the correct length. Please try again.<br/>";
                TextBox_TemporaryPassword.Focus();
                validRegistration = false;
            }

            // Checking the temporary password field for invalid characters.
            Match temporaryPasswordMatch = Regex.Match(temporaryPassword.PassWord, @"([A-Za-z0-9])", RegexOptions.IgnoreCase);
            if (temporaryPassword.PassWord != "")
            {
                if (!temporaryPasswordMatch.Success)
                {
                    validationErrors += "The <b> temporary password</b> field contains invalid characters. Please remove these and try again.<br/>";
                    TextBox_TemporaryPassword.Focus();
                    validRegistration = false;
                }
            }

            // Validate password field
            // Settings up the Regex for the password field
            /**
             * With thanks to http://stackoverflow.com/questions/9477906/password-must-be-8-characters-including-1-uppercase-letter-1-special-character
             **/
            Match passwordMatch = Regex.Match(newPassword.PassWord, @"[A-Za-z0-9]", RegexOptions.IgnoreCase);
            if (newPassword.PassWord == "")
            {
                validationErrors += "The <b>new password</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_NewPassword.Focus();
                validRegistration = false;
            }
            else if (newPassword.PassWord.Length > 0 && newPassword.PassWord.Length < 8)
            {
                validationErrors += "The <b>new password</b> field is too short. Please choose a pasword of at least 8 characters.<br/>";
                TextBox_NewPassword.Focus();
                validRegistration = false;
            }
            else if (newPassword.PassWord.Length > 50)
            {
                validationErrors += "The <b>new password</b> entered is too long. Please shorten the password and try again.<br/>";
                TextBox_NewPassword.Focus();
                validRegistration = false;
            }

            if (newPassword.PassWord != "")
            {
                if (!passwordMatch.Success)
                {
                    validationErrors += "The <b>new password</b> contains invalid characters. Please ensure the password contains a minimum of 8 characters of which one is an uppercase English character, a lowercase English character and a digit.<br/>";
                    TextBox_NewPassword.Focus();
                    validRegistration = false;
                }
            }

            // Validate confirm password field
            // Settings up the Regex for the confirm password field
            /**
             * With thanks to http://stackoverflow.com/questions/9477906/password-must-be-8-characters-including-1-uppercase-letter-1-special-character
             **/
            Match confirmPasswordMatch = Regex.Match(confirmNewPassword.PassWord, @"[A-Za-z0-9]", RegexOptions.IgnoreCase);

            if (confirmNewPassword.PassWord == "")
            {
                validationErrors += "The <b>confirmation new password</b> field was left blank. Please fill this in and try again.<br/>";
                TextBox_ConfirmNewPassword.Focus();
                validRegistration = false;
            }
            else if (confirmNewPassword.PassWord.Length > 0 && confirmNewPassword.PassWord.Length < 8)
            {
                validationErrors += "The <b>confirmation new password</b> field is too short. Please choose a password of at least 8 characters.<br/>";
                TextBox_ConfirmNewPassword.Focus();
                validRegistration = false;
            }
            else if (confirmNewPassword.PassWord.Length > 50)
            {
                validationErrors += "The <b>confirmation new password</b> field is too long. Please shorten the password and try again.<br/>";
                TextBox_ConfirmNewPassword.Focus();
                validRegistration = false;
            }

            if (confirmNewPassword.PassWord != "")
            {
                if (!confirmPasswordMatch.Success)
                {
                    validationErrors += "The <b>confirmation new password</b> contains invalid characters. Please ensure the confirmation password contains a minimum of 8 characters of which one is an uppercase English character, a lowercase English character and a digit.<br/>";
                    TextBox_ConfirmNewPassword.Focus();
                    validRegistration = false;
                }
            }

            // Check the password and confirm password fields match.
            if (newPassword.PassWord != confirmNewPassword.PassWord)
            {
                validationErrors += "The <b>password</b> and <b>confirmation password</b> you entered do not match. Please re-enter these and try again.<br/>";
                TextBox_NewPassword.Text = "";
                TextBox_ConfirmNewPassword.Text = "";
                TextBox_NewPassword.Focus();
                validRegistration = false;
            }

            return validRegistration;
        }
    }
}