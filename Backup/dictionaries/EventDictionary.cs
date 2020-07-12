using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.dictionaries
{
    /// <summary>
    /// List of possible severe weather events as according to NOAA.
    /// </summary>
    public class EventDictionary
    {
        public Dictionary<int, string> events;

        /// <summary>
        /// Event Dictionary Constructor
        /// </summary>
        public EventDictionary()
        {
            events = new Dictionary<int, string>();

            events.Add(1, "Astronomical Low Tide");
            events.Add(2, "Avalanche");
            events.Add(3, "Blizzard");
            events.Add(4, "Coastal Flood");
            events.Add(5, "Cold/Wind Chill");
            events.Add(6, "Debris Flow");
            events.Add(7, "Dense Fog");
            events.Add(8, "Dense Smoke");
            events.Add(9, "Drought");
            events.Add(10, "Dust Devil");
            events.Add(11, "Dust Storm");
            events.Add(12, "Excessive Heat");
            events.Add(13, "Extreme Cold/Wind Chill");
            events.Add(14, "Flash Flood");
            events.Add(15, "Flood");
            events.Add(16, "Freezing Fog");
            events.Add(17, "Frost/Freeze");
            events.Add(18, "Funnel Cloud");
            events.Add(19, "Hail");
            events.Add(20, "Heat");
            events.Add(21, "Heavy Rain");
            events.Add(22, "Heavy Snow");
            events.Add(23, "Heavy Wind");
            events.Add(24, "High Snow");
            events.Add(25, "High Surf");
            events.Add(26, "High Wind");
            events.Add(27, "Hurricane");
            events.Add(28, "Ice Storm");
            events.Add(29, "Lake-Effect Snow");
            events.Add(30, "Lakeshore Flood");
            events.Add(31, "Landslide");
            events.Add(32, "Lightning");
            events.Add(33, "Marine Dense Fog");
            events.Add(34, "Marine Hail");
            events.Add(35, "Marine High Wind");
            events.Add(36, "Marine Strong Wind");
            events.Add(37, "Marine Thunderstorm Wind");
            events.Add(38, "Marine Tropical Storm");
            events.Add(39, "Northern Lights");
            events.Add(40, "Other");
            events.Add(41, "Rip Current");
            events.Add(42, "Seiche");
            events.Add(43, "Sleet");
            events.Add(44, "Storm Surge/Tide");
            events.Add(45, "Strong Wind");
            events.Add(46, "Thunderstorm Wind");
            events.Add(47, "Tornado");
            events.Add(48, "Tropical Depression");
            events.Add(49, "Tropical Storm");
            events.Add(50, "Tsunami");
            events.Add(51, "Volcanic Ash");
            events.Add(52, "Volcanic Ashfall");
            events.Add(53, "Waterspout");
            events.Add(54, "Wildfire");
            events.Add(55, "Winter Storm");
            events.Add(56, "Winter Weather");
        }
    }
}