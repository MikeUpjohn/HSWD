using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using artefact.dictionaries;
using artefact.classes;
using System.Data;
using System.Web.Services;
using System.Text;
using System.IO;

namespace artefact.us_severe_weather_database
{
    public partial class us_severe_weather_database : System.Web.UI.Page
    {
        private DateTime startDate;
        private DateTime endDate;
        System.Data.DataTable table;
        QueryRequest request;
        Statistics statistics;

        /// <summary>
        /// Executed when this page is loaded.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be exeucted.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["loggedIn"] != null)
            {
                if (!Page.IsPostBack)
                {
                    Session["SelectedCounty"] = 0;
                    PopulateStates();
                    InitialiseCountiesDropDown(false);

                    DropDownList_States.Enabled = true;
                    DropDownList_County.Enabled = true;
                    CheckBox_EnableFIPSCodes.Checked = false;
                    TextBox_StateFIPS.Enabled = false;
                    TextBox_CountyFIPS.Enabled = false;
                    Table_Results.Visible = false;

                    DeleteQueryFiles(Session["username"].ToString());
                }

                Panel_QueryWindow.Visible = true;
                Panel_ResultsTable.Visible = false;
               

                if (!CheckBox_Tornado.Checked)
                {
                    DropDownList_TornadoEventScaleFrom.Enabled = false;
                }

                if (!CheckBox_IsFatalEventsEnabled.Checked)
                {
                    TextBox_FatalEventCriteriaFrom.Enabled = false;
                    TextBox_FatalEventCriteriaTo.Enabled = false;
                }

                Button_ExportResults.Enabled = false;
                Button_ExportStatistics.Enabled = false;

                StringBuilder sb = new StringBuilder();
                sb.Append("var map; function initialize() {var myLatlng = new google.maps.LatLng(39.828328, -98.579416);var mapOptions = {zoom: 4,center: myLatlng,mapTypeId: google.maps.MapTypeId.ROADMAP};map = new google.maps.Map(document.getElementById('map'), mapOptions);}google.maps.event.addDomListener(window, 'load', initialize);");

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "JavaScript to Map Page Load", sb.ToString(), true);
            }
            else
            {
                Response.Redirect("../account/Login.aspx");
            }
        }

        private void DeleteQueryFiles(string username)
        {
            if (File.Exists(HttpContext.Current.Server.MapPath("../query-results/results-" + username + ".xls")))
            {
                File.Delete(HttpContext.Current.Server.MapPath("../query-results/results-" + username + ".xls"));
            }

            if (File.Exists(HttpContext.Current.Server.MapPath("../query-results/statistics-" + username + ".xls")))
            {
                File.Delete(HttpContext.Current.Server.MapPath("../query-results/statistics-" + username + ".xls"));
            }
        }

        private void InitialiseCountiesDropDown(bool isStateSelected)
        {
            DropDownList_County.Items.Add(new ListItem("Choose a county...", "-1"));

            if (isStateSelected)
            {
                DropDownList_County.Items.Add(new ListItem("All Counties", "0"));
            }
        }

        /// <summary>
        /// Populate the drop down list with the states.
        /// </summary>
        private void PopulateStates()
        {
            StatesDictionary states = new StatesDictionary();

            if (DropDownList_States.Items.Count != 0)
            {
                DropDownList_States.Items.Clear();
            }

            DropDownList_States.Items.Add(new ListItem("Choose a state...", "-1"));
            DropDownList_States.Items.Add(new ListItem("All States", "0"));

            foreach (KeyValuePair<int, string> state in states.states)
            {
                DropDownList_States.Items.Add(new ListItem(state.Value, state.Key.ToString()));
            }
        }

        /// <summary>
        /// Executed when the check is changed in the Tornado Event Type checkbox.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data related to this event.</param>
        protected void CheckBox_Tornado_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Tornado.Checked)
            {
                DropDownList_TornadoEventScaleFrom.Enabled = true;
            }
            else
            {
                DropDownList_TornadoEventScaleFrom.SelectedIndex = 0;
                DropDownList_TornadoEventScaleFrom.Enabled = false;
            }
        }

        /// <summary>
        /// Executed when the check is change in the Is Fatal Events Selected checkbox.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void CheckBox_IsFatalEventsEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_IsFatalEventsEnabled.Checked)
            {
                TextBox_FatalEventCriteriaFrom.Enabled = true;
                TextBox_FatalEventCriteriaTo.Enabled = true;
            }
            else
            {
                TextBox_FatalEventCriteriaFrom.Text = "";
                TextBox_FatalEventCriteriaTo.Text = "";
                TextBox_FatalEventCriteriaFrom.Enabled = false;
                TextBox_FatalEventCriteriaTo.Enabled = false;
            }
        }

        /// <summary>
        /// Executed when the Run Query button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_RunQuery_Click(object sender, EventArgs e)
        {
            string errors = "";
            DeleteQueryFiles(Session["username"].ToString());

            Label_ValidationErrors.Text = "";
            Label_ValidationErrors.Visible = false;
            Panel_ValidationErrors.Visible = false;

            if (ValidateSevereWeatherDatabaseForm(ref errors))
            {
                StringBuilder sb;

                SetupQueryRequest();
                request.CreateQuery(CheckBox_Tornado.Checked && DropDownList_TornadoEventScaleFrom.SelectedIndex != 0);

                table = request.RunQuery(request.Query);

                if (table.Rows.Count > 0)
                {

                    sb = request.PrepareMap(table);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "JavaScript to Map", sb.ToString(), true);

                    statistics = new Statistics(table);
                    statistics.CalculateStatistics();

                    DisplayStatisticsToScreen(statistics);
                    PrintTableOfResults(table);

                    Button_ExportResults.Enabled = true;
                    Button_ExportStatistics.Enabled = true;
                }
                else
                {
                    Panel_ValidationErrors.Visible = true;
                    Label_ValidationErrors.Visible = true;
                    Label_ValidationErrors.Text = "Sorry, that query returned no results.<br/>";
                }
            }
            else
            {
                Panel_ValidationErrors.Visible = true;
                Label_ValidationErrors.Visible = true;
                Label_ValidationErrors.Text = errors;
            }
        }

        private void PrintTableOfResults(DataTable table)
        {
            foreach (DataRow dr in table.Rows)
            {
                TableCell id = new TableCell();
                TableCell dateTime = new TableCell();
                TableCell state = new TableCell();
                TableCell county = new TableCell();
                TableCell eventType = new TableCell();
                TableCell eventDescription = new TableCell();

                TableRow row = new TableRow();

                id.CssClass = "eventNumber";
                id.Text = dr[1].ToString();

                dateTime.CssClass = "dateTime";
                dateTime.Text = dr[10].ToString() + " " + GetMonth(int.Parse(dr[9].ToString())) + " " + dr[8].ToString();

                state.CssClass = "state";
                state.Text = dr[3].ToString();

                county.CssClass = "county";
                county.Text = dr[5].ToString();

                string eventTypeCssClass = dr[17].ToString();
                eventTypeCssClass = eventTypeCssClass.Replace(' ', '-');

                eventType.CssClass = "table-" + eventTypeCssClass.ToLower();
                eventType.Text = dr[17].ToString().ToUpper();

                eventDescription.Text = dr[47].ToString();

                row.Cells.Add(id);
                row.Cells.Add(dateTime);
                row.Cells.Add(state);
                row.Cells.Add(county);
                row.Cells.Add(eventType);
                row.Cells.Add(eventDescription);

                Table_Results.Rows.Add(row);
            }

            Table_Results.Visible = true;
        }

        private void DisplayStatisticsToScreen(Statistics statistics)
        {
            AddDataStatisticsToPage(statistics);
            AddTornadoStatisticsToPage(statistics);
            AddPropertyDamageStatisticsToPage(statistics);
            AddCropDamageStatisticsToPage(statistics);
            AddDeathStatisticsToPage(statistics);
            AddStatisticsByStateToPage(statistics);
        }

        private void AddDataStatisticsToPage(Statistics statistics)
        {
            Label_NumberOfEventsRetrievedValue.Text = statistics.NumberOfEvents.ToString();

            if (statistics.DayWithMostEvents != new DateTime(1, 1, 1, 0, 0, 0))
            {
                Label_DayWithMostEventsValue.Text = statistics.DayWithMostEvents.Day + " " + GetMonth(statistics.DayWithMostEvents.Month) + " " + statistics.DayWithMostEvents.Year;
            }
            else
            {
                Label_DayWithMostEventsValue.Text = "N/A";
            }
        }

        private void AddTornadoStatisticsToPage(Statistics statistics)
        {
            Label_TotalTornadoEventsValue.Text = statistics.NumberOfTornadoEvents.ToString();
            Label_StrongestTornadoValue.Text = statistics.StrongestTornado.ToString();

            if (statistics.WidestTornado > 0)
            {
                Label_WidestTornadoValue.Text = statistics.WidestTornado.ToString() + " metres";
            }
            else
            {
                Label_WidestTornadoValue.Text = "N/A";
            }

            if (statistics.LongestTornado > 0)
            {
                Label_LongestTornadoValue.Text = statistics.LongestTornado.ToString() + " miles";
            }
            else
            {
                Label_LongestTornadoValue.Text = "N/A";
            }

            Label_TornadoWithMostInjuriesValue.Text = statistics.TornadoWithMostInjuries.ToString();
            Label_TornadoWithMostDeathsValue.Text = statistics.TornadoWithMostDeaths.ToString();
            Label_TornadoWithMostCropDamageValue.Text = statistics.TornadoWithMostCropDamage.ToString();
            Label_TornadoWithMostPropertyDamageValue.Text = statistics.TornadoWithMostPropertyDamage.ToString();
        }

        private void AddPropertyDamageStatisticsToPage(Statistics statistics)
        {
            if (statistics.HighestPropertyDamageEvent != "")
            {
                Label_HighestPropertyDamageEventValue.Text = statistics.HighestPropertyDamageEvent.ToString();
            }
            else
            {
                Label_HighestPropertyDamageEventValue.Text = "N/A";
            }

            if (statistics.DayWithMostPropertyDamage != new DateTime(1, 1, 1, 0, 0, 0))
            {
                Label_DayWithMaximumNumberOfPropertyDamagesValue.Text = statistics.DayWithMostPropertyDamage.Day + " " + GetMonth(statistics.DayWithMostPropertyDamage.Month) + " " + statistics.DayWithMostPropertyDamage.Year;
            }
            else
            {
                Label_DayWithMaximumNumberOfPropertyDamagesValue.Text = "N/A";
            }
        }

        private void AddCropDamageStatisticsToPage(Statistics statistics)
        {
            if (statistics.HighestCropDamageEvent != "")
            {
                Label_HighestCropDamageEventValue.Text = statistics.HighestCropDamageEvent.ToString();
            }
            else
            {
                Label_HighestCropDamageEventValue.Text = "N/A";
            }

            if (statistics.DayWithMostCropDamage != new DateTime(1, 1, 1, 0, 0, 0))
            {
                Label_DayWithMaximumNumberOfCropDamagesValue.Text = statistics.DayWithMostCropDamage.Day + " " + GetMonth(statistics.DayWithMostCropDamage.Month) + " " + statistics.DayWithMostCropDamage.Year;
            }
            else
            {
                Label_DayWithMaximumNumberOfCropDamagesValue.Text = "N/A";
            }
        }

        private void AddDeathStatisticsToPage(Statistics statistics)
        {
            Label_EventWithMostDeathsValue.Text = statistics.EventWithMostDeaths.ToString();

            if (statistics.DayWithMostDeaths != new DateTime(1, 1, 1, 0, 0, 0))
            {
                Label_DayWithMostDeathsValue.Text = statistics.DayWithMostDeaths.Day + " " + GetMonth(statistics.DayWithMostDeaths.Month) + " " + statistics.DayWithMostDeaths.Year;
            }
            else
            {
                Label_DayWithMostDeathsValue.Text = "N/A";
            }
        }

        private void AddStatisticsByStateToPage(Statistics statistics)
        {
            Label_AlabamaCountValue.Text = statistics.SumOfEventsPerState.Alabama.ToString();
            Label_AlaskaCountValue.Text = statistics.SumOfEventsPerState.Alaska.ToString();
            Label_ArizonaCountValue.Text = statistics.SumOfEventsPerState.Arizona.ToString();
            Label_ArkansasCountValue.Text = statistics.SumOfEventsPerState.Arkansas.ToString();
            Label_CaliforniaCountValue.Text = statistics.SumOfEventsPerState.California.ToString();
            Label_ColoradoCountValue.Text = statistics.SumOfEventsPerState.Colorado.ToString();
            Label_ConnecticutCountValue.Text = statistics.SumOfEventsPerState.Connecticut.ToString();
            Label_DelawareCountValue.Text = statistics.SumOfEventsPerState.Delaware.ToString();
            Label_DistrictOfColumbiaValue.Text = statistics.SumOfEventsPerState.DistrictOfColumbia.ToString();
            Label_FloridaCountValue.Text = statistics.SumOfEventsPerState.Florida.ToString();
            Label_GeorgiaCountValue.Text = statistics.SumOfEventsPerState.Georgia.ToString();
            Label_HawaiiCountValue.Text = statistics.SumOfEventsPerState.Hawaii.ToString();
            Label_IdahoCountValue.Text = statistics.SumOfEventsPerState.Idaho.ToString();
            Label_IllinoisCountValue.Text = statistics.SumOfEventsPerState.Illinois.ToString();
            Label_IndianaCountValue.Text = statistics.SumOfEventsPerState.Indiana.ToString();
            Label_IowaCountValue.Text = statistics.SumOfEventsPerState.Iowa.ToString();
            Label_KansasCountValue.Text = statistics.SumOfEventsPerState.Kansas.ToString();
            Label_KentuckyCountValue.Text = statistics.SumOfEventsPerState.Kentucky.ToString();
            Label_LouisianaCountValue.Text = statistics.SumOfEventsPerState.Louisiana.ToString();
            Label_MaineCountValue.Text = statistics.SumOfEventsPerState.Maine.ToString();
            Label_MarylandCountValue.Text = statistics.SumOfEventsPerState.Maryland.ToString();
            Label_MassachusettsCountValue.Text = statistics.SumOfEventsPerState.Massachusetts.ToString();
            Label_MichiganCountValue.Text = statistics.SumOfEventsPerState.Michigan.ToString();
            Label_MinnesotaCountValue.Text = statistics.SumOfEventsPerState.Minnesota.ToString();
            Label_MississippiCountValue.Text = statistics.SumOfEventsPerState.Mississippi.ToString();
            Label_MissouriCountValue.Text = statistics.SumOfEventsPerState.Missouri.ToString();
            Label_MontanaCountValue.Text = statistics.SumOfEventsPerState.Montana.ToString();
            Label_NebraskaCountValue.Text = statistics.SumOfEventsPerState.Nebraska.ToString();
            Label_NevadaCountValue.Text = statistics.SumOfEventsPerState.Nevada.ToString();
            Label_NewHampshireCountValue.Text = statistics.SumOfEventsPerState.NewHampshire.ToString();
            Label_NewJerseyCountValue.Text = statistics.SumOfEventsPerState.NewJersey.ToString();
            Label_NewMexicoCountValue.Text = statistics.SumOfEventsPerState.NewMexico.ToString();
            Label_NewYorkCountValue.Text = statistics.SumOfEventsPerState.NewYork.ToString();
            Label_NorthCarolinaCountValue.Text = statistics.SumOfEventsPerState.NorthCarolina.ToString();
            Label_NorthDakotaCountValue.Text = statistics.SumOfEventsPerState.NorthDakota.ToString();
            Label_OhioCountValue.Text = statistics.SumOfEventsPerState.Ohio.ToString();
            Label_OklahomaCountValue.Text = statistics.SumOfEventsPerState.Oklahoma.ToString();
            Label_OregonCountValue.Text = statistics.SumOfEventsPerState.Oregon.ToString();
            Label_PennsylvaniaCountValue.Text = statistics.SumOfEventsPerState.Pennsylvania.ToString();
            Label_RhodeIslandCountValue.Text = statistics.SumOfEventsPerState.RhodeIsland.ToString();
            Label_SouthCarolinaCountValue.Text = statistics.SumOfEventsPerState.SouthCarolina.ToString();
            Label_SouthDakotaCountValue.Text = statistics.SumOfEventsPerState.SouthDakota.ToString();
            Label_TennesseeCountValue.Text = statistics.SumOfEventsPerState.Tennessee.ToString();
            Label_TexasCountValue.Text = statistics.SumOfEventsPerState.Texas.ToString();
            Label_UtahCountValue.Text = statistics.SumOfEventsPerState.Utah.ToString();
            Label_VermontCountValue.Text = statistics.SumOfEventsPerState.Vermont.ToString();
            Label_VirginiaCountValue.Text = statistics.SumOfEventsPerState.Virginia.ToString();
            Label_WashingtonCountValue.Text = statistics.SumOfEventsPerState.Washington.ToString();
            Label_WestVirginiaCountValue.Text = statistics.SumOfEventsPerState.WestVirginia.ToString();
            Label_WisconsinCountValue.Text = statistics.SumOfEventsPerState.Wisconsin.ToString();
            Label_WyomingCountValue.Text = statistics.SumOfEventsPerState.Wyoming.ToString();
            Label_PuertoRicoCountValue.Text = statistics.SumOfEventsPerState.PuertoRico.ToString();
        }

        /// <summary>
        /// Get string value of a month.
        /// </summary>
        /// <param name="month">The integer representation of the month.</param>
        /// <returns>The string representation of the month, e.g. 1 is January.</returns>
        private string GetMonth(int month)
        {
            switch (month)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "";
            }
        }

        /// <summary>
        /// Executed when the selected index is changed in the drop down states list.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void DropDownList_States_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["SelectedState"] = DropDownList_States.SelectedValue;
            PopulateCountiesFromSelectedState();
        }

        /// <summary>
        /// Populate the counties drop down menu from the selected state.
        /// </summary>
        private void PopulateCountiesFromSelectedState()
        {
            if (DropDownList_County.Items.Count != 0)
            {
                DropDownList_County.Items.Clear();
            }

            InitialiseCountiesDropDown(true);

            if (DropDownList_States.SelectedIndex > 1)
            {
                CountyDictionary counties = new CountyDictionary();

                foreach (KeyValuePair<int, string> county in counties.stateCounties[int.Parse(Session["SelectedState"].ToString())])
                {
                    DropDownList_County.Items.Add(new ListItem(county.Value, county.Key.ToString()));
                }
            }
            /*else if (DropDownList_States.SelectedIndex == 1)
            {
                DropDownList_County.Items.Add(new ListItem("All counties...", "0"));
            }*/
        }

        /// <summary>
        /// Validate the severe weather database form.
        /// </summary>
        /// <param name="errors">The string representation of any errors from the form.</param>
        /// <returns>True if the form validated successfully, else false.</returns>
        private bool ValidateSevereWeatherDatabaseForm(ref string errors)
        {
            bool validForm = true;
            bool validStartDate = true;
            bool validEndDate = true;

            string startDateString = TextBox_FromYear.Text + "-" + TextBox_FromMonth.Text + "-" + TextBox_FromDay.Text;
            string endDateString = TextBox_ToYear.Text + "-" + TextBox_ToMonth.Text + "-" + TextBox_ToDay.Text;

            #region Validate From Date
            if (TextBox_FromDay.Text == "")
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start day</b> field was left blank. Please fill this in.<br>";
                TextBox_FromDay.Focus();
            }
            else if (TextBox_FromDay.Text.Length > 2)
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start day</b> field is too long. Please ensure that it contains a maximum of two characters.<br/>";
                TextBox_FromDay.Focus();
            }

            if (TextBox_FromMonth.Text == "")
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start month</b> field was left blank. Please fill this in.<br>";
                TextBox_FromMonth.Focus();
            }
            else if (TextBox_FromMonth.Text.Length > 2)
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start month</b> field is too long. Please ensure that it contains a maximum of two characters.<br/>";
                TextBox_FromMonth.Focus();
            }

            if (TextBox_FromYear.Text == "")
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start year</b> field was left blank. Please fill this in.<br>";
                TextBox_FromYear.Focus();
            }
            else if (TextBox_FromYear.Text.Length != 4)
            {
                validForm = false;
                validStartDate = false;
                errors += "The <b>start year</b> field is not the correct length. Please ensure that it contains exactly four characters.<br/>";
                TextBox_FromYear.Focus();
            }

            if (validStartDate)
            {
                if (!DateTime.TryParse(startDateString, out startDate))
                {
                    validForm = false;
                    validStartDate = false;
                    errors += "The <b>start date</b> does not exist. Please ensure the date entered is correct and try again.<br/>";
                }
                else
                {
                    startDate = new DateTime(int.Parse(TextBox_FromYear.Text), int.Parse(TextBox_FromMonth.Text), int.Parse(TextBox_FromDay.Text));
                }
            }

            #endregion

            #region Validate To Date
            if (TextBox_ToDay.Text.Length > 2)
            {
                validForm = false;
                validEndDate = false;
                errors += "The <b>end day</b> field is too long. Please ensure that it contains a maximum of two characters.<br/>";
                TextBox_ToDay.Focus();
            }

            if (TextBox_ToMonth.Text.Length > 2)
            {
                validForm = false;
                validEndDate = false;
                errors += "The <b>end month</b> field is too long. Please ensure that it contains a maximum of two characters.<br/>";
                TextBox_ToMonth.Focus();
            }

            if (TextBox_ToYear.Text.Length != 4 && TextBox_ToYear.Text != "")
            {
                validForm = false;
                validEndDate = false;
                errors += "The <b>end year</b> field is not the correct length. Please ensure that it contains exactly four characters.<br/>";
                TextBox_ToYear.Focus();
            }

            if (validEndDate)
            {
                if (TextBox_ToDay.Text != "" && TextBox_ToMonth.Text != "" && TextBox_ToYear.Text != "")
                {
                    if (!DateTime.TryParse(endDateString, out endDate))
                    {
                        validForm = false;
                        validEndDate = false;
                        errors += "The <b>end date</b> does not exist. Please ensure the date entered is correct and try again.<br/>";
                    }
                    else
                    {
                        endDate = new DateTime(int.Parse(TextBox_ToYear.Text), int.Parse(TextBox_ToMonth.Text), int.Parse(TextBox_ToDay.Text));
                    }
                }
            }
            #endregion

            #region Check From Date Against End Date
            if ((TextBox_FromDay.Text == "" && TextBox_FromMonth.Text == "" && TextBox_FromYear.Text == "") && (TextBox_ToDay.Text != "" && TextBox_ToMonth.Text != "" && TextBox_ToYear.Text != ""))
            {
                validForm = false;
                errors += "There is no <b>start date</b> specified, but an end date. To query for only one day, use the start date field only.<br>";
                TextBox_ToDay.Text = "";
                TextBox_ToMonth.Text = "";
                TextBox_ToYear.Text = "";
                TextBox_ToDay.Focus();
            }

            if (TextBox_ToDay.Text != "" && TextBox_ToMonth.Text != "" && TextBox_ToYear.Text != "")
            {
                if (endDate < startDate)
                {
                    validForm = false;
                    errors += "The <b>end date</b> is before the <b>start date</b>.<br/>";
                    TextBox_FromDay.Text = "";
                    TextBox_FromMonth.Text = "";
                    TextBox_FromYear.Text = "";
                    TextBox_ToDay.Text = "";
                    TextBox_ToMonth.Text = "";
                    TextBox_ToYear.Text = "";

                    TextBox_FromDay.Focus();
                }
            }
            #endregion

            #region Checking Location Criteria
            int stateFIPS = -99;
            int countyFIPS = -99;
            bool validFIPSCodes = true;

            if (!CheckBox_EnableFIPSCodes.Checked)
            {
                if (DropDownList_States.SelectedIndex == 0 && DropDownList_County.SelectedIndex == 0)
                {
                    validForm = false;
                    errors += "There is no <b>location information</b> selected. If you do not wish to query by location, select All States and All Counties.<br/>";
                    DropDownList_States.Focus();
                }
                else if (DropDownList_States.SelectedIndex != 0 && DropDownList_County.SelectedIndex == 0)
                {
                    validForm = false;
                    errors += "There is no <b>county</b> selected for this state. If you do not wish to query by county, select All Counties from the County drop down menu.<br/>";
                    DropDownList_County.Focus();
                }
            }
            else
            {
                if (TextBox_StateFIPS.Text == "" && TextBox_CountyFIPS.Text == "")
                {
                    validForm = false;
                    errors += "There is no <b>location information</b> selected. If you do not wish to query by location, enter 0 for both state and county FIPS codes.<br/>";
                    TextBox_StateFIPS.Focus();
                }
                else if (TextBox_StateFIPS.Text != "" && TextBox_CountyFIPS.Text == "")
                {
                    validForm = false;
                    errors += "There is no <b>county</b> selected. If you do not wish to query by county, enter zero for a county FIPS code.<br/>";
                    TextBox_CountyFIPS.Focus();
                }

                if (!int.TryParse(TextBox_StateFIPS.Text, out stateFIPS))
                {
                    validForm = false;
                    validFIPSCodes = false;
                    errors += "The <b>state FIPS code</b> entered is not a numeric value. Please enter a number in this field. A full list of state FIPS codes can be seen in the help section.<br/>";
                    TextBox_StateFIPS.Focus();

                }

                if (!int.TryParse(TextBox_CountyFIPS.Text, out countyFIPS))
                {
                    validForm = false;
                    validFIPSCodes = false;
                    errors += "The <b> county FIPS code</b> entered is not a numeric value. Please enter a number in this field. A full list of county FIPS codes can be seen in the help section.<br/>";
                    TextBox_CountyFIPS.Focus();
                }

                if (validFIPSCodes)
                {
                    Location location = new Location();
                    location.StateFIPS = int.Parse(TextBox_StateFIPS.Text);
                    location.CountyFIPS = int.Parse(TextBox_CountyFIPS.Text);
                    if (!location.CheckFIPSCodes())
                    {
                        validForm = false;
                        errors += "The <b>FIPS codes</b> entered do not represent a valid state and county. Please correct this. A full list of state and county FIPS codes can be seen in the help section.<br/>";
                        TextBox_CountyFIPS.Focus();
                    }
                }
            }
            #endregion

            // There is no need to check any validation on the event types checkbox as there is no way of formulating errors in the application.

            return validForm;
        }

        /// <summary>
        /// Setup the query.
        /// </summary>
        private void SetupQueryRequest()
        {
            request = new QueryRequest();
            request.StartDate = startDate;
            request.EndDate = endDate;

            if (!CheckBox_EnableFIPSCodes.Checked)
            {
                request.Location.State = DropDownList_States.SelectedItem.Text;
                request.Location.County = DropDownList_County.SelectedItem.Text;
            }
            else
            {

                if (TextBox_StateFIPS.Text != "0" && TextBox_CountyFIPS.Text == "0")
                {
                    request.Location.StateFIPS = int.Parse(TextBox_StateFIPS.Text);
                    request.Location.State = request.Location.GetStateNameFromFIPSCode();
                }
                else if (TextBox_StateFIPS.Text != "0" && TextBox_CountyFIPS.Text != "0")
                {
                    request.Location.StateFIPS = int.Parse(TextBox_StateFIPS.Text);
                    request.Location.CountyFIPS = int.Parse(TextBox_CountyFIPS.Text);
                    request.Location.State = request.Location.GetStateNameFromFIPSCode();
                    request.Location.County = request.Location.GetCountyNameFromStateAndCountyFIPSCode();
                }
                else
                {
                    request.Location.State = "All States";
                    request.Location.County = "All Counties";
                }
            }

            SetupSelectedEventTypes(request);

            if (CheckBox_Tornado.Checked)
            {
                if (DropDownList_TornadoEventScaleFrom.SelectedIndex != 0)
                {
                    string tornadoStartValue = DropDownList_TornadoEventScaleFrom.SelectedValue;

                    switch (tornadoStartValue)
                    {
                        case "F0 / EF0":
                            request.TornadoStartRangeValue = 0;
                            break;
                        case "F1 / EF1":
                            request.TornadoStartRangeValue = 1;
                            break;
                        case "F2 / EF2":
                            request.TornadoStartRangeValue = 2;
                            break;
                        case "F3 / EF3":
                            request.TornadoStartRangeValue = 3;
                            break;
                        case "F4 / EF4":
                            request.TornadoStartRangeValue = 4;
                            break;
                        case "F5 / EF5":
                            request.TornadoStartRangeValue = 5;
                            break;
                        default:
                            throw new Exception("Error 7001: The specified start tornado intensity was invalid");
                    }
                }
            }
        }

        /// <summary>
        /// Setup the selected event types from the form.
        /// </summary>
        /// <param name="request">This query request.</param>
        private void SetupSelectedEventTypes(QueryRequest request)
        {
            if (CheckBox_AstronomicalLowTide.Checked)
            {
                request.EventType.IsAstronomicalLowTideSelected = true;
            }
            else
            {
                request.EventType.IsAstronomicalLowTideSelected = false;
            }

            if (CheckBox_Avalanche.Checked)
            {
                request.EventType.IsAvalancheSelected = true;
            }
            else
            {
                request.EventType.IsAvalancheSelected = false;
            }

            if (CheckBox_Blizzard.Checked)
            {
                request.EventType.IsBlizzardSelected = true;
            }
            else
            {
                request.EventType.IsBlizzardSelected = false;
            }

            if (CheckBox_CoastalFlood.Checked)
            {
                request.EventType.IsCoastalFloodSelected = true;
            }
            else
            {
                request.EventType.IsCoastalFloodSelected = false;
            }

            if (CheckBox_ColdWindChill.Checked)
            {
                request.EventType.IsColdWindChillSelected = true;
            }
            else
            {
                request.EventType.IsColdWindChillSelected = false;
            }

            if (CheckBox_DebrisFlow.Checked)
            {
                request.EventType.IsDebrisFlowSelected = true;
            }
            else
            {
                request.EventType.IsDebrisFlowSelected = false;
            }

            if (CheckBox_DenseFog.Checked)
            {
                request.EventType.IsDenseFogSelected = true;
            }
            else
            {
                request.EventType.IsDenseFogSelected = false;
            }

            if (CheckBox_DenseSmoke.Checked)
            {
                request.EventType.IsDenseSmokeSelected = true;
            }
            else
            {
                request.EventType.IsDenseSmokeSelected = false;
            }

            if (CheckBox_Drought.Checked)
            {
                request.EventType.IsDroughtSelected = true;
            }
            else
            {
                request.EventType.IsDroughtSelected = false;
            }

            if (CheckBox_DustDevil.Checked)
            {
                request.EventType.IsDustDevilSelected = true;
            }
            else
            {
                request.EventType.IsDustDevilSelected = false;
            }

            if (CheckBox_DustStorm.Checked)
            {
                request.EventType.IsDustStormSelected = true;
            }
            else
            {
                request.EventType.IsDustStormSelected = false;
            }

            if (CheckBox_ExcessiveHeat.Checked)
            {
                request.EventType.IsExcessiveHeatSelected = true;
            }
            else
            {
                request.EventType.IsExcessiveHeatSelected = false;
            }

            if (CheckBox_ExtremeColdWindChill.Checked)
            {
                request.EventType.IsExtremeColdWindChillSelected = true;
            }
            else
            {
                request.EventType.IsExtremeColdWindChillSelected = false;
            }

            if (CheckBox_FlashFlood.Checked)
            {
                request.EventType.IsFlashFloodSelected = true;
            }
            else
            {
                request.EventType.IsFlashFloodSelected = false;
            }

            if (CheckBox_Flood.Checked)
            {
                request.EventType.IsFloodSelected = true;
            }
            else
            {
                request.EventType.IsFloodSelected = false;
            }

            if (CheckBox_FreezingFog.Checked)
            {
                request.EventType.IsFreezingFogSelected = true;
            }
            else
            {
                request.EventType.IsFreezingFogSelected = false;
            }

            if (CheckBox_FrostFreeze.Checked)
            {
                request.EventType.IsFrostFreezeSelected = true;
            }
            else
            {
                request.EventType.IsFrostFreezeSelected = false;
            }

            if (CheckBox_FunnelCloud.Checked)
            {
                request.EventType.IsFunnelCloudSelected = true;
            }
            else
            {
                request.EventType.IsFunnelCloudSelected = false;
            }

            if (CheckBox_Hail.Checked)
            {
                request.EventType.IsHailSelected = true;
            }
            else
            {
                request.EventType.IsHailSelected = false;
            }

            if (CheckBox_Heat.Checked)
            {
                request.EventType.IsHeatSelected = true;
            }
            else
            {
                request.EventType.IsHeatSelected = false;
            }

            if (CheckBox_HeavyRain.Checked)
            {
                request.EventType.IsHeavyRainSelected = true;
            }
            else
            {
                request.EventType.IsHeavyRainSelected = false;
            }

            if (CheckBox_HeavySnow.Checked)
            {
                request.EventType.IsHeavySnowSelected = true;
            }
            else
            {
                request.EventType.IsHeavySnowSelected = false;
            }

            if (CheckBox_HeavyWind.Checked)
            {
                request.EventType.IsHeavyWindSelected = true;
            }
            else
            {
                request.EventType.IsHeavyWindSelected = false;
            }

            if (CheckBox_HighSnow.Checked)
            {
                request.EventType.IsHighSnowSelected = true;
            }
            else
            {
                request.EventType.IsHighSnowSelected = false;
            }

            if (CheckBox_HighSurf.Checked)
            {
                request.EventType.IsHighSurfSelected = true;
            }
            else
            {
                request.EventType.IsHighSurfSelected = false;
            }

            if (CheckBox_HighWind.Checked)
            {
                request.EventType.IsHighWindSelected = true;
            }
            else
            {
                request.EventType.IsHighWindSelected = false;
            }

            if (CheckBox_Hurricane.Checked)
            {
                request.EventType.IsHurricaneSelected = true;
            }
            else
            {
                request.EventType.IsHurricaneSelected = false;
            }

            if (CheckBox_IceStorm.Checked)
            {
                request.EventType.IsIceStormSelected = true;
            }
            else
            {
                request.EventType.IsIceStormSelected = false;
            }

            if (CheckBox_LakeEffectSnow.Checked)
            {
                request.EventType.IsLakeEffectSnowSelected = true;
            }
            else
            {
                request.EventType.IsLakeEffectSnowSelected = false;
            }

            if (CheckBox_LakeshoreFlood.Checked)
            {
                request.EventType.IsLakeshoreFloodSelected = true;
            }
            else
            {
                request.EventType.IsLakeshoreFloodSelected = false;
            }

            if (CheckBox_Landslide.Checked)
            {
                request.EventType.IsLandslideSelected = true;
            }
            else
            {
                request.EventType.IsLandslideSelected = false;
            }

            if (CheckBox_Lightning.Checked)
            {
                request.EventType.IsLightningSelected = true;
            }
            else
            {
                request.EventType.IsLightningSelected = false;
            }

            if (CheckBox_MarineDenseFog.Checked)
            {
                request.EventType.IsMarineDenseFogSelected = true;
            }
            else
            {
                request.EventType.IsMarineDenseFogSelected = false;
            }

            if (CheckBox_MarineHail.Checked)
            {
                request.EventType.IsMarineHailSelected = true;
            }
            else
            {
                request.EventType.IsMarineHailSelected = false;
            }

            if (CheckBox_MarineHighWind.Checked)
            {
                request.EventType.IsMarineHighWindSelected = true;
            }
            else
            {
                request.EventType.IsMarineHighWindSelected = false;
            }

            if (CheckBox_MarineStrongWind.Checked)
            {
                request.EventType.IsMarineStrongWindSelected = true;
            }
            else
            {
                request.EventType.IsMarineStrongWindSelected = false;
            }

            if (CheckBox_MarineThunderstormWind.Checked)
            {
                request.EventType.IsMarineThunderstormWindSelected = true;
            }
            else
            {
                request.EventType.IsMarineThunderstormWindSelected = false;
            }

            if (CheckBox_MarineTropicalStorm.Checked)
            {
                request.EventType.IsMarineTropicalStormSelected = true;
            }
            else
            {
                request.EventType.IsMarineTropicalStormSelected = false;
            }

            if (CheckBox_NorthernLights.Checked)
            {
                request.EventType.IsNorthernLightsSelected = true;
            }
            else
            {
                request.EventType.IsNorthernLightsSelected = false;
            }

            if (CheckBox_Other.Checked)
            {
                request.EventType.IsOtherSelected = true;
            }
            else
            {
                request.EventType.IsOtherSelected = false;
            }

            if (CheckBox_RipCurrent.Checked)
            {
                request.EventType.IsRipCurrentSelected = true;
            }
            else
            {
                request.EventType.IsRipCurrentSelected = false;
            }

            if (CheckBox_Seiche.Checked)
            {
                request.EventType.IsSeicheSelected = true;
            }
            else
            {
                request.EventType.IsSeicheSelected = false;
            }

            if (CheckBox_Sleet.Checked)
            {
                request.EventType.IsSleetSelected = true;
            }
            else
            {
                request.EventType.IsSleetSelected = false;
            }

            if (CheckBox_StormSurgeTide.Checked)
            {
                request.EventType.IsStormSurgeTideSelected = true;
            }
            else
            {
                request.EventType.IsStormSurgeTideSelected = false;
            }

            if (CheckBox_StrongWind.Checked)
            {
                request.EventType.IsStrongWindSelected = true;
            }
            else
            {
                request.EventType.IsStrongWindSelected = false;
            }

            if (CheckBox_ThunderstormWind.Checked)
            {
                request.EventType.IsThunderstormWindSelected = true;
            }
            else
            {
                request.EventType.IsThunderstormWindSelected = false;
            }

            if (CheckBox_Tornado.Checked)
            {
                request.EventType.IsTornadoSelected = true;
            }
            else
            {
                request.EventType.IsTornadoSelected = false;
            }

            if (CheckBox_TropicalDepression.Checked)
            {
                request.EventType.IsTropicalDepressionSelected = true;
            }
            else
            {
                request.EventType.IsTropicalDepressionSelected = false;
            }

            if (CheckBox_TropicalStorm.Checked)
            {
                request.EventType.IsTropicalStormSelected = true;
            }
            else
            {
                request.EventType.IsTropicalStormSelected = false;
            }

            if (CheckBox_Tsunami.Checked)
            {
                request.EventType.IsTsunamiSelected = true;
            }
            else
            {
                request.EventType.IsTsunamiSelected = false;
            }

            if (CheckBox_VolcanicAsh.Checked)
            {
                request.EventType.IsVolcanicAshSelected = true;
            }
            else
            {
                request.EventType.IsVolcanicAshSelected = false;
            }

            if (CheckBox_VolcanicAshfall.Checked)
            {
                request.EventType.IsVolcanicAshfallSelected = true;
            }
            else
            {
                request.EventType.IsVolcanicAshfallSelected = false;
            }

            if (CheckBox_Waterspout.Checked)
            {
                request.EventType.IsWaterspoutSelected = true;
            }
            else
            {
                request.EventType.IsWaterspoutSelected = false;
            }

            if (CheckBox_Wildfire.Checked)
            {
                request.EventType.IsWildfireSelected = true;
            }
            else
            {
                request.EventType.IsWildfireSelected = false;
            }

            if (CheckBox_WinterStorm.Checked)
            {
                request.EventType.IsWinterStormSelected = true;
            }
            else
            {
                request.EventType.IsWinterStormSelected = false;
            }

            if (CheckBox_WinterWeather.Checked)
            {
                request.EventType.IsWinterWeatherSelected = true;
            }
            else
            {
                request.EventType.IsWinterWeatherSelected = false;
            }
        }

        /// <summary>
        /// Executed when the Enable FIPS Codes Check Box is checked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void CheckBox_EnableFIPSCodes_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_EnableFIPSCodes.Checked)
            {
                DropDownList_States.Enabled = false;
                DropDownList_County.Enabled = false;
                TextBox_StateFIPS.Enabled = true;
                TextBox_CountyFIPS.Enabled = true;
            }
            else
            {
                TextBox_StateFIPS.Text = "0";
                TextBox_CountyFIPS.Text = "0";
                DropDownList_States.Enabled = true;
                DropDownList_County.Enabled = true;
                TextBox_StateFIPS.Enabled = false;
                TextBox_CountyFIPS.Enabled = false;
                DropDownList_States.SelectedIndex = 0;
                DropDownList_County.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Executed when the Export Results button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_ExportResults_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath("../query-results/results-" + username + ".xls"));

            if (file.Exists)
            {
                Response.Clear();
                Response.ClearHeaders();
                Response.ClearContent();
                Response.AddHeader("content-disposition", "attachment; filename=" + username + "-results.xls");
                Response.AddHeader("Content-Type", "application/Excel");
                Response.ContentType = "application/vnd.xls";
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.WriteFile(file.FullName);
                Response.End();
            }
        }

        /// <summary>
        /// Executed when the Export Statistics button is clicked.
        /// </summary>
        /// <param name="sender">The control that caused this event handler to be executed.</param>
        /// <param name="e">Event data relating to this event.</param>
        protected void Button_ExportStatistics_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            FileInfo file = new FileInfo(HttpContext.Current.Server.MapPath("../query-results/statistics-" + username + ".xls"));

            if (file.Exists)
            {
                Response.Clear();
                Response.ClearHeaders();
                Response.ClearContent();
                Response.AddHeader("content-disposition", "attachment; filename=" + username + "-statistics.xls");
                Response.AddHeader("Content-Type", "application/Excel");
                Response.ContentType = "application/vnd.xls";
                Response.AddHeader("Content-Length", file.Length.ToString());
                Response.WriteFile(file.FullName);
                Response.End();
            }
        }
    }
}