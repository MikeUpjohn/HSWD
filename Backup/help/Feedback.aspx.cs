using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using artefact.classes;

namespace artefact.help
{
    public partial class Feedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                if (Request.QueryString["page"] != null)
                {
                    if (int.Parse(Request.QueryString["page"]) == 1)
                    {
                        Panel_ScreenOne.Visible = true;
                        Panel_ScreenTwo.Visible = false;
                    }
                    else if (int.Parse(Request.QueryString["page"]) == 2)
                    {
                        Panel_ScreenOne.Visible = false;
                        Panel_ScreenTwo.Visible = true;
                    }
                }
                else
                {
                    Response.Redirect("Feedback.aspx?page=1");
                }

                Panel_ValidationErrors.Visible = false;
                Label_ValidationErrorText.Visible = false;
            }
            else
            {
                Response.Redirect("../account/Login.aspx");
            }
        }

        protected void Button_SendFeedback_Click(object sender, EventArgs e)
        {
            string feedbackSubject;
            string feedback;
            int rating;
            bool validForm;
            string validationErrors;

            feedbackSubject = TextBox_FeedbackSubject.Text;
            feedback = TextBox_Feedback.Text;
            rating = DropDownList_FeedbackRating.SelectedIndex;

            validForm = true;
            validationErrors = "";

            if (feedbackSubject.Length > 255)
            {
                validForm = false;
                validationErrors = "The <b>feedback subject</b> is too long. Please shorten it and try again.<br/>";
                TextBox_FeedbackSubject.Focus();
            }

            if (feedback.Length == 0)
            {
                validForm = false;
                validationErrors += "The <b>feedback</b> field was left null. Please enter feedback and try again.<br/>";
                TextBox_Feedback.Focus();
            }
            else if (feedback.Length > 4000)
            {
                validForm = false;
                validationErrors = "The <b>feedback</b> is too long. Please shorten it and try again.<br/>";
                TextBox_Feedback.Focus();
            }

            if (feedbackSubject.Length == 0 && feedback.Length == 0 && rating == 0)
            {
                validForm = false;
                validationErrors = "There was no <b>feedback</b> supplied. Please fill in some feedback to submit it to us.<br/>";
                TextBox_FeedbackSubject.Focus();
            }

            if (validForm)
            {
                UserFeedback userFeedback = new UserFeedback();
                userFeedback.FeedbackSubject = feedbackSubject;
                userFeedback.FeedBack = feedback;

                if (rating != 0)
                {
                    userFeedback.FeedbackRating = rating;
                }
                else
                {
                    userFeedback.FeedbackRating = 0;
                }

                if (userFeedback.StoreFeedback(Session["username"].ToString()))
                {
                    Response.Redirect("Feedback.aspx?page=2");
                }
            }
            else
            {
                Panel_ValidationErrors.Visible = true;
                Label_ValidationErrorText.Visible = true;
                Label_ValidationErrorText.Text = validationErrors;
            }
        }
    }
}