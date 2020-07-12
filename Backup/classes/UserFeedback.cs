using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace artefact.classes
{
    public class UserFeedback
    {
        private SqlConnection connection = new SqlConnection("Data Source=www.mike-upjohn.com;Initial Catalog=hswd;User ID=mikeofmacc;Password=-Bbq~%4-W5U(");
        private User user;
        private string feedbackSubject;
        private int feedbackRating;
        private string feedback;
        private DateTime feedbackSent;
        private string returnFeedbackSubject;
        private string returnFeedback;
        private DateTime returnFeedbackSent;
        private User returnFeedbackSender;

        
        /// <summary>
        /// User Property
        /// </summary>
        public User User
        {
            get
            {
                return this.user;
            }
            set
            {
                this.user = value;
            }
        }

        /// <summary>
        /// Feedback Subject Property
        /// </summary>
        public string FeedbackSubject
        {
            get
            {
                return this.feedbackSubject;
            }
            set
            {
                this.feedbackSubject = value;
            }
        }

        /// <summary>
        /// Feedback Rating Property
        /// </summary>
        public int FeedbackRating
        {
            get
            {
                return this.feedbackRating;
            }
            set
            {
                this.feedbackRating = value;
            }
        }

        /// <summary>
        /// Feedback Property
        /// </summary>
        public string FeedBack
        {
            get
            {
                return this.feedback;
            }
            set
            {
                this.feedback = value;
            }
        }

        /// <summary>
        /// Feedback Sent Property
        /// </summary>
        public DateTime FeedbackSent
        {
            get
            {
                return this.feedbackSent;
            }

            set
            {
                this.feedbackSent = value;
            }
        }

        /// <summary>
        /// Return Feedback Subject Property
        /// </summary>
        public string ReturnFeedbackSubject
        {
            get
            {
                return this.returnFeedbackSubject;
            }

            set
            {
                this.returnFeedbackSubject = value;
            }
        }

        /// <summary>
        /// Return Feedback Property
        /// </summary>
        public string ReturnFeedback
        {
            get
            {
                return this.returnFeedback;
            }

            set
            {
                this.returnFeedback = value;
            }
        }

        /// <summary>
        /// Return Feedback Sent Property
        /// </summary>
        public DateTime ReturnFeedbackSent
        {
            get
            {
                return this.returnFeedbackSent;
            }
            set
            {
                this.returnFeedbackSent = value;
            }
        }

        /// <summary>
        /// Return Feedback Sender Property
        /// </summary>
        public User ReturnFeedbackSender
        {
            get
            {
                return this.returnFeedbackSender;
            }

            set
            {
                this.returnFeedbackSender = value;
            }
        }

        /// <summary>
        /// User Feedback Empty Constructor
        /// </summary>
        public UserFeedback()
        {
            user = new User();
            returnFeedbackSender = new User();
        }

        /// <summary>
        /// Allow a user to send feedback for an administrator to view.
        /// </summary>
        /// <returns>True if the feedback was sent to the administrator successfully, else false.</returns>
        public bool StoreFeedback(string username)
        {
            this.User.Username.UserName = username;

            if(user.CheckUsernameExistence()) {
                int rows = -99;
                
                int userID = user.GetUserIDFromUsername();

                SqlCommand command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "INSERT INTO [dbo].[Feedback] (UserID, FeedbackSubject, FeedbackRating, Feedback, FeedbackSent, FeedbackStatus) VALUES (" + userID + ",'" + this.FeedbackSubject + "','" + this.FeedbackRating + "','" + this.FeedBack + "', '" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "','Unread')";
                command.Connection = connection;

                connection.Open();
                rows = command.ExecuteNonQuery();
                connection.Close();

                if (rows == 1)
                {
                    return true;
                }
                else if(rows == 0)
                {
                    return false;
                }
                else {
                    throw new Exception("Error 10001: There was an error storing the feedback.");
                }
            }
            else {
                throw new Exception("Error 10002: This username is not recognised for submitting feedback.");
            }
        }
    }
}