using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using artefact.enums;
using System.Text;
using System.Data;

namespace artefact.classes.testing
{
    [TestFixture]
    public class QueryTesting
    {
        #region Create Query

        [Test]
        public void CreateQueryTornadoCriteriaSelected()
        {
            QueryRequest qr = new QueryRequest();
            qr.CreateQuery(true);
        }

        [Test]
        public void CreateQueryNoTornadoCriteriaSelected()
        {
            QueryRequest qr = new QueryRequest();
            qr.CreateQuery(false);
        }

        #endregion

        #region Initialise Query
        [Test]
        public void InitialiseQuery()
        {
            QueryRequest qr = new QueryRequest();
            qr.InitialiseQuery();
        }
        #endregion

        #region Build Query Date Criteria Function
        [Test]
        public void BuildQueryDateCriteriaNoStartDateNoEndDateSpecifiedFirstWhereClause()
        {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaStartDateNoEndDateSpecifiedFirstWhereClause()
        {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.StartDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaNoStartDateEndDateSpecifiedFirstWhereClause()
        {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.EndDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaStartDateEndDateSpecifiedFirstWhereClause()
        {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.StartDate = new DateTime(2013, 3, 18);
            qr.EndDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        
        [Test]
        public void BuildQueryDateCriteriaNoStartDateNoEndDateSpecifiedNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaStartDateNoEndDateSpecifiedNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.StartDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaNoStartDateEndDateSpecifiedNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.EndDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        [Test]
        public void BuildQueryDateCriteriaStartDateEndDateSpecifiedNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.StartDate = new DateTime(2013, 3, 18);
            qr.EndDate = new DateTime(2013, 3, 19);
            string result = qr.BuildQueryDateCriteria(ref flag);
        }

        #endregion

        #region Build Query Location Criteria
        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyNoStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyNoStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyNoStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyNoStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyNoStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyNoStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyNoStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyNoStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyStateFIPSNoCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyStateFIPSCountyFIPSFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyNoStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyNoStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateNoLocationCountyStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyNoStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyNoStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaNoLocationStateLocationCountyStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyNoStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyNoStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateNoLocationCountyStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyNoStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyNoStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);

        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyStateFIPSNoCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        [Test]
        public void BuildQueryLocationCriteriaLocationStateLocationCountyStateFIPSCountyFIPSNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.Location.State = "California";
            qr.Location.County = "Mendocino";
            qr.Location.StateFIPS = 6;
            qr.Location.CountyFIPS = 45;
            string result = qr.BuildQueryLocationCriteria(ref flag);
        }

        #endregion

        #region Build Query Tornado Criteria
        [Test]
        public void BuildQueryTornadoCritieriaNoTornadoStartValueNoTornadoEndValueFirstWhereClause() {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.BuildQueryTornadoCritieria(ref flag);
        }

        /*[Test]
        public void BuildQueryTornadoCritieriaNoTornadoStartValueTornadoEndValueFirstWhereClause() {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.TornadoEndRangeValue = 2;
            qr.BuildQueryTornadoCritieria(ref flag);
        }*/

        [Test]
        public void BuildQueryTornadoCritieriaTornadoStartValueNoTornadoEndValueFirstWhereClause() {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.TornadoStartRangeValue = 1;
            qr.BuildQueryTornadoCritieria(ref flag);
        }

        /*[Test]
        public void BuildQueryTornadoCritieriaTornadoStartValueTornadoEndValueFirstWhereClause() {
            bool flag = true;

            QueryRequest qr = new QueryRequest();
            qr.TornadoStartRangeValue = 1;
            qr.TornadoEndRangeValue = 2;
            qr.BuildQueryTornadoCritieria(ref flag);
        }*/

        [Test]
        public void BuildQueryTornadoCritieriaNoTornadoStartValueNoTornadoEndValueNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.BuildQueryTornadoCritieria(ref flag);
        }

