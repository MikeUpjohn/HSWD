using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using artefact.enums;

namespace artefact.classes
{
    public class Location
    {
        private LocationArguments arguments;
        private string state;
        private string county;
        private int stateFIPS;
        private int countyFIPS;
        private double latitude;
        private double longitude;

        #region Properties
        /// <summary>
        /// Location property
        /// </summary>
        public LocationArguments Arguments
        {
            get
            {
                return this.arguments;
            }
        }

        /// <summary>
        /// State property
        /// </summary>
        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        /// <summary>
        /// County property
        /// </summary>
        public string County
        {
            get
            {
                return this.county;
            }

            set
            {
                this.county = value;
            }
        }

        /// <summary>
        /// State FIPS Code property
        /// </summary>
        public int StateFIPS
        {
            get
            {
                return this.stateFIPS;
            }

            set
            {
                /*if (CheckStateFIPSExistance(value))
                {*/
                    this.stateFIPS = value;
                /*}
                else
                {
                    throw new Exception("Error 5001: The state FIPS code supplied was invalid.");
                }*/
            }
        }

        /// <summary>
        /// County FIPS Code property
        /// </summary>
        public int CountyFIPS
        {
            get
            {
                return this.countyFIPS;
            }

            set
            {
                /*if (CheckStateFIPSExistance(value))
                {*/
                    this.countyFIPS = value;
                /*}
                else
                {
                    throw new Exception("Error 5002: The county FIPS code supplied was invalid.");
                }*/
            }
        }

        /// <summary>
        /// Latitude property
        /// </summary>
        public double Latitude
        {
            get
            {
                return this.latitude;
            }

            set
            {
                this.latitude = value;
            }
        }

        /// <summary>
        /// Longitude Property
        /// </summary>
        public double Longitude
        {
            get
            {
                return this.longitude;
            }

            set
            {
                this.longitude = value;
            }
        }
        #endregion

        /// <summary>
        /// Empty location constructor
        /// </summary>
        public Location()
        {
            arguments = new LocationArguments();
        }

        /// <summary>
        /// Location constructor
        /// </summary>
        /// <param name="stateFIPSCode">The FIPS code of the state.</param>
        /// <param name="countyFIPSCode">The county code of the county within this state.</param>
        public Location(int stateFIPSCode, int countyFIPSCode)
        {
            arguments = new LocationArguments();
            this.stateFIPS = stateFIPSCode;
            this.countyFIPS = countyFIPSCode;
        }

        /// <summary>
        /// Check FIPS Codes
        /// </summary>
        /// <returns>True if the state and county FIPS codes exists, else false.</returns>
        public bool CheckFIPSCodes() {
            if (CheckStateFIPSExistance())
            {
                if (CheckCountyFIPSExistance())
                {
                    return true;
                }

                return false;
            }

            return false;
        }

        /// <summary>
        /// Check whether this State FIPS code exists.
        /// </summary>
        /// <returns>True if the state FIPS code exists, else false.</returns>
        public bool CheckStateFIPSExistance()
        {
            if (this.StateFIPS != int.MinValue)
            {
                if (arguments.statesDictionary.states.ContainsKey(this.stateFIPS))
                {
                    return true;
                }

                return false;
            }
            else
            {
                throw new Exception("Error 5003: The state FIPS code is blank.");
            }
        }

        /// <summary>
        /// Check whether the specified state FIPS code exists.
        /// </summary>
        /// <returns>True if the state FIPS code exists, else false.</returns>
        public bool CheckStateFIPSExistance(int stateFIPS)
        {
            if (arguments.statesDictionary.states.ContainsKey(stateFIPS))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Check a county FIPS code exits knowing a valid state FIPS code.
        /// </summary>
        /// <returns>True if the county in this state exists, else false.</returns>
        public bool CheckCountyFIPSExistance()
        {
            if (this.StateFIPS != int.MinValue && this.CountyFIPS != int.MinValue)
            {
                try
                {
                    if (arguments.countiesDictionary.stateCounties[this.StateFIPS].ContainsKey(this.CountyFIPS))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error 5009: County FIPS key was null.", ex);
                }
            }
            else
            {
                throw new Exception("Error 5004: There state or county FIPS code, or both, are blank.");
            }
        }

        /// <summary>
        /// Check a county FIPS code exits knowing a valid state FIPS code.
        /// </summary>
        /// <returns>True if the county in this state exists, else false.</returns>
        public bool CheckCountyFIPSExistance(int countyFIPS)
        {
            if (this.StateFIPS != int.MinValue)
            {
                try
                {
                    if (arguments.countiesDictionary.stateCounties[this.StateFIPS].ContainsKey(countyFIPS))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error 5008: The county key entered does not exist in this dictionary.", ex);
                }
            }
            else
            {
                throw new Exception("Error 5005: The state FIPS code is blank.");
            }
        }

        /// <summary>
        /// Get a state name from the associated FIPS Code.
        /// </summary>
        /// <returns>The state name.</returns>
        public string GetStateNameFromFIPSCode()
        {
            if (this.StateFIPS != int.MinValue)
            {
                return arguments.statesDictionary.states[this.StateFIPS];
            }
            else
            {
                throw new Exception("Error 5006: The state FIPS code is blank.");
            }
        }

        /// <summary>
        /// Get a county name from the supplied state and county FIPS codes.
        /// </summary>
        /// <returns>The name of the county for which the state and county FIPS code were supplied.</returns>
        public string GetCountyNameFromStateAndCountyFIPSCode()
        {
            if (this.StateFIPS != 0 && this.CountyFIPS != 0)
            {
                try
                {
                    return arguments.countiesDictionary.stateCounties[this.StateFIPS][this.CountyFIPS];
                }
                catch (Exception ex)
                {
                    throw new Exception("Error 5010: The state or county FIPS code are blank.", ex);
                }
            }
            else
            {
                throw new Exception("Error 5007: The State FIPS code or the County FIPS code, or both, are blank.");
            }
        }
    }
}