using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using artefact.enums;

namespace artefact.classes
{
    public class MagnitudinalEvent : WeatherEvent
    {
        private double magnitude;
        private MagnitudinalMeasurementUnits magnitudinalUnits;

        /// <summary>
        /// Magnitude Property
        /// </summary>
        public double Magnitude
        {
            get
            {
                return this.magnitude;
            }

            set
            {
                this.magnitude = value;
            }
        }

        /// <summary>
        /// Magnitude Measurement Property
        /// </summary>
        public MagnitudinalMeasurementUnits MagnitudinalUnits
        {
            get
            {
                return this.magnitudinalUnits;
            }

            set
            {
                this.magnitudinalUnits = value;
            }
        }
    }
}