        /*[Test]
        public void BuildQueryTornadoCritieriaNoTornadoStartValueTornadoEndValueNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.TornadoEndRangeValue = 2;
            qr.BuildQueryTornadoCritieria(ref flag);
        }*/

        [Test]
        public void BuildQueryTornadoCritieriaTornadoStartValueNoTornadoEndValueNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.TornadoStartRangeValue = 1;
            qr.BuildQueryTornadoCritieria(ref flag);
        }

        /*[Test]
        public void BuildQueryTornadoCritieriaTornadoStartValueTornadoEndValueNoFirstWhereClause()
        {
            bool flag = false;

            QueryRequest qr = new QueryRequest();
            qr.TornadoStartRangeValue = 1;
            qr.TornadoEndRangeValue = 2;
            qr.BuildQueryTornadoCritieria(ref flag);
        }*/
        #endregion

        #region Run Query

        [Test]
        public void RunQueryValidQueryString()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = qr.RunQuery("SELECT TOP 10 * FROM [Event]");
        }

        [Test]
        public void RunQueryInvalidQueryString()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = qr.RunQuery("Test");
        }

        [Test]
        public void RunQueryNoQueryString()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = qr.RunQuery(null);
        }

        #endregion

        #region Prepare Map

        [Test]
        public void PrepareMapDataTable()
        {
            System.Data.DataTable table = MakeResultsDataTable();
            QueryRequest qr = new QueryRequest();

            qr.PrepareMap(table);
        }

        [Test]
        public void PrepareMapNoDataTable()
        {
            System.Data.DataTable table = null;
            QueryRequest qr = new QueryRequest();

            qr.PrepareMap(table);
        }

        private System.Data.DataTable MakeResultsDataTable()
        {
            System.Data.DataTable table = new System.Data.DataTable();

            table.Rows[0][8] = "02";
            table.Rows[0][9] = "02";
            table.Rows[0][10] = "2012";
            table.Rows[0][17] = "tornado";
            table.Rows[0][24] = "29.99";
            table.Rows[0][25] = "29.99";
            table.Rows[0][26] = "29.99";
            table.Rows[0][27] = "29.99";

            return table;
        }

        #endregion 

        #region Plot All Points

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeNoLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderNoLatitudeLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeNoLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsNoStringBuilderLatitudeLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = null;
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeNoLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, string.Empty, "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderNoLatitudeLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, string.Empty, "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeNoLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", string.Empty, "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotAllPointsStringBuilderLatitudeLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotAllPoints(ref sb, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        #endregion

        #region Plot All Polylines

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksNoStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderNoStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeNoStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeNoEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, string.Empty, "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeNoEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", string.Empty, "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, string.Empty, string.Empty, string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeNoEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", string.Empty, "33.39", string.Empty, "22 March 2013", "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeNoStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", string.Empty, "tornado", string.Empty, "22:13");
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateNoStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", string.Empty);
        }

        [Test]
        public void PlotTornadoTracksStringBuilderStartLatitudeStartLongitudeEndLatitudeEndLongitudeEventTypeStartDateStartTime()
        {
            QueryRequest qr = new QueryRequest();
            StringBuilder sb = new StringBuilder();
            qr.PlotTornadoTracks(ref sb, "33.39", "33.39", "33.39", "33.39", "tornado", "22 March 2013", "22:13");
        }

        #endregion

        #region Load Weather Icon

        [Test]
        public void LoadWeatherIconValidWeatherEvent()
        {
            QueryRequest qr = new QueryRequest();
            string results = qr.LoadWeatherIcon("tornado");
        }

        [Test]
        public void LoadWeatherIconInvalidWeatherEvent()
        {
            QueryRequest qr = new QueryRequest();
            string results = qr.LoadWeatherIcon("test");
        }

        [Test]
        public void LoadWeatherIconNoWeatherEvent()
        {
            QueryRequest qr = new QueryRequest();
            string results = qr.LoadWeatherIcon(string.Empty);
        }

        #endregion

        #region Get Month

        [Test]
        public void GetMonthMonthSupplied()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.GetMonth(12);
        }

        [Test]
        public void GetMonthNoMonthSupplied()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.GetMonth(int.MinValue);
        }

        #endregion

        #region Pad Time

        [Test]
        public void PadTimeNoTimeNoSize()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.PadTime(string.Empty, int.MinValue);
        }

        [Test]
        public void PadTimeTimeNoSize()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.PadTime("0756", int.MinValue);
        }

        [Test]
        public void PadTimeNoTimeSize()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.PadTime(string.Empty, 4);
        }

        [Test]
        public void PadTimeTimeSize()
        {
            QueryRequest qr = new QueryRequest();
            string result = qr.PadTime("0756", 4);
        }

        #endregion

        #region Send Results Table To Excel

        /*[Test]
        public void SendResultsTableToExcelNoDataNoUsername()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = null;

            qr.SendResultsTableToExcel(table, string.Empty);
        }*/

        /*[Test]
        public void SendResultsTableToExcelDataNoUsername()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = new System.Data.DataTable();
            System.Data.DataRow row = table.NewRow();
            row[0] = "0";
            row[1] = "1";
            row[3] = "3";
            row[5] = "5";
            row[8] = "8";
            row[9] = "9";
            row[10] = "10";
            row[17] = "17";
            row[47] = "47";

            table.Rows.Add(row);

            qr.SendResultsTableToExcel(table, string.Empty);
        }

        [Test]
        public void SendResultsTableToExcelNoDataUsername()
        {
            QueryRequest qr = new QueryRequest();
            System.Data.DataTable table = null;

            qr.SendResultsTableToExcel(table, "mikeofmacc");
        }

        [Test]
        public void SendResultsTableToExcelDataUsername()
        {
            QueryRequest qr = new QueryRequest();
            DataTable table = new DataTable();
            
            
            row[1] = "Test";
            row[3] = "3";
            row[5] = "5";
            row[8] = "8";
            row[9] = "9";
            row[10] = "10";
            row[17] = "17";
            row[47] = "47";

            for (int i = 0; i < 10; i++)
            {
                DataRow row = table.NewRow();
                for (int j = 0; j < 50; j++)
                {
                    row[j] = j.ToString();
                }

                table.Rows.Add(row);
            }

            //table.Rows.Add(row);

            qr.SendResultsTableToExcel(table, "mikeofmacc");
        }*/

        #endregion

        #region Send Statistics To Excel

        /*[Test]
        public void SendStatisticsToExcelNoStatisticsNoUsername()
        {
            QueryRequest qr = new QueryRequest();
            qr.SendStatisticsToExcel(null, string.Empty);
        }

        [Test]
        public void SendStatisticsToExcelStatisticsNoUsername()
        {
            QueryRequest qr = new QueryRequest();

            System.Data.DataTable table = new System.Data.DataTable();

            for (int i = 0; i < 50; i++)
            {
                table.Rows[0][50] = i.ToString();
            }

            Statistics s = new Statistics(table);

            s.CalculateStatistics();

            qr.SendStatisticsToExcel(s, "mikeofmacc");
        }

        [Test]
        public void SendStatisticsToExcelNoStatisticsUsername()
        {
            QueryRequest qr = new QueryRequest();
            qr.SendStatisticsToExcel(null, "mikeofmacc");
        }

        [Test]
        public void SendStatisticsToExcelStatisticsUsername()
        {
            QueryRequest qr = new QueryRequest();

            System.Data.DataTable table = new System.Data.DataTable();

            for (int i = 0; i < 50; i++)
            {
                table.Rows[0][50] = i.ToString();
            }

            Statistics s = new Statistics(table);

            s.CalculateStatistics();

            qr.SendStatisticsToExcel(s, "mikeofmacc");
        }*/

        #endregion
    }
}