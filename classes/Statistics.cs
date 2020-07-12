using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using artefact.dictionaries;
using System.Data;
using System.Collections;

namespace artefact.classes
{
    public class Statistics
    {
        private int numberOfEvents;
        private DateTime dayWithMostEvents;
        private int numberOfTornadoEvents;
        private string strongestTornado;
        private int widestTornado;
        private double longestTornado;
        private int tornadoWithMostInjuries;
        private int tornadoWithMostDeaths;
        private double tornadoWithMostCropDamage;
        private double tornadoWithMostPropertyDamage;
        private string highestPropertyDamageEvent;
        private DateTime dayWithMostPropertyDamage;
        private string highestCropDamageEvent;
        private DateTime dayWithMostCropDamage;
        private int eventWithMostDeaths;
        private DateTime dayWithMostDeaths;
        private int eventWithMostInjuries;
        private DateTime dayWithMostInjuries;
        private string stateWithMostEvents;
        private EventsPerState sumOfEventsPerState;
        private System.Data.DataTable results;

        /// <summary>
        /// Number of Events Property
        /// </summary>
        public int NumberOfEvents
        {
            get
            {
                return this.numberOfEvents;
            }
            set
            {
                this.numberOfEvents = value;
            }
        }

        /// <summary>
        /// Day With Most Events Property
        /// </summary>
        public DateTime DayWithMostEvents
        {
            get
            {
                return this.dayWithMostEvents;
            }
            set
            {
                this.dayWithMostEvents = value;
            }
        }

        /// <summary>
        /// Number of Tornado Events Property
        /// </summary>
        public int NumberOfTornadoEvents
        {
            get
            {
                return this.numberOfTornadoEvents;
            }
            set
            {
                this.numberOfTornadoEvents = value;
            }
        }

        /// <summary>
        /// Strongest Tornado Property
        /// </summary>
        public string StrongestTornado
        {
            get
            {
                return this.strongestTornado;
            }
            set
            {
                this.strongestTornado = value;
            }
        }

        /// <summary>
        /// Widest Tornado Property
        /// </summary>
        public int WidestTornado
        {
            get
            {
                return this.widestTornado;
            }
            set
            {
                this.widestTornado = value;
            }
        }

        /// <summary>
        /// Longest Tornado Property
        /// </summary>
        public double LongestTornado
        {
            get
            {
                return this.longestTornado;
            }
            set
            {
                this.longestTornado = value;
            }
        }

        /// <summary>
        /// Tornado With Most Injuries Property
        /// </summary>
        public int TornadoWithMostInjuries
        {
            get
            {
                return this.tornadoWithMostInjuries;
            }
            set
            {
                this.tornadoWithMostInjuries = value;
            }
        }

        /// <summary>
        /// Tornado With Most Deaths Property
        /// </summary>
        public int TornadoWithMostDeaths
        {
            get
            {
                return this.tornadoWithMostDeaths;
            }
            set
            {
                this.tornadoWithMostDeaths = value;
            }
        }

        /// <summary>
        /// Tornado With Most Crop Damage Property
        /// </summary>
        public double TornadoWithMostCropDamage
        {
            get
            {
                return this.tornadoWithMostCropDamage;
            }
            set
            {
                this.tornadoWithMostCropDamage = value;
            }
        }

        /// <summary>
        /// Tornado With Most Property Damage Property
        /// </summary>
        public double TornadoWithMostPropertyDamage
        {
            get
            {
                return this.tornadoWithMostPropertyDamage;
            }
            set
            {
                this.tornadoWithMostPropertyDamage = value;
            }
        }

        /// <summary>
        /// Highest Property Damage Event Property
        /// </summary>
        public string HighestPropertyDamageEvent
        {
            get
            {
                return this.highestPropertyDamageEvent;
            }
            set
            {
                this.highestPropertyDamageEvent = value;
            }
        }

        /// <summary>
        /// Day With Most Property Damage Property
        /// </summary>
        public DateTime DayWithMostPropertyDamage
        {
            get
            {
                return this.dayWithMostPropertyDamage;
            }
            set
            {
                this.dayWithMostPropertyDamage = value;
            }
        }

        /// <summary>
        /// Highest Crop Damage Event Property
        /// </summary>
        public string HighestCropDamageEvent
        {
            get
            {
                return this.highestCropDamageEvent;
            }
            set
            {
                this.highestCropDamageEvent = value;
            }
        }

        /// <summary>
        /// Day With most Crop Damage Property
        /// </summary>
        public DateTime DayWithMostCropDamage
        {
            get
            {
                return this.dayWithMostCropDamage;
            }
            set
            {
                this.dayWithMostCropDamage = value;
            }
        }

        /// <summary>
        /// Event With Most Deaths Property
        /// </summary>
        public int EventWithMostDeaths
        {
            get
            {
                return this.eventWithMostDeaths;
            }
            set
            {
                this.eventWithMostDeaths = value;
            }
        }

        /// <summary>
        /// Day With Most Deaths Property
        /// </summary>
        public DateTime DayWithMostDeaths
        {
            get
            {
                return this.dayWithMostDeaths;
            }
            set
            {
                this.dayWithMostDeaths = value;
            }
        }

        /// <summary>
        /// Event With Most Injuries Property
        /// </summary>
        public int EventWithMostInjuries
        {
            get
            {
                return this.eventWithMostInjuries;
            }
            set
            {
                this.eventWithMostInjuries = value;
            }
        }

        /// <summary>
        /// Day With Most Injuries Property
        /// </summary>
        public DateTime DayWithMostInjuries
        {
            get
            {
                return this.dayWithMostInjuries;
            }
            set
            {
                this.dayWithMostInjuries = value;
            }
        }

        /// <summary>
        /// State With Most Events Property
        /// </summary>
        public string StateWithMostEvents
        {
            get
            {
                return this.stateWithMostEvents;
            }
            set
            {
                this.stateWithMostEvents = value;
            }
        }

        /// <summary>
        /// Sum Of Events Per State Property
        /// </summary>
        public EventsPerState SumOfEventsPerState
        {
            get
            {
                return this.sumOfEventsPerState;
            }
            set
            {
                this.sumOfEventsPerState = value;
            }
        }

        /// <summary>
        /// Statistics Constructor
        /// </summary>
        /// <param name="data">The table of data to construct this statistics set for.</param>
        public Statistics(System.Data.DataTable data)
        {
            results = data;
            sumOfEventsPerState = new EventsPerState();
        }

        /// <summary>
        /// Calculate all statistics for one data set.
        /// </summary>
        public void CalculateStatistics()
        {
            CalculateTotalNumberOfEvents();
            GetDayWithMostEvents();
            GetCountOfTornadoEvents();
            GetStrongestTornado();
            GetLongestTornado();
            GetWidestTornado();
            GetTornadoWithMostInjuries();
            GetTornadoWithMostDeaths();
            GetTornadoWithMostCropDamage();
            GetTornadoWithMostPropertyDamage();
            GetHighestCropDamageEvent();
            GetHighestPropertyDamageEvent();
            GetDayWithMostPropertyDamageEvents();
            GetDayWithMostCropDamageEvents();
            GetEventWithMostDeaths();
            GetDayWithMostDeaths();
            GetEventWithMostInjuries();
            GetDayWithMostInjuries();
            //GetStateWithMostEvents();
            GetCountOfEventsPerState();
        }

        /// <summary>
        /// Calculate the total number of events in this query.
        /// </summary>
        public void CalculateTotalNumberOfEvents()
        {
            if (results != null)
            {
                this.NumberOfEvents = results.Rows.Count;
            }
            else
            {
                throw new Exception("Error 8001: Data table is null.");
            }
        }

        /// <summary>
        /// Calculate the day of the year with most events.
        /// </summary>
        public void GetDayWithMostEvents()
        {
            if (results != null)
            {
                List<DateTime> dates = new List<DateTime>();
                foreach (DataRow row in results.Rows)
                {
                    dates.Add(new DateTime(int.Parse(row[8].ToString()),int.Parse(row[9].ToString()), int.Parse(row[10].ToString())));
                }

                if (dates.Count != 0)
                {
                    dates.Sort();
                    this.DayWithMostEvents = dates.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
                }
                else
                {
                    this.dayWithMostEvents = new DateTime();
                }
                
            }
            else
            {
                throw new Exception("Error 8002: Data table is null.");
            }
        }

        /// <summary>
        /// Get the number of tornado events in this query.
        /// </summary>
        /// <returns>An integer representation of the number of tornado events in this query.</returns>
        public void GetCountOfTornadoEvents()
        {
            if (results != null)
            {
                int countOfTornadoEvents = 0;

                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        countOfTornadoEvents++;
                    }
                }

                this.NumberOfTornadoEvents = countOfTornadoEvents;
            }
            else
            {
                throw new Exception("Error 8003: Data talbe is null.");
            }
        }

        /// <summary>
        /// Get the strongest tornado in the query results.
        /// </summary>
        public void GetStrongestTornado()
        {
            if (results != null)
            {
                List<string> tornadoIntensities = new List<string>();

                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        string tornadoIntensity = row[39].ToString();
                        tornadoIntensity = ConvertEnhancedFujitaScaleToFujitaScale(tornadoIntensity);

                        tornadoIntensities.Add(tornadoIntensity);
                    }
                }

                if (tornadoIntensities.Count > 1)
                {
                    tornadoIntensities.Sort();
                    string strongestTornado = tornadoIntensities[tornadoIntensities.Count - 1];

                    this.StrongestTornado = strongestTornado + "/EF" + strongestTornado[strongestTornado.Length - 1];
                }
                else
                {
                    this.StrongestTornado = "N/A";
                }
            }
            else
            {
                throw new Exception("Error 8004: Data table was null.");
            }
        }

        /// <summary>
        /// Take an Enhanced Fujita Scale value and convert it to Fujita, if it has a leading 'E' character. EF2 --> F2.
        /// </summary>
        /// <param name="tornadoIntensity">The Enhanced Fujita Scale value.</param>
        /// <returns>The Fujita Scale value.</returns>
        private string ConvertEnhancedFujitaScaleToFujitaScale(string tornadoIntensity)
        {
            if (tornadoIntensity.Length == 3)
            {
                tornadoIntensity = tornadoIntensity[1].ToString() + tornadoIntensity[2].ToString();
            }

            return tornadoIntensity;
        }

        /// <summary>
        /// Get the longest tornado track in the resulting query.
        /// </summary>
        public void GetLongestTornado()
        {
            double maxLength = 0.0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        double tornadoTrackLength = double.Parse(row[40].ToString());

                        if (tornadoTrackLength > maxLength)
                        {
                            maxLength = tornadoTrackLength;
                        }
                    }
                }

                this.LongestTornado = maxLength;
            }
            else
            {
                throw new Exception("Error 8005: Data table was null.");
            }
        }

        /// <summary>
        /// Gets the widest tornado in the current query.
        /// </summary>
        public void GetWidestTornado()
        {
            int maxWidth = 0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        int tornadoWidth = int.Parse(Math.Round(double.Parse(row[41].ToString())).ToString());
                        if (tornadoWidth > maxWidth)
                        {
                            maxWidth = tornadoWidth;
                        }
                    }
                }

                this.WidestTornado = maxWidth;
            }
            else
            {
                throw new Exception("Error 8006: Data table was null.");
            }
        }

        /// <summary>
        /// Get the maximum number of injuries from a tornado event.
        /// </summary>
        public void GetTornadoWithMostInjuries()
        {
            int maxInjuries = 0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        int injuries = int.Parse(row[29].ToString()) + int.Parse(row[30].ToString());

                        if (injuries > maxInjuries)
                        {
                            maxInjuries = injuries;
                        }
                    }
                }

                this.TornadoWithMostInjuries = maxInjuries;
            }
            else
            {
                throw new Exception("Error 8007: Data table was null.");
            }
        }

        /// <summary>
        /// Get the maximum number of deaths from one tornado event.
        /// </summary>
        public void GetTornadoWithMostDeaths()
        {
            int maxDeaths = 0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        int injuries = int.Parse(row[31].ToString()) + int.Parse(row[32].ToString());

                        if (injuries > maxDeaths)
                        {
                            maxDeaths = injuries;
                        }
                    }
                }

                this.TornadoWithMostDeaths = maxDeaths;
            }
            else
            {
                throw new Exception("Error 8007: Data table was null.");
            }
        }

        /// <summary>
        /// Get the highest value crop damage from one tornado event.
        /// </summary>
        public void GetTornadoWithMostCropDamage()
        {
            double maxCropDamage = 0;
            string cropDamageValue = "";
            double cropDamage = 0.0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        cropDamageValue = row[33].ToString();
                        cropDamage = ConvertValueStringToDouble(cropDamageValue);

                        if (cropDamage > maxCropDamage)
                        {
                            maxCropDamage = cropDamage;
                        }
                    }
                }

                this.TornadoWithMostCropDamage = maxCropDamage;
            }
            else
            {
                throw new Exception("Error 8008: Data table was null.");
            }
        }

        /// <summary>
        /// Get the highest value crop damage from one tornado event.
        /// </summary>
        public void GetTornadoWithMostPropertyDamage()
        {
            double maxPropertyDamage = 0;
            string propertyDamageValue = "";
            double propertryDamage = 0.0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    if (row[17].ToString().ToLower() == "tornado")
                    {
                        propertyDamageValue = row[34].ToString();
                        propertryDamage = ConvertValueStringToDouble(propertyDamageValue);

                        if (propertryDamage > maxPropertyDamage)
                        {
                            maxPropertyDamage = propertryDamage;
                        }
                    }
                }

                this.TornadoWithMostPropertyDamage = maxPropertyDamage;
            }
            else
            {
                throw new Exception("Error 8009: Data table was null.");
            }
        }

        /// <summary>
        /// Convert a string representation of a monetary value in K, M or B to a double.
        /// </summary>
        /// <param name="value">The string representation of the damage value, e.g. 250K, 1.5M or 7B</param>
        private double ConvertValueStringToDouble(string value)
        {
            if (value != "0" && value != "")
            {
                string valueFigure = "";
                string valueUnits = "";
                double finalValue = 0.0;

                for (int i = 0; i < value.Length - 1; i++)
                {
                    valueFigure += value[i];
                }

                finalValue = double.Parse(valueFigure);

                valueUnits = value[value.Length - 1].ToString();

                if (valueUnits == "K")
                {
                    finalValue *= 1000;
                }
                else if (valueUnits == "M")
                {
                    finalValue *= 1000000;
                }
                else if (valueUnits == "B")
                {
                    finalValue *= 1000000000;
                }
                else
                {
                    throw new Exception("Error 8010: Damage Value was not in a recognised format.");
                }

                return finalValue;
            }
            else
            {
                return 0.0;
            }
        }

        /// <summary>
        /// Get the event ID of the most damaging severe weather event selected for crops.
        /// </summary>
        public void GetHighestCropDamageEvent()
        {
            if (results != null)
            {
                double cropDamage = 0.0;
                double maxCropDamage = 0.0;
                string eventID = "";

                foreach (DataRow row in results.Rows)
                {
                    if (row[33].ToString() == "K")
                    {
                        int a = 1;
                        a++;
                    }
                    cropDamage = ConvertValueStringToDouble(row[33].ToString());

                    if (cropDamage > maxCropDamage)
                    {
                        maxCropDamage = cropDamage;
                        eventID = row[1].ToString();
                    }
                }

                this.HighestCropDamageEvent = eventID;
            }
            else
            {
                throw new Exception("Error 8011: Data table was null.");
            }
        }

        /// <summary>
        /// Get the event ID of the most damaging severe weather event selected for properties.
        /// </summary>
        public void GetHighestPropertyDamageEvent()
        {
            if (results != null)
            {
                double propertyDamage = 0.0;
                double maxPropertyDamage = 0.0;
                string eventID = "";

                foreach (DataRow row in results.Rows)
                {
                    propertyDamage = ConvertValueStringToDouble(row[34].ToString());

                    if (propertyDamage > maxPropertyDamage)
                    {
                        maxPropertyDamage = propertyDamage;
                        eventID = row[1].ToString();
                    }
                }

                this.HighestPropertyDamageEvent = eventID;
            }
            else
            {
                throw new Exception("Error 8011: Data table was null.");
            }
        }

        /// <summary>
        /// Get the first instance in the year of a day with the maximum number of property damage events.
        /// </summary>
        public void GetDayWithMostPropertyDamageEvents()
        {
            if (results != null)
            {
                List<DateTime> dates = new List<DateTime>();
                foreach (DataRow row in results.Rows)
                {
                    if (ConvertValueStringToDouble(row[33].ToString()) != 0.0)
                    {
                        dates.Add(new DateTime(int.Parse(row[8].ToString()), int.Parse(row[9].ToString()), int.Parse(row[10].ToString())));
                    }
                }

                if (dates.Count != 0)
                {
                    dates.Sort();
                    this.DayWithMostPropertyDamage = dates.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
                }
                else
                {
                    this.DayWithMostPropertyDamage = new DateTime();
                }
                
            }
            else
            {
                throw new Exception("Error 8012: Data table is null.");
            }
        }

        /// <summary>
        /// Get the first instance in the year of a day with the maximum number of crop damage events.
        /// </summary>
        public void GetDayWithMostCropDamageEvents()
        {
            if (results != null)
            {
                List<DateTime> dates = new List<DateTime>();
                foreach (DataRow row in results.Rows)
                {
                    if (ConvertValueStringToDouble(row[34].ToString()) != 0.0)
                    {
                        dates.Add(new DateTime(int.Parse(row[8].ToString()), int.Parse(row[9].ToString()), int.Parse(row[10].ToString())));
                    }

                }

                if (dates.Count != 0)
                {
                    dates.Sort();
                    this.DayWithMostCropDamage = dates.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
                }
                else
                {
                    this.DayWithMostCropDamage = new DateTime();
                }
            }
            else
            {
                throw new Exception("Error 8012: Data table is null.");
            }
        }

        /// <summary>
        /// Get the most deaths from any one queried severe weather event.
        /// </summary>
        public void GetEventWithMostDeaths()
        {
            int maxDeaths = 0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    int deaths = int.Parse(row[31].ToString()) + int.Parse(row[32].ToString());

                    if (deaths > maxDeaths)
                    {
                        maxDeaths = deaths;
                    }
                }

                this.EventWithMostDeaths = maxDeaths;
            }
            else
            {
                throw new Exception("Error 8013: Data table is null.");
            }
        }

        /// <summary>
        /// Get the date that the most deaths, from any one queried severe weather event, occurred.
        /// </summary>
        public void GetDayWithMostDeaths()
        {
            // As GetEventWithMostDeaths, but kept separate so statistics could be updated individually.
            int maxDeaths = 0;
            DateTime mostDeaths = new DateTime();

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    int deaths = int.Parse(row[31].ToString()) + int.Parse(row[32].ToString());

                    if (deaths > maxDeaths)
                    {
                        maxDeaths = deaths;
                        mostDeaths = new DateTime(int.Parse(row[8].ToString()),int.Parse(row[9].ToString()), int.Parse(row[10].ToString()));
                    }
                }

                this.DayWithMostDeaths = mostDeaths;
            }
            else
            {
                throw new Exception("Error 8014: Data table is null.");
            }
        }

        /// <summary>
        /// Get the most deaths from any one queried severe weather event.
        /// </summary>
        public void GetEventWithMostInjuries()
        {
            int maxInjuries = 0;

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    int injuries = int.Parse(row[29].ToString()) + int.Parse(row[30].ToString());

                    if (injuries > maxInjuries)
                    {
                        maxInjuries = injuries;
                    }
                }

                this.EventWithMostInjuries = maxInjuries;
            }
            else
            {
                throw new Exception("Error 8015: Data table is null.");
            }
        }

        /// <summary>
        /// Get the date that the most deaths, from any one queried severe weather event, occurred.
        /// </summary>
        public void GetDayWithMostInjuries()
        {
            // As GetEventWithMostDeaths, but kept separate so statistics could be updated individually.
            int maxInjuries = 0;
            DateTime mostInjuries = new DateTime();

            if (results != null)
            {
                foreach (DataRow row in results.Rows)
                {
                    int deaths = int.Parse(row[29].ToString()) + int.Parse(row[30].ToString());

                    if (deaths > maxInjuries)
                    {
                        maxInjuries = deaths;
                        mostInjuries = new DateTime(int.Parse(row[8].ToString()), int.Parse(row[9].ToString()), int.Parse(row[10].ToString()));
                    }
                }

                this.DayWithMostInjuries = mostInjuries;
            }
            else
            {
                throw new Exception("Error 8016: Data table is null.");
            }
        }

        /// <summary>
        /// Get the state with the most events
        /// </summary>
        /*public void GetStateWithMostEvents()
        {
            if (results != null)
            {
                List<string> states = new List<string>();

                foreach (DataRow row in results.Rows)
                {
                    states.Add(row[3].ToString());
                }

                if (states.Count != 0)
                {
                    this.StateWithMostEvents = states.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
                }
                else
                {
                    this.StateWithMostEvents = "N/A";
                }
            }
            else
            {
                throw new Exception("Error 8017: Data table is null.");
            }
        }*/

        /// <summary>
        /// Get the sum of events for each state.
        /// </summary>
        public void GetCountOfEventsPerState()
        {
            if (results != null)
            {
                List<string> states = new List<string>();

                foreach (DataRow row in results.Rows)
                {
                    states.Add(row[3].ToString());
                }

                EventsPerState eventsPerState = new EventsPerState();

                if (states.Count != 0)
                {
                    eventsPerState.Alabama = states.Where(x => x.ToString().ToLower().Equals("alabama")).Select(x => x).Count();
                    eventsPerState.Alaska = states.Where(x => x.ToString().ToLower().Equals("alaska")).Select(x => x).Count();
                    eventsPerState.Arizona = states.Where(x => x.ToString().ToLower().Equals("arizona")).Select(x => x).Count();
                    eventsPerState.Arkansas = states.Where(x => x.ToString().ToLower().Equals("arkansas")).Select(x => x).Count();
                    eventsPerState.California = states.Where(x => x.ToString().ToLower().Equals("california")).Select(x => x).Count();
                    eventsPerState.Colorado = states.Where(x => x.ToString().ToLower().Equals("colorado")).Select(x => x).Count();
                    eventsPerState.Connecticut = states.Where(x => x.ToString().ToLower().Equals("connecticut")).Select(x => x).Count();
                    eventsPerState.Delaware = states.Where(x => x.ToString().ToLower().Equals("delaware")).Select(x => x).Count();
                    eventsPerState.DistrictOfColumbia = states.Where(x => x.ToString().ToLower().Equals("district of columbia")).Select(x => x).Count();
                    eventsPerState.Florida = states.Where(x => x.ToString().ToLower().Equals("florida")).Select(x => x).Count();
                    eventsPerState.Georgia = states.Where(x => x.ToString().ToLower().Equals("georgia")).Select(x => x).Count();
                    eventsPerState.Hawaii = states.Where(x => x.ToString().ToLower().Equals("hawaii")).Select(x => x).Count();
                    eventsPerState.Idaho = states.Where(x => x.ToString().ToLower().Equals("idaho")).Select(x => x).Count();
                    eventsPerState.Illinois = states.Where(x => x.ToString().ToLower().Equals("illinois")).Select(x => x).Count();
                    eventsPerState.Indiana = states.Where(x => x.ToString().ToLower().Equals("indiana")).Select(x => x).Count();
                    eventsPerState.Iowa = states.Where(x => x.ToString().ToLower().Equals("iowa")).Select(x => x).Count();
                    eventsPerState.Kansas = states.Where(x => x.ToString().ToLower().Equals("kansas")).Select(x => x).Count();
                    eventsPerState.Kentucky = states.Where(x => x.ToString().ToLower().Equals("kentucky")).Select(x => x).Count();
                    eventsPerState.Louisiana = states.Where(x => x.ToString().ToLower().Equals("louisiana")).Select(x => x).Count();
                    eventsPerState.Maine = states.Where(x => x.ToString().ToLower().Equals("maine")).Select(x => x).Count();
                    eventsPerState.Maryland = states.Where(x => x.ToString().ToLower().Equals("maryland")).Select(x => x).Count();
                    eventsPerState.Massachusetts = states.Where(x => x.ToString().ToLower().Equals("massachusetts")).Select(x => x).Count();
                    eventsPerState.Michigan = states.Where(x => x.ToString().ToLower().Equals("michigan")).Select(x => x).Count();
                    eventsPerState.Minnesota = states.Where(x => x.ToString().ToLower().Equals("minnesota")).Select(x => x).Count();
                    eventsPerState.Mississippi = states.Where(x => x.ToString().ToLower().Equals("mississippi")).Select(x => x).Count();
                    eventsPerState.Missouri = states.Where(x => x.ToString().ToLower().Equals("missouri")).Select(x => x).Count();
                    eventsPerState.Montana = states.Where(x => x.ToString().ToLower().Equals("montana")).Select(x => x).Count();
                    eventsPerState.Nebraska = states.Where(x => x.ToString().ToLower().Equals("nebraska")).Select(x => x).Count();
                    eventsPerState.Nevada = states.Where(x => x.ToString().ToLower().Equals("nevada")).Select(x => x).Count();
                    eventsPerState.NewHampshire = states.Where(x => x.ToString().ToLower().Equals("new hampshire")).Select(x => x).Count();
                    eventsPerState.NewJersey = states.Where(x => x.ToString().ToLower().Equals("new jersey")).Select(x => x).Count();
                    eventsPerState.NewMexico = states.Where(x => x.ToString().ToLower().Equals("new mexico")).Select(x => x).Count();
                    eventsPerState.NewYork = states.Where(x => x.ToString().ToLower().Equals("new york")).Select(x => x).Count();
                    eventsPerState.NorthCarolina = states.Where(x => x.ToString().ToLower().Equals("north carolina")).Select(x => x).Count();
                    eventsPerState.NorthDakota = states.Where(x => x.ToString().ToLower().Equals("north dakota")).Select(x => x).Count();
                    eventsPerState.Ohio = states.Where(x => x.ToString().ToLower().Equals("ohio")).Select(x => x).Count();
                    eventsPerState.Oklahoma = states.Where(x => x.ToString().ToLower().Equals("oklahoma")).Select(x => x).Count();
                    eventsPerState.Oregon = states.Where(x => x.ToString().ToLower().Equals("oregon")).Select(x => x).Count();
                    eventsPerState.Pennsylvania = states.Where(x => x.ToString().ToLower().Equals("pennsylvania")).Select(x => x).Count();
                    eventsPerState.RhodeIsland = states.Where(x => x.ToString().ToLower().Equals("rhode island")).Select(x => x).Count();
                    eventsPerState.SouthCarolina = states.Where(x => x.ToString().ToLower().Equals("south carolina")).Select(x => x).Count();
                    eventsPerState.SouthDakota = states.Where(x => x.ToString().ToLower().Equals("south dakota")).Select(x => x).Count();
                    eventsPerState.Tennessee = states.Where(x => x.ToString().ToLower().Equals("tennessee")).Select(x => x).Count();
                    eventsPerState.Texas = states.Where(x => x.ToString().ToLower().Equals("texas")).Select(x => x).Count();
                    eventsPerState.Utah = states.Where(x => x.ToString().ToLower().Equals("utah")).Select(x => x).Count();
                    eventsPerState.Vermont = states.Where(x => x.ToString().ToLower().Equals("vermont")).Select(x => x).Count();
                    eventsPerState.Virginia = states.Where(x => x.ToString().ToLower().Equals("virginia")).Select(x => x).Count();
                    eventsPerState.Washington = states.Where(x => x.ToString().ToLower().Equals("washington")).Select(x => x).Count();
                    eventsPerState.WestVirginia = states.Where(x => x.ToString().ToLower().Equals("west virginia")).Select(x => x).Count();
                    eventsPerState.Wisconsin = states.Where(x => x.ToString().ToLower().Equals("wisconsin")).Select(x => x).Count();
                    eventsPerState.Wyoming = states.Where(x => x.ToString().ToLower().Equals("wyoming")).Select(x => x).Count();
                    eventsPerState.PuertoRico = states.Where(x => x.ToString().ToLower().Equals("puerto rico")).Select(x => x).Count();

                    this.SumOfEventsPerState = eventsPerState;
                }
                else
                {
                    eventsPerState.Alabama = 0;
                    eventsPerState.Alaska = 0;
                    eventsPerState.Arizona = 0;
                    eventsPerState.Arkansas = 0;
                    eventsPerState.California = 0;
                    eventsPerState.Colorado = 0;
                    eventsPerState.Connecticut = 0;
                    eventsPerState.Delaware = 0;
                    eventsPerState.DistrictOfColumbia = 0;
                    eventsPerState.Florida = 0;
                    eventsPerState.Georgia = 0;
                    eventsPerState.Hawaii = 0;
                    eventsPerState.Idaho = 0;
                    eventsPerState.Illinois = 0;
                    eventsPerState.Indiana = 0;
                    eventsPerState.Iowa = 0;
                    eventsPerState.Kansas = 0;
                    eventsPerState.Kentucky = 0;
                    eventsPerState.Louisiana = 0;
                    eventsPerState.Maine = 0;
                    eventsPerState.Maryland = 0;
                    eventsPerState.Massachusetts = 0;
                    eventsPerState.Michigan = 0;
                    eventsPerState.Minnesota = 0;
                    eventsPerState.Mississippi = 0;
                    eventsPerState.Missouri = 0;
                    eventsPerState.Montana = 0;
                    eventsPerState.Nebraska = 0;
                    eventsPerState.Nevada = 0;
                    eventsPerState.NewHampshire = 0;
                    eventsPerState.NewJersey = 0;
                    eventsPerState.NewMexico = 0;
                    eventsPerState.NewYork = 0;
                    eventsPerState.NorthCarolina = 0;
                    eventsPerState.NorthDakota = 0;
                    eventsPerState.Ohio = 0;
                    eventsPerState.Oklahoma = 0;
                    eventsPerState.Oregon = 0;
                    eventsPerState.Pennsylvania = 0;
                    eventsPerState.RhodeIsland = 0;
                    eventsPerState.SouthCarolina = 0;
                    eventsPerState.SouthDakota = 0;
                    eventsPerState.Tennessee = 0;
                    eventsPerState.Texas = 0;
                    eventsPerState.Utah = 0;
                    eventsPerState.Vermont = 0;
                    eventsPerState.Virginia = 0;
                    eventsPerState.Washington = 0;
                    eventsPerState.WestVirginia = 0;
                    eventsPerState.Wisconsin = 0;
                    eventsPerState.Wyoming = 0;
                    eventsPerState.PuertoRico = 0;
                }
            }
            else
            {
                throw new Exception("Error 8018: Data table is null.");
            }
        }
    }
}