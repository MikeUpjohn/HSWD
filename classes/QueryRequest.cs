using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using artefact.enums;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Collections;
using System.Xml;
using System.IO;
using Microsoft.Office.Interop.Excel;

namespace artefact.classes
{
    public class QueryRequest
    {
        private string query;
        private DateTime startDate;
        private DateTime endDate;
        private Location location;
        private EventType eventType;
        private int tornadoStartRangeValue;
        private int tornadoEndRangeValue;

        private bool isFirstWhereClauseAlreadyAdded;
        private bool isFirstInStatementAlreadyAdded;
        private SqlConnection connection = new SqlConnection("Data Source=www.mike-upjohn.com;Initial Catalog=hswd;User ID=mikeofmacc;Password=F1b8leSurtSH");
        

        #region Properties
        /// <summary>
        /// Query property
        /// </summary>
        public string Query
        {
            get
            {
                return this.query;
            }

            set
            {
                this.query = value;
            }
        }

        /// <summary>
        /// Start date property
        /// </summary>
        public DateTime StartDate
        {

            get
            {
                return this.startDate;
            }

            set
            {
                this.startDate = value;
            }

        }

        /// <summary>
        /// End date property
        /// </summary>
        public DateTime EndDate
        {
            get
            {
                return this.endDate;
            }
            set
            {
                this.endDate = value;
            }
        }

        /// <summary>
        /// Location property
        /// </summary>
        public Location Location
        {
            get
            {
                return this.location;
            }
            set
            {
                this.location = value;
            }
        }

        /// <summary>
        /// Event type property
        /// </summary>
        public EventType EventType
        {
            get
            {
                return this.eventType;
            }

            set
            {
                this.eventType = value;
            }
        }

        /// <summary>
        /// Tornado start range value property
        /// </summary>
        public int TornadoStartRangeValue
        {
            get
            {
                return this.tornadoStartRangeValue;
            }

            set
            {
                this.tornadoStartRangeValue = value;
            }
        }

        /// <summary>
        /// Tornado end range value property
        /// </summary>
        public int TornadoEndRangeValue
        {
            get
            {
                return this.tornadoEndRangeValue;
            }

            set
            {
                this.tornadoEndRangeValue = value;
            }
        }
        #endregion

        /// <summary>
        /// Empty Constructor
        /// </summary>
        public QueryRequest()
        {
            query = "";

            location = new Location();
            eventType = new EventType();

            isFirstWhereClauseAlreadyAdded = false;
            isFirstInStatementAlreadyAdded = false;
        }

        /// <summary>
        /// Create a customised query
        /// </summary>
        /// <param name="tornadoCriteriaSelected">A boolean representation of whether the tornado criteria was enabled on the form.</param>
        public void CreateQuery(bool tornadoCriteriaSelected)
        {
            query = InitialiseQuery();
            query = BuildQueryDateCriteria(ref isFirstWhereClauseAlreadyAdded);
            query = BuildQueryLocationCriteria(ref isFirstWhereClauseAlreadyAdded);
            query = EventType.GenerateEventQuery(ref isFirstWhereClauseAlreadyAdded, ref isFirstInStatementAlreadyAdded, query);

            if (tornadoCriteriaSelected)
            {
                query = BuildQueryTornadoCritieria(ref isFirstWhereClauseAlreadyAdded);
            }
        }

        /// <summary>
        /// Write the initial part of the query, that is standard to all queries.
        /// </summary>
        /// <returns>The string representation of the first part of the query.</returns>
        public string InitialiseQuery()
        {
            query = "SELECT TOP 10000 * FROM [Event] ";
            return query;
        }

