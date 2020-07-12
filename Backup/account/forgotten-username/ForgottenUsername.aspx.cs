using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace artefact.account.forgotten_username
{
    public partial class ForgottenUsername : System.Web.UI.Page
    {
        User user;

        /// <summary>
        /// Executed when the Forgotten Username page is loaded.
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
                user = new User();

                int screen = 0;
                string screenValue = Request.QueryString["screen"];

                if (screenValue != null)
                {
                    screen = int.Parse(screenValue);
                }

                if (screen == 1)
                {
                    Panel_FirstScreen.Visible = true;
                    Panel_SecondScreen.Visible = false;
                }
                else if (screen == 2)
                {
                    Panel_FirstScreen.Visible = false;
                    Panel_SecondScreen.Visible = true;
                }
                else
                {
                    Response.Redirect("../Login.aspx");
                }
            }
        }

        /// <summary>
        /// Executed when the Send Username Reminder button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_SendUsernameReminder_Click(object sender, EventArgs e)
        {
            string validationErrors = "";
            user.EmailAddress = TextBox_EmailAddress.Text;

            if (ValidateForgottenUsernameForm(ref validationErrors))
            {
                if (user.RetrieveUsername())
                {
                    Response.Redirect("ForgottenUsername.aspx?screen=2");
                }
            }
            else
            {
                Panel_ValidationErrors.Visible = true;
                Label_ValidationErrorText.Visible = true;
                Label_ValidationErrorText.Text = validationErrors;
            }
        }

        /// <summary>
        /// Validate the Forgotten Username form.
        /// </summary>
        /// <returns>True if the e-mail address entered into the form validates, else false.</returns>
        private bool ValidateForgottenUsernameForm(ref string validationErrors)
        {
            bool validRegistration = true;

            // Validating the E-mail address field
            // Setting up the Regex for detecting invalid characters in the email address
            Match emailAddressMatch = Regex.Match(user.EmailAddress, @"([a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]){1,70}$", RegexOptions.IgnoreCase);

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

            if (user.EmailAddress != "")
            {
                if (!emailAddressMatch.Success)
                {
                    validationErrors += "The <b>e-mail address</b> did not contain the required characters for a valid e-mail address. Please alter your e-mail address and then try again.<br/>";
                    TextBox_EmailAddress.Focus();
                    validRegistration = false;
                }
            }

            if (user.EmailAddress != "")
            {
                if (!user.CheckEmailAddressExistence())
                {
                    validationErrors += "The <b>e-mail address</b> entered is not registered. Please choose a different e-mail address and try again.<br/>";
                    TextBox_EmailAddress.Focus();
                    validRegistration = false;
                }
            }

            return validRegistration;
        }
    }
}