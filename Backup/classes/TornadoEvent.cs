using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.classes
{
    public class TornadoEvent : WeatherEvent
    {
        private string intensity;
        private double pathLength;
        private int pathWidth;

        /// <summary>
        /// Intensity Property
        /// </summary>
        public string Intensity
        {
            get
            {
                return this.intensity;
            }

            set
            {
                this.intensity = value;
            }
        }

        /// <summary>
        /// Path Length Property
        /// </summary>
        public double PathLength
        {
            get
            {
                return this.pathLength;
            }

            set
            {
                this.pathLength = value;
            }
        }

        /// <summary>
        /// Path Width Property
        /// </summary>
        public int PathWidth
        {
            get
            {
                return this.pathWidth;
            }

            set
            {
                this.pathWidth = value;
            }
        }
    }
}