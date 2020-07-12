using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact
{
    public class Username
    {
        private string username;

        /// <summary>
        /// Username Property
        /// </summary>
        public string UserName
        {
            get
            {
                return username;
            }

            set
            {
                this.username = value;
            }
        }

        /// <summary>
        /// Empty Constructor.
        /// </summary>
        public Username()
        {

        }

        /// <summary>
        /// Username Constructor.
        /// </summary>
        /// <param name="username">The username constructor.</param>
        public Username(string username)
        {
            this.UserName = username;
        }
    }
}