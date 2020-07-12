using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class UserFeedbackTesting
    {
        [Test]
        public void StoreFeedbackNoUsernameNoFeedbackSubjectNoFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameNoFeedbackSubjectNoFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedBack = "Test";
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameNoFeedbackSubjectFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackRating = 4;
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameNoFeedbackSubjectFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackRating = 4;
            uf.FeedBack = "Test";
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameFeedbackSubjectNoFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameFeedbackSubjectNoFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedBack = "Test";
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameFeedbackSubjectFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedbackRating = 4;
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackNoUsernameFeedbackSubjectFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedbackRating = 4;
            uf.FeedBack = "Test";
            uf.StoreFeedback("");
        }

        [Test]
        public void StoreFeedbackUsernameNoFeedbackSubjectNoFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameNoFeedbackSubjectNoFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedBack = "Test";
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameNoFeedbackSubjectFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackRating = 4;
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameNoFeedbackSubjectFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackRating = 4;
            uf.FeedBack = "Test";
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameFeedbackSubjectNoFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameFeedbackSubjectNoFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedBack = "Test";
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameFeedbackSubjectFeedbackRatingNoFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedbackRating = 4;
            uf.StoreFeedback("mikeofmacc");
        }

        [Test]
        public void StoreFeedbackUsernameFeedbackSubjectFeedbackRatingFeedback()
        {
            UserFeedback uf = new UserFeedback();
            uf.FeedbackSubject = "Test";
            uf.FeedbackRating = 4;
            uf.FeedBack = "Test";
            uf.StoreFeedback("mikeofmacc");
        }
    }
}