using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using artefact.dictionaries;

namespace artefact.enums
{
    public class LocationArguments
    {
        public StatesDictionary statesDictionary;
        public CountyDictionary countiesDictionary;

        /// <summary>
        /// Location Arguments Constructor
        /// </summary>
        public LocationArguments()
        {
            statesDictionary = new StatesDictionary();
            countiesDictionary = new CountyDictionary();
        }
    }
}