using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.classes
{
    public class Episode
    {
        private int episodeID;
        private string episodeTitle;
        private string episodeDescription;

        /// <summary>
        /// Episode ID constructor
        /// </summary>
        public int EpisodeID
        {
            get
            {
                return this.episodeID;
            }

            set
            {
                this.episodeID = value;
            }
        }

        /// <summary>
        /// Episode Title constructor
        /// </summary>
        public string EpisodeTitle
        {
            get
            {
                return this.episodeTitle;
            }

            set
            {
                this.episodeTitle = value;
            }
        }

        /// <summary>
        /// Episode Description constructor
        /// </summary>
        public string EpisodeDescription
        {
            get
            {
                return this.episodeDescription;
            }

            set
            {
                this.episodeDescription = value;
            }
        }

        /// <summary>
        /// Episode Empty Constructor
        /// </summary>
        public Episode()
        {

        }
    }
}