        /// <summary>
        /// Build the date component of the customised query.
        /// </summary>
        /// <param name="isFirstWhereClauseAlreadyAdded">A flag to represent whether the first where clause has already been added to the current query.</param>
        /// <returns>The string representation of the current query.</returns>
        public string BuildQueryDateCriteria(ref bool isFirstWhereClauseAlreadyAdded)
        {
            if (EndDate != DateTime.MinValue)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    query += "WHERE CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2)) >= '" + StartDate.ToString("yyyy-MM-dd") + "' AND CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2)) <= '" + EndDate.ToString("yyyy-MM-dd") + "' ";
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    query += "AND CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2)) >= '" + StartDate.ToString("yyyy-MM-dd") + "' AND CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2))<= '" + EndDate.ToString("yyyy-MM-dd") + "' ";
                }
            }
            else
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    query += "WHERE CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2)) = '" + StartDate.ToString("yyyy-MM-dd") + "' ";
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    query += "AND CONCAT([BeginYear],'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginMonth]),2),'-',RIGHT('0'+ CONVERT(VARCHAR,[BeginDay]),2)) = '" + StartDate.ToString("yyyy-MM-dd") + "' ";
                }
            }

            return query;
        }

        /// <summary>
        /// Build the location component of the customised query.
        /// </summary>
        /// <param name="isFirstWhereClauseAlreadyAdded">A flag to represent whether the first where clause has already been added to the current query.</param>
        /// <returns>The string representation of the current query.</returns>
        public string BuildQueryLocationCriteria(ref bool isFirstWhereClauseAlreadyAdded)
        {
            if (location.State != "Choose a state..." && location.County != "Choose a county...")
            {
                if (location.State != "All States" && location.County != "All Counties")
                {
                    if (!isFirstWhereClauseAlreadyAdded)
                    {
                        query += "WHERE [State] = '" + location.State + "' AND [County] = '" + location.County + "' ";
                        isFirstWhereClauseAlreadyAdded = true;
                    }
                    else
                    {
                        query += "AND [State] = '" + location.State + "' AND [County] = '" + location.County + "' ";
                    }
                }
                else
                {
                    if (location.State != "All States")
                    {
                        if (!isFirstWhereClauseAlreadyAdded)
                        {
                            query += "WHERE [State] ='" + location.State + "' ";
                            isFirstWhereClauseAlreadyAdded = true;
                        }
                        else
                        {
                            query += "AND [State] ='" + location.State + "' ";
                        }
                    }
                }
            }
            else if (location.State != "Choose a state..." && (location.County == "Choose a county..." || location.County == "All Counties"))
            {
                if (location.State != "All States")
                {
                    if (!isFirstWhereClauseAlreadyAdded)
                    {
                        query += "WHERE [State] ='" + location.State + "' ";
                        isFirstWhereClauseAlreadyAdded = true;
                    }
                    else
                    {
                        query += "AND [State] ='" + location.State + "' ";
                    }
                }
            }

            return query;
        }

        /// <summary>
        /// Build the tornado component of the customised query.
        /// </summary>
        /// <param name="isFirstWhereClauseAlreadyAdded">A flag to represent whether the first where clause has already been added to the current query.</param>
        /// <returns>The string representation of the current query.</returns>
        public string BuildQueryTornadoCritieria(ref bool isFirstWhereClauseAlreadyAdded)
        {
            if (!isFirstWhereClauseAlreadyAdded)
            {
                query += "WHERE [TornadoFScale] IN('F" + tornadoStartRangeValue + "','EF" + tornadoStartRangeValue + "') ";
                isFirstWhereClauseAlreadyAdded = true;
            }
            else
            {
                query += "AND [TornadoFScale] IN('F" + tornadoStartRangeValue + "','EF" + tornadoStartRangeValue + "') ";
                isFirstWhereClauseAlreadyAdded = true;
            }

            return query;
        }

        /// <summary>
        /// Run the customised query.
        /// </summary>
        /// <param name="query">The query string to be run.</param>
        /// <returns>A DataTable of the data selected from running this query.</returns>
        public System.Data.DataTable RunQuery(string query)
        {
            try
            {
                System.Data.DataTable table = new System.Data.DataTable();
                SqlCommand command = new SqlCommand(query);
                command.Connection = connection;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                connection.Close();
                adapter.Dispose();

                return table;
            }
            catch (Exception ex)
            {
                throw new Exception("Error 9003: The database query was badly formatted.", ex);
            }
        }

        /// <summary>
        /// Draw the map of the selected events.
        /// </summary>
        /// <param name="table">The table of data of selected results to plot.</param>
        /// <returns></returns>
        public StringBuilder PrepareMap(System.Data.DataTable table)
        {
            if (table != null)
            {
                StringBuilder sb = new StringBuilder();
                string startDate = "";
                string startTime = "";

                sb.Append("var map;function initialize() {var myLatlng = new google.maps.LatLng(39.828328, -98.579416);var mapOptions = {zoom: 4,center: myLatlng,mapTypeId: google.maps.MapTypeId.ROADMAP};map = new google.maps.Map(document.getElementById('map'), mapOptions);");
                foreach (DataRow row in table.Rows)
                {
                    startDate = row[10] + " " + GetMonth(int.Parse(row[9].ToString())) + row[8];
                    startTime = PadTime(row[11].ToString(), 4);

                    if (row[17].ToString().ToLower() != "tornado")
                    {
                        PlotAllPoints(ref sb, row[24].ToString(), row[25].ToString(), row[17].ToString(), startDate, startTime);
                    }
                    else
                    {
                        if (row[26].ToString() != "" && row[27].ToString() != "")
                        {
                            PlotTornadoTracks(ref sb, row[24].ToString(), row[25].ToString(), row[26].ToString(), row[27].ToString(), row[17].ToString(), startDate, startTime);
                        }
                        else
                        {
                            PlotAllPoints(ref sb, row[24].ToString(), row[25].ToString(), row[17].ToString(), startDate, startTime);
                        }
                    }
                }
                sb.Append("}");
                sb.Append("google.maps.event.addDomListener(window, 'load', initialize)");

                return sb;
            }
            else
            {
                throw new Exception("Error 9002: Data table was null.");
            }
        }

        /// <summary>
        /// Plot all points on the map.
        /// </summary>
        /// <param name="sb">A string representation of the JavaScript to be executed to draw the map.</param>
        /// <param name="latitude">The latitude of the point.</param>
        /// <param name="longitude">The longitude of the point.</param>
        /// <param name="eventType">The event type.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="startTime">The start time.</param>
        private void PlotAllPoints(ref StringBuilder sb, string latitude, string longitude, string eventType, string startDate, string startTime)
        {
            if (sb != null && latitude != "" && longitude != "" && eventType != "" && startDate != "" && startTime != "")
            {
                string position = "new google.maps.LatLng(" + latitude + "," + longitude + ")";
                string title = eventType + " - " + startDate + " at " + startTime;
                string icon = LoadWeatherIcon(eventType);
                sb.Append("var marker = new google.maps.Marker({position: " + position + ",map: map,title: '" + title + "',icon: '" + icon + "'});");
            }
            else
            {
                throw new Exception("Error 9000: Not all data is present to plot the points on the map.");
            }
        }

        /// <summary>
        /// Plot all tornado tracks on the map.
        /// </summary>
        /// <param name="sb">A string representation of the JavaScript to be executed to draw the map.</param>
        /// <param name="startLatitude">The start latitude.</param>
        /// <param name="startLongitude">The start longitude.</param>
        /// <param name="endLatitude">The end latitiude.</param>
        /// <param name="endLongitude">The end longitude.</param>
        /// <param name="eventType">The event type.</param>
        /// <param name="startDate">The start date.</param>
        /// <param name="startTime">The start time.</param>
        private void PlotTornadoTracks(ref StringBuilder sb, string startLatitude, string startLongitude, string endLatitude, string endLongitude, string eventType, string startDate, string startTime)
        {
            string tornadoTrackPoints = "var tornadoTrack = [new google.maps.LatLng(" + startLatitude + "," + startLongitude + "),new google.maps.LatLng(" + endLatitude + "," + endLongitude + ")];";
            string tornadoPath = "var tornadoPath = new google.maps.Polyline({path: tornadoTrack, strokeColor: '#FF0000', strokeOpacity: 1.0, strokeWeight: 2});";
            sb.Append(tornadoTrackPoints);
            sb.Append(tornadoPath);
            sb.Append("tornadoPath.setMap(map);");
        }

        /// <summary>
        /// Load a weather icon for a given event.
        /// </summary>
        /// <param name="weatherEvent">The weather event to load the icon for.</param>
        /// <returns>The URL to the appropriate weather icon for this event.</returns>
        private string LoadWeatherIcon(string weatherEvent)
        {
            weatherEvent = weatherEvent.ToLower();
            var imageURL = "";

            if (weatherEvent == "astronomical low tide")
            {
                imageURL = "../images/icons/astronimcal-low-tide.png";
            }
            else if (weatherEvent == "avalanche")
            {
                imageURL = "../images/icons/avalanche.png";
            }
            else if (weatherEvent == "blizzard")
            {
                imageURL = "../images/icons/blizzard.png";
            }
            else if (weatherEvent == "coastal flood")
            {
                imageURL = "../images/icons/coastal-flood.png";
            }
            else if (weatherEvent == "cold / wind chill")
            {
                imageURL = "../images/icons/cold-wind-chill.png";
            }
            else if (weatherEvent == "debris flow")
            {
                imageURL = "../images/icons/debris-flow.png";
            }
            else if (weatherEvent == "dense fog")
            {
                imageURL = "../images/icons/dense-fog.png";
            }
            else if (weatherEvent == "dense smoke")
            {
                imageURL = "../images/icons/dense-smoke.png";
            }
            else if (weatherEvent == "drought")
            {
                imageURL = "../images/icons/drought.png";
            }
            else if (weatherEvent == "dust devil")
            {
                imageURL = "../images/icons/dust-devil.png";
            }
            else if (weatherEvent == "dust storm")
            {
                imageURL = "../images/icons/dust-storm.png";
            }
            else if (weatherEvent == "excessive heat")
            {
                imageURL = "../images/icons/excessive-heat.png";
            }
            else if (weatherEvent == "extreme cold / wind chill")
            {
                imageURL = "../images/icons/extreme-cold-wind-chill.png";
            }
            else if (weatherEvent == "flash flood")
            {
                imageURL = "../images/icons/flash-flood.png";
            }
            else if (weatherEvent == "flood")
            {
                imageURL = "../images/icons/flood.png";
            }
            else if (weatherEvent == "freezing fog")
            {
                imageURL = "../images/icons/freezing-fog.png";
            }
            else if (weatherEvent == "frost / freeze")
            {
                imageURL = "../images/icons/frost-freeze.png";
            }
            else if (weatherEvent == "funnel cloud")
            {
                imageURL = "../images/icons/funnel-cloud.png";
            }
            else if (weatherEvent == "hail")
            {
                imageURL = "../images/icons/hail.png";
            }
            else if (weatherEvent == "heat")
            {
                imageURL = "../images/icons/heat.png";
            }
            else if (weatherEvent == "heavy rain")
            {
                imageURL = "../images/icons/heavy-rain.png";
            }
            else if (weatherEvent == "heavy snow")
            {
                imageURL = "../images/icons/heavy-snow.png";
            }
            else if (weatherEvent == "heavy wind")
            {
                imageURL = "../images/icons/heavy-wind.png";
            }
            else if (weatherEvent == "high snow")
            {
                imageURL = "../images/icons/high-snow.png";
            }
            else if (weatherEvent == "high surf")
            {
                imageURL = "../images/icons/high-surf.png";
            }
            else if (weatherEvent == "high wind")
            {
                imageURL = "../images/icons/high-wind.png";
            }
            else if (weatherEvent == "hurricane")
            {
                imageURL = "../images/icons/hurricane.png";
            }
            else if (weatherEvent == "ice storm")
            {
                imageURL = "../images/icons/ice-storm.png";
            }
            else if (weatherEvent == "lake effect snow")
            {
                imageURL = "../images/icons/lake-effect-snow.png";
            }
            else if (weatherEvent == "lakeshore flood")
            {
                imageURL = "../images/icons/lakeshore-flood.png";
            }
            else if (weatherEvent == "landslide")
            {
                imageURL = "../images/icons/landslide.png";
            }
            else if (weatherEvent == "lightning")
            {
                imageURL = "../images/icons/lightning.png";
            }
            else if (weatherEvent == "marine dense fog")
            {
                imageURL = "../images/icons/marine-dense-fog.png";
            }
            else if (weatherEvent == "marine hail")
            {
                imageURL = "../images/icons/marine-hail.png";
            }
            else if (weatherEvent == "marine high wind")
            {
                imageURL = "../images/icons/marine-high-wind.png";
            }
            else if (weatherEvent == "marine strong wind")
            {
                imageURL = "../images/icons/marine-strong-wind.png";
            }
            else if (weatherEvent == "marine thunderstorm wind")
            {
                imageURL = "../images/icons/marine-thunderstorm-wind.png";
            }
            else if (weatherEvent == "marine tropical storm")
            {
                imageURL = "../images/icons/marine-tropical-storm.png";
            }
            else if (weatherEvent == "northern lights")
            {
                imageURL = "../images/icons/northern-lights.png";
            }
            else if (weatherEvent == "other")
            {
                imageURL = "../images/icons/other.png";
            }
            else if (weatherEvent == "rip current")
            {
                imageURL = "../images/icons/rip-current.png";
            }
            else if (weatherEvent == "seiche")
            {
                imageURL = "../images/icons/seiche.png";
            }
            else if (weatherEvent == "sleet")
            {
                imageURL = "../images/icons/sleet.png";
            }
            else if (weatherEvent == "storm surge tide")
            {
                imageURL = "../images/icons/storm-surge-tide.png";
            }
            else if (weatherEvent == "strong wind")
            {
                imageURL = "../images/icons/strong-wind.png";
            }
            else if (weatherEvent == "thunderstorm wind")
            {
                imageURL = "../images/icons/thunderstorm-wind.png";
            }
            else if (weatherEvent == "tornado")
            {
                imageURL = "../images/icons/tornado.png";
            }
            else if (weatherEvent == "tropical depression")
            {
                imageURL = "../images/icons/tropical-depression.png";
            }
            else if (weatherEvent == "tropical storm")
            {
                imageURL = "../images/icons/tropical-storm.png";
            }
            else if (weatherEvent == "tsunami")
            {
                imageURL = "../images/icons/tsunami.png";
            }
            else if (weatherEvent == "volcanic ash")
            {
                imageURL = "../images/icons/volcanic-ash.png";
            }
            else if (weatherEvent == "volcanic ashfall")
            {
                imageURL = "../images/icons/volcanic-ashfall.png";
            }
            else if (weatherEvent == "waterspout")
            {
                imageURL = "../images/icons/waterspout.png";
            }
            else if (weatherEvent == "wildfire")
            {
                imageURL = "../images/icons/wildfire.png";
            }
            else if (weatherEvent == "winter storm")
            {
                imageURL = "../images/icons/winter-storm.png";
            }
            else if (weatherEvent == "winter weatherEvent")
            {
                imageURL = "../images/icons/winter-weatherEvent.png";
            }
            else
            {
                imageURL = "../images/icons/other.png";
            }

            return imageURL;
        }

        /// <summary>
        /// Get a month name.
        /// </summary>
        /// <param name="month">The integer representation of the month (e.g. 1 is January).</param>
        /// <returns>The string representation of the month (e.g. January).</returns>
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
        /// Pad a time value.
        /// </summary>
        /// <param name="time">A string representation of the time to pad.</param>
        /// <param name="size">The size of the time to pad to (e.g. 4 for 00:00).</param>
        /// <returns>The padded time. 600 becomes 0600.</returns>
        private string PadTime(string time, int size)
        {
            while (time.Length < size)
            {
                time = "0" + time;
            }

            return time;
        }

        /// <summary>
        /// Write an Excel spreadsheet with the data results from the query.
        /// </summary>
        /// <param name="results">The table of retrieved results.</param>
        /// <param name="username">The username, to create a customised Excel file.</param>
        /*public void SendResultsTableToExcel(System.Data.DataTable results, string username)
        {
            if (results != null && username != "")
            {
                Application excelStatistics = new Application();

                _Workbook workbook = (_Workbook)(excelStatistics.Workbooks.Add(Type.Missing));
                _Worksheet worksheet = (_Worksheet)workbook.ActiveSheet;
                object missing = System.Reflection.Missing.Value;

                worksheet.Cells[1, 1] = "Query Results";
                worksheet.Cells[3, 1] = "ID";
                worksheet.Cells[3, 2] = "Date Time";
                worksheet.Cells[3, 3] = "State";
                worksheet.Cells[3, 4] = "County";
                worksheet.Cells[3, 5] = "Event Type";
                worksheet.Cells[3, 6] = "Event Description";

                int startRow = 4;

                foreach (DataRow row in results.Rows)
                {
                    worksheet.Cells[startRow, 1] = row[1].ToString();
                    worksheet.Cells[startRow, 2] = row[10].ToString() + GetMonth(int.Parse(row[9].ToString())) + row[8].ToString();
                    worksheet.Cells[startRow, 3] = row[3].ToString();
                    worksheet.Cells[startRow, 4] = row[5].ToString();
                    worksheet.Cells[startRow, 5] = row[17].ToString();
                    worksheet.Cells[startRow, 6] = row[47].ToString();

                    startRow++;
                }

                excelStatistics.UserControl = true;
                workbook.SaveAs(HttpContext.Current.Server.MapPath("../query-results/results-" + username + ".xls"), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing, missing);
                workbook.Close(false, false, Type.Missing);
            }
        }*/

        /// <summary>
        /// Write an Excel spreadsheet with the statistics calculated from the retrieved data.
        /// </summary>
        /// <param name="statistics">The statistics set.</param>
        /// <param name="username">The username, to create a customised Excel file.</param>
        /*public void SendStatisticsToExcel(Statistics statistics, string username)
        {
            if (statistics != null && username != "")
            {
                Application excelStatistics = new Application();
                //excelStatistics.Visible = true;

                _Workbook workbook = (_Workbook)(excelStatistics.Workbooks.Add(Type.Missing));
                _Worksheet worksheet = (_Worksheet)workbook.ActiveSheet;
                object missing = System.Reflection.Missing.Value;

                worksheet.Cells[1, 1] = "Data Statistics";

                worksheet.Cells[2, 1] = "Number OfEvents Retrieved: ";
                worksheet.Cells[2, 2] = statistics.NumberOfEvents;
                worksheet.Cells[3, 1] = "Day With Most Events: ";
                worksheet.Cells[3, 2] = statistics.DayWithMostEvents;

                worksheet.Cells[5, 1] = "Tornado Statistics";
                worksheet.Cells[6, 1] = "Total Tornado Events: ";
                worksheet.Cells[6, 2] = statistics.NumberOfTornadoEvents;
                worksheet.Cells[7, 1] = "Strongest Tornado: ";
                worksheet.Cells[7, 2] = statistics.StrongestTornado;
                worksheet.Cells[8, 1] = "Widest Tornado: ";
                worksheet.Cells[8, 2] = statistics.WidestTornado;
                worksheet.Cells[9, 1] = "Longest Tornado: ";
                worksheet.Cells[9, 2] = statistics.LongestTornado;
                worksheet.Cells[10, 1] = "Tornado With Most Injuries: ";
                worksheet.Cells[10, 2] = statistics.TornadoWithMostInjuries;
                worksheet.Cells[11, 1] = "Tornado With Most Deaths: ";
                worksheet.Cells[11, 2] = statistics.TornadoWithMostDeaths;
                worksheet.Cells[12, 1] = "Tornado With Most Crop Damage: ";
                worksheet.Cells[12, 2] = "$ " + statistics.TornadoWithMostCropDamage;
                worksheet.Cells[13, 1] = "Tornado With Most Property Damage: ";
                worksheet.Cells[13, 2] = statistics.TornadoWithMostPropertyDamage;

                worksheet.Cells[15, 1] = "Property Damage Statistcs";
                worksheet.Cells[16, 1] = "Highest Property Damage Event: ";
                worksheet.Cells[16, 2] = statistics.HighestPropertyDamageEvent;
                worksheet.Cells[17, 1] = "Day With Maximum Number Of Property Damages: ";
                worksheet.Cells[17, 2] = statistics.DayWithMostPropertyDamage;

                worksheet.Cells[19, 1] = "Crop Damage Statistcs";
                worksheet.Cells[20, 1] = "Highest Crop Damage Event: ";
                worksheet.Cells[20, 2] = statistics.HighestCropDamageEvent;
                worksheet.Cells[21, 1] = "Day With Maximum Number Of Crop Damages: ";
                worksheet.Cells[21, 2] = statistics.DayWithMostCropDamage;

                worksheet.Cells[23, 1] = "Death Statistics";
                worksheet.Cells[24, 1] = "Event With Most Deaths: ";
                worksheet.Cells[24, 2] = statistics.EventWithMostDeaths;
                worksheet.Cells[25, 1] = "Day With Most Deaths: ";
                worksheet.Cells[25, 2] = statistics.DayWithMostDeaths;

                worksheet.Cells[27, 1] = "Sum Of Events Per State";

                worksheet.Cells[28, 1] = "Alabama";
                worksheet.Cells[29, 1] = "Alaska";
                worksheet.Cells[30, 1] = "Arizona";
                worksheet.Cells[31, 1] = "Arkansas";
                worksheet.Cells[32, 1] = "California";
                worksheet.Cells[33, 1] = "Colorado";
                worksheet.Cells[34, 1] = "Connecticut";
                worksheet.Cells[35, 1] = "Delaware";
                worksheet.Cells[36, 1] = "District Of Columbia";
                worksheet.Cells[37, 1] = "Florida";
                worksheet.Cells[38, 1] = "Georgia";
                worksheet.Cells[39, 1] = "Hawaii";
                worksheet.Cells[40, 1] = "Idaho";
                worksheet.Cells[41, 1] = "Illinois";
                worksheet.Cells[42, 1] = "Indiana";
                worksheet.Cells[43, 1] = "Iowa";
                worksheet.Cells[44, 1] = "Kansas";
                worksheet.Cells[45, 1] = "Kentucky";
                worksheet.Cells[46, 1] = "Louisiana";
                worksheet.Cells[47, 1] = "Maine";
                worksheet.Cells[48, 1] = "Maryland";
                worksheet.Cells[49, 1] = "Massachusetts";
                worksheet.Cells[50, 1] = "Michigan";
                worksheet.Cells[51, 1] = "Minnesota";
                worksheet.Cells[52, 1] = "Mississippi";
                worksheet.Cells[53, 1] = "Missouri";
                worksheet.Cells[54, 1] = "Montana";
                worksheet.Cells[55, 1] = "Nebraska";
                worksheet.Cells[56, 1] = "Nevada";
                worksheet.Cells[57, 1] = "New Hampshire";
                worksheet.Cells[58, 1] = "New Jersey";
                worksheet.Cells[59, 1] = "New Mexico";
                worksheet.Cells[60, 1] = "New York";
                worksheet.Cells[61, 1] = "North Carolina";
                worksheet.Cells[62, 1] = "North Dakota";
                worksheet.Cells[63, 1] = "Ohio";
                worksheet.Cells[64, 1] = "Oklahoma";
                worksheet.Cells[65, 1] = "Oregon";
                worksheet.Cells[66, 1] = "Pennsylvania";
                worksheet.Cells[67, 1] = "Rhode Island";
                worksheet.Cells[68, 1] = "South Carolina";
                worksheet.Cells[69, 1] = "South Dakota";
                worksheet.Cells[70, 1] = "Tennessee";
                worksheet.Cells[71, 1] = "Texas";
                worksheet.Cells[72, 1] = "Utah";
                worksheet.Cells[73, 1] = "Vermont";
                worksheet.Cells[74, 1] = "Virginia";
                worksheet.Cells[75, 1] = "Washington";
                worksheet.Cells[76, 1] = "West Virginia";
                worksheet.Cells[77, 1] = "Wisconsin";
                worksheet.Cells[78, 1] = "Wyoming";
                worksheet.Cells[79, 1] = "Puerto Rico";

                worksheet.Cells[28, 2] = statistics.SumOfEventsPerState.Alabama;
                worksheet.Cells[29, 2] = statistics.SumOfEventsPerState.Alaska;
                worksheet.Cells[30, 2] = statistics.SumOfEventsPerState.Arizona;
                worksheet.Cells[31, 2] = statistics.SumOfEventsPerState.Arkansas;
                worksheet.Cells[32, 2] = statistics.SumOfEventsPerState.California;
                worksheet.Cells[33, 2] = statistics.SumOfEventsPerState.Colorado;
                worksheet.Cells[34, 2] = statistics.SumOfEventsPerState.Connecticut;
                worksheet.Cells[35, 2] = statistics.SumOfEventsPerState.Delaware;
                worksheet.Cells[36, 2] = statistics.SumOfEventsPerState.DistrictOfColumbia;
                worksheet.Cells[37, 2] = statistics.SumOfEventsPerState.Florida;
                worksheet.Cells[38, 2] = statistics.SumOfEventsPerState.Georgia;
                worksheet.Cells[39, 2] = statistics.SumOfEventsPerState.Hawaii;
                worksheet.Cells[40, 2] = statistics.SumOfEventsPerState.Idaho;
                worksheet.Cells[41, 2] = statistics.SumOfEventsPerState.Illinois;
                worksheet.Cells[42, 2] = statistics.SumOfEventsPerState.Indiana;
                worksheet.Cells[43, 2] = statistics.SumOfEventsPerState.Iowa;
                worksheet.Cells[44, 2] = statistics.SumOfEventsPerState.Kansas;
                worksheet.Cells[45, 2] = statistics.SumOfEventsPerState.Kentucky;
                worksheet.Cells[46, 2] = statistics.SumOfEventsPerState.Louisiana;
                worksheet.Cells[47, 2] = statistics.SumOfEventsPerState.Maine;
                worksheet.Cells[48, 2] = statistics.SumOfEventsPerState.Maryland;
                worksheet.Cells[49, 2] = statistics.SumOfEventsPerState.Massachusetts;
                worksheet.Cells[50, 2] = statistics.SumOfEventsPerState.Michigan;
                worksheet.Cells[51, 2] = statistics.SumOfEventsPerState.Minnesota;
                worksheet.Cells[52, 2] = statistics.SumOfEventsPerState.Mississippi;
                worksheet.Cells[53, 2] = statistics.SumOfEventsPerState.Missouri;
                worksheet.Cells[54, 2] = statistics.SumOfEventsPerState.Montana;
                worksheet.Cells[55, 2] = statistics.SumOfEventsPerState.Nebraska;
                worksheet.Cells[56, 2] = statistics.SumOfEventsPerState.Nevada;
                worksheet.Cells[57, 2] = statistics.SumOfEventsPerState.NewHampshire;
                worksheet.Cells[58, 2] = statistics.SumOfEventsPerState.NewJersey;
                worksheet.Cells[59, 2] = statistics.SumOfEventsPerState.NewMexico;
                worksheet.Cells[60, 2] = statistics.SumOfEventsPerState.NewYork;
                worksheet.Cells[61, 2] = statistics.SumOfEventsPerState.NorthCarolina;
                worksheet.Cells[62, 2] = statistics.SumOfEventsPerState.NorthDakota;
                worksheet.Cells[63, 2] = statistics.SumOfEventsPerState.Ohio;
                worksheet.Cells[64, 2] = statistics.SumOfEventsPerState.Oklahoma;
                worksheet.Cells[65, 2] = statistics.SumOfEventsPerState.Oregon;
                worksheet.Cells[66, 2] = statistics.SumOfEventsPerState.Pennsylvania;
                worksheet.Cells[67, 2] = statistics.SumOfEventsPerState.RhodeIsland;
                worksheet.Cells[68, 2] = statistics.SumOfEventsPerState.SouthCarolina;
                worksheet.Cells[69, 2] = statistics.SumOfEventsPerState.SouthDakota;
                worksheet.Cells[70, 2] = statistics.SumOfEventsPerState.Tennessee;
                worksheet.Cells[71, 2] = statistics.SumOfEventsPerState.Texas;
                worksheet.Cells[72, 2] = statistics.SumOfEventsPerState.Utah;
                worksheet.Cells[73, 2] = statistics.SumOfEventsPerState.Vermont;
                worksheet.Cells[74, 2] = statistics.SumOfEventsPerState.Virginia;
                worksheet.Cells[75, 2] = statistics.SumOfEventsPerState.Washington;
                worksheet.Cells[76, 2] = statistics.SumOfEventsPerState.WestVirginia;
                worksheet.Cells[77, 2] = statistics.SumOfEventsPerState.Wisconsin;
                worksheet.Cells[78, 2] = statistics.SumOfEventsPerState.Wyoming;
                worksheet.Cells[79, 2] = statistics.SumOfEventsPerState.PuertoRico;
                excelStatistics.UserControl = true;

                workbook.SaveAs(HttpContext.Current.Server.MapPath("../query-results/statistics-" + username + ".xls"), Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missing, missing, missing, missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, missing, missing, missing, missing, missing);
                workbook.Close(false, false, Type.Missing);
            }
        }*/
    }
}