using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.dictionaries
{
    public class StatesDictionary
    {
        public Dictionary<int, string> states;

        /// <summary>
        /// States Dictionary Constructor
        /// </summary>
        public StatesDictionary()
        {
            states = new Dictionary<int, string>();

            states.Add(1, "Alabama");
            states.Add(2, "Alaska");
            states.Add(4, "Arizona");
            states.Add(5, "Arkansas");
            states.Add(6, "California");
            states.Add(8, "Colorado");
            states.Add(9, "Connecticut");
            states.Add(10, "Delaware");
            states.Add(11, "District Of Columbia");
            states.Add(12, "Florida");
            states.Add(13, "Georgia");
            states.Add(15, "Hawaii");
            states.Add(16, "Idaho");
            states.Add(17, "Illinois");
            states.Add(18, "Indiana");
            states.Add(19, "Iowa");
            states.Add(20, "Kansas");
            states.Add(21, "Kentucky");
            states.Add(22, "Louisiana");
            states.Add(23, "Maine");
            states.Add(24, "Maryland");
            states.Add(25, "Massachusetts");
            states.Add(26, "Michigan");
            states.Add(27, "Minnesota");
            states.Add(28, "Mississippi");
            states.Add(29, "Missouri");
            states.Add(30, "Montana");
            states.Add(31, "Nebraska");
            states.Add(32, "Nevada");
            states.Add(33, "New Hampshire");
            states.Add(34, "New Jersey");
            states.Add(35, "New Mexico");
            states.Add(36, "New York");
            states.Add(37, "North Carolina");
            states.Add(38, "North Dakota");
            states.Add(39, "Ohio");
            states.Add(40, "Oklahoma");
            states.Add(41, "Oregon");
            states.Add(42, "Pennsylvania");
            states.Add(44, "Rhode Island");
            states.Add(45, "South Carolina");
            states.Add(46, "South Dakota");
            states.Add(47, "Tennessee");
            states.Add(48, "Texas");
            states.Add(49, "Utah");
            states.Add(50, "Vermont");
            states.Add(51, "Virginia");
            states.Add(53, "Washington");
            states.Add(54, "West Virginia");
            states.Add(55, "Wisconsin");
            states.Add(56, "Wyoming");
            states.Add(72, "Puerto Rico");
        }
    }
}