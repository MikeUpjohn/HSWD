using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.classes
{
    public class WeatherEvent
    {
        private int eventID;
        private Location location;
        private int year;
        private int month;
        private string weatherForecastingOffice;
        private DateTime beginDateTime;
        private string timeZone;
        private DateTime endDateTime;
        private int directInjuries;
        private int indirectInjuries;
        private int directDeaths;
        private int indirectDeaths;
        private string propertyDamageValue;
        private string cropDamageValue;
        private string reportSource;
        private Episode episodeInformation;
        private string eventDescription;
        private DateTime lastDateModified;
        private DateTime lastDateCertified;

        /// <summary>
        /// Event ID property.
        /// </summary>
        public int EventID
        {
            get
            {
                return this.eventID;
            }

            set
            {
                this.eventID = value;
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
        /// Year property
        /// </summary>
        public int Year
        {
            get
            {
                return this.year;
            }

            set
            {
                this.year = value;
            }
        }

        /// <summary>
        /// Month Property
        /// </summary>
        public int Month
        {
            get
            {
                return this.month;
            }

            set
            {
                this.month = value;
            }
        }
        
        /// <summary>
        /// Weather Forecasting Office Property
        /// </summary>
        public string WeatherForecastingOffice
        {
            get
            {
                return this.weatherForecastingOffice;
            }

            set
            {
                this.weatherForecastingOffice = value;
            }
        }

        /// <summary>
        /// Begin Date Time Property
        /// </summary>
        public DateTime BeginDateTime
        {
            get
            {
                return this.beginDateTime;
            }

            set
            {
                this.beginDateTime = value;
            }
        }

        /// <summary>
        /// Time Zone Property
        /// </summary>
        public string TimeZone
        {
            get
            {
                return this.timeZone;
            }

            set
            {
                this.timeZone = value;
            }
        }

        /// <summary>
        /// End Date Time Property
        /// </summary>
        public DateTime EndDateTime
        {
            get
            {
                return this.endDateTime;
            }

            set
            {
                this.endDateTime = value;
            }
        }

        /// <summary>
        /// Direct Injuries Property
        /// </summary>
        public int DirectInjuries
        {
            get
            {
                return this.directInjuries;
            }

            set
            {
                this.directInjuries = value;
            }
        }

        /// <summary>
        /// Indirect Injuries Property
        /// </summary>
        public int IndirectInjuries
        {
            get
            {
                return this.indirectInjuries;
            }

            set
            {
                this.indirectInjuries = value;
            }
        }

        /// <summary>
        /// Direct Deaths Property
        /// </summary>
        public int DirectDeaths
        {
            get
            {
                return this.directDeaths;
            }

            set
            {
                this.directDeaths = value;
            }
        }

        /// <summary>
        /// Indirect Deaths Property
        /// </summary>
        public int IndirectDeaths
        {
            get
            {
                return this.indirectDeaths;
            }

            set
            {
                this.indirectDeaths = value;
            }
        }

        /// <summary>
        /// Property Damage Value Property
        /// </summary>
        public string PropertyDamageValue
        {
            get
            {
                return this.propertyDamageValue;
            }

            set
            {
                this.propertyDamageValue = value;
            }
        }

        /// <summary>
        /// Crop Damage Value Property
        /// </summary>
        public string CropDamageValue
        {
            get
            {
                return this.cropDamageValue;
            }

            set
            {
                this.cropDamageValue = value;
            }
        }

        /// <summary>
        /// Report Source Property
        /// </summary>
        public string ReportSource
        {
            get
            {
                return this.reportSource;
            }

            set
            {
                this.reportSource = value;
            }
        }

        /// <summary>
        /// Episode Information Property
        /// </summary>
        public Episode EpisodeInformation
        {
            get
            {
                return this.episodeInformation;
            }

            set
            {
                this.episodeInformation = value;
            }
        }

        /// <summary>
        /// Event Description Property
        /// </summary>
        public string EventDescription
        {
            get
            {
                return this.eventDescription;
            }

            set
            {
                this.eventDescription = value;
            }
        }

        /// <summary>
        /// Last Date Modified Property
        /// </summary>
        public DateTime LastDateModified
        {
            get
            {
                return this.lastDateModified;
            }

            set
            {
                this.lastDateModified = value;
            }
        }

        /// <summary>
        /// Last Date Certified Property
        /// </summary>
        public DateTime LastDateCertified
        {
            get
            {
                return this.lastDateCertified;
            }

            set
            {
                this.lastDateCertified = value;
            }
        }
    }
}