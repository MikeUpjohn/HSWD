using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;

namespace artefact.classes.testing
{
    [TestFixture]
    public class EventTypeTesting
    {

        [Test]
        public void GenerateEventQueryNoFirstWhereClauseNoFirstInStatementNoQuery()
        {
            EventType t = new EventType();
            bool test = false;
            string result = t.GenerateEventQuery(ref test, ref test, null);
        }

        [Test]
        public void GenerateEventQueryNoFirstWhereClauseNoFirstInStatementQuery()
        {
            EventType t = new EventType();
            bool test = false;
            string result = t.GenerateEventQuery(ref test, ref test, "");
        }

        [Test]
        public void GenerateEventQueryNoFirstWhereClauseFirstInStatementNoQuery()
        {
            EventType t = new EventType();
            bool test = false;
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test, ref test2, null);
        }

        [Test]
        public void GenerateEventQueryNoFirstWhereClauseFirstInStatementQuery()
        {
            EventType t = new EventType();
            bool test = false;
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test, ref test2, "");
        }

        [Test]
        public void GenerateEventQueryFirstWhereClauseNoFirstInStatementNoQuery()
        {
            EventType t = new EventType();
            bool test = false;
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test2, ref test, null);
        }

        [Test]
        public void GenerateEventQueryFirstWhereClauseNoFirstInStatementQuery()
        {
            EventType t = new EventType();
            bool test = false;
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test2, ref test, "");
        }

        [Test]
        public void GenerateEventQueryFirstWhereClauseFirstInStatementNoQuery()
        {
            EventType t = new EventType();
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test2, ref test2, null);
        }

        [Test]
        public void GenerateEventQueryFirstWhereClauseFirstInStatementQuery()
        {
            EventType t = new EventType();
            bool test2 = true;
            string result = t.GenerateEventQuery(ref test2, ref test2, "");
        }
    }
}