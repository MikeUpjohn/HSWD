using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.dictionaries
{
    public class WeatherForecastingOffices
    {
        public Dictionary<string, string> weatherForecastingOffices;

        /// <summary>
        /// Weather Forecasting Offices Constructor
        /// </summary>
        public WeatherForecastingOffices()
        {
            weatherForecastingOffices = new Dictionary<string, string>();

            weatherForecastingOffices.Add("DEN", "Denver/Boulder");
            weatherForecastingOffices.Add("GJT", "Grand Junction");
            weatherForecastingOffices.Add("PUB", "Pueblo");
            weatherForecastingOffices.Add("ILX", "Central Illinois");
            weatherForecastingOffices.Add("LOT", "Chicago");
            weatherForecastingOffices.Add("IND", "Indianapolis");
            weatherForecastingOffices.Add("IWX", "Northern Indiana");
            weatherForecastingOffices.Add("DMX", "Des Moines");
            weatherForecastingOffices.Add("DVN", "Quad Cities");
            weatherForecastingOffices.Add("DDC", "Dodge City");
            weatherForecastingOffices.Add("GLD", "Goodland");
            weatherForecastingOffices.Add("TOP", "Topeka");
            weatherForecastingOffices.Add("ICT", "Wichita");
            weatherForecastingOffices.Add("JKL", "Jackson");
            weatherForecastingOffices.Add("LMK", "Louisville");
            weatherForecastingOffices.Add("PAH", "Paducah");
            weatherForecastingOffices.Add("DTX", "Detroit");
            weatherForecastingOffices.Add("GRR", "Grand Rapids");
            weatherForecastingOffices.Add("MQT", "Marquette");
            weatherForecastingOffices.Add("APX", "Northern Central Lower Michigan");
            weatherForecastingOffices.Add("DLH", "Duluth");
            weatherForecastingOffices.Add("MPX", "Minneapolis");
            weatherForecastingOffices.Add("EAX", "Kansas City/Pleasant Hill");
            weatherForecastingOffices.Add("SGF", "Springfield");
            weatherForecastingOffices.Add("LSX", "St. Louis");
            weatherForecastingOffices.Add("GID", "Hastings");
            weatherForecastingOffices.Add("LBF", "North Platte");
            weatherForecastingOffices.Add("OAX", "Omaha");
            weatherForecastingOffices.Add("BIS", "Bismarck");
            weatherForecastingOffices.Add("FGF", "Eastern North Dakota ");
            weatherForecastingOffices.Add("ABR", "Aberdeen");
            weatherForecastingOffices.Add("UNR", "Rapid City");
            weatherForecastingOffices.Add("FSD", "Sioux Falls");
            weatherForecastingOffices.Add("GRB", "Green Bay");
            weatherForecastingOffices.Add("ARX", "La Crosse");
            weatherForecastingOffices.Add("MKX", "Milwaukee");
            weatherForecastingOffices.Add("CYS", "Cheyenne");
            weatherForecastingOffices.Add("RIW", "Riverton");
            weatherForecastingOffices.Add("CAR", "Caribou");
            weatherForecastingOffices.Add("GYX", "Portland");
            weatherForecastingOffices.Add("LWX", "Baltimore/Washington");
            weatherForecastingOffices.Add("BOX", "Boston");
            weatherForecastingOffices.Add("PHI", "Philadelphia/Mt Holly ");
            weatherForecastingOffices.Add("ALY", "Albany");
            weatherForecastingOffices.Add("BGM", "Binghamton");
            weatherForecastingOffices.Add("BUF", "Buffalo");
            weatherForecastingOffices.Add("OKX", "New York City");
            weatherForecastingOffices.Add("MHX", "Newport/Morehead City");
            weatherForecastingOffices.Add("RAH", "Raleigh/Durham");
            weatherForecastingOffices.Add("ILM", "Wilmington");
            weatherForecastingOffices.Add("ILN", "Cincinnati");
            weatherForecastingOffices.Add("CLE", "Cleveland");
            weatherForecastingOffices.Add("CTP", "Central Pennsylvania");
            weatherForecastingOffices.Add("PHI", "Philadelphia/Mt Holly ");
            weatherForecastingOffices.Add("PBZ", "Pittsburgh");
            weatherForecastingOffices.Add("CHS", "Charleston");
            weatherForecastingOffices.Add("CAE", "Columbia");
            weatherForecastingOffices.Add("GSP", "Greenville/Spartanburg");
            weatherForecastingOffices.Add("BTV", "Burlington");
            weatherForecastingOffices.Add("LWX", "Baltimore/Washington");
            weatherForecastingOffices.Add("RNK", "Roanoke");
            weatherForecastingOffices.Add("AKQ", "Wakefield");
            weatherForecastingOffices.Add("RLX", "Charleston");
            weatherForecastingOffices.Add("BMX", "Birmingham");
            weatherForecastingOffices.Add("HUN", "Huntsville");
            weatherForecastingOffices.Add("MOB", "Mobile");
            weatherForecastingOffices.Add("LZK", "Little Rock");
            weatherForecastingOffices.Add("JAX", "Jacksonville");
            weatherForecastingOffices.Add("EYW", "Key West");
            weatherForecastingOffices.Add("MLB", "Melbourne");
            weatherForecastingOffices.Add("MFL", "Miami");
            weatherForecastingOffices.Add("TLH", "Tallahassee");
            weatherForecastingOffices.Add("TBW", "Tampa Bay Area");
            weatherForecastingOffices.Add("FFC", "Atlanta");
            weatherForecastingOffices.Add("LCH", "Lake Charles");
            weatherForecastingOffices.Add("LIX", "New Orleans/Baton Rouge ");
            weatherForecastingOffices.Add("SHV", "Shreveport");
            weatherForecastingOffices.Add("JAN", "Jackson");
            weatherForecastingOffices.Add("ABQ", "Albuquerque");
            weatherForecastingOffices.Add("OUN", "Oklahoma City");
            weatherForecastingOffices.Add("TSA", "Tulsa");
            weatherForecastingOffices.Add("SJU", "San Juan");
            weatherForecastingOffices.Add("MRX", "Knoxville/Tri-Cities");
            weatherForecastingOffices.Add("MEG", "Memphis");
            weatherForecastingOffices.Add("BNA", "Nashville");
            weatherForecastingOffices.Add("AMA", "Amarillo");
            weatherForecastingOffices.Add("EWX", "Austin/San Antonio");
            weatherForecastingOffices.Add("BRO", "Brownsville");
            weatherForecastingOffices.Add("CRP", "Corpus Christi");
            weatherForecastingOffices.Add("FWD", "Dallas/Fort Worth");
            weatherForecastingOffices.Add("ELP", "El Paso");
            weatherForecastingOffices.Add("HGX", "Houston/Galveston");
            weatherForecastingOffices.Add("LUB", "Lubbock");
            weatherForecastingOffices.Add("MAF", "Midland/Odessa");
            weatherForecastingOffices.Add("SJT", "San Angelo");
            weatherForecastingOffices.Add("FGZ", "Flagstaff");
            weatherForecastingOffices.Add("PSR", "Phoenix");
            weatherForecastingOffices.Add("TWC", "Tucson");
            weatherForecastingOffices.Add("EKA", "Eureka");
            weatherForecastingOffices.Add("LOX", "Los Angeles");
            weatherForecastingOffices.Add("STO", "Sacramento");
            weatherForecastingOffices.Add("SGX", "San Diego");
            weatherForecastingOffices.Add("MTR", "San Francisco Bay Area ");
            weatherForecastingOffices.Add("HNX", "San Joaquin Valley");
            weatherForecastingOffices.Add("BOI", "Boise");
            weatherForecastingOffices.Add("PIH", "Pocatello/Idaho Falls ");
            weatherForecastingOffices.Add("BYZ", "Billings");
            weatherForecastingOffices.Add("GGW", "Glasgow");
            weatherForecastingOffices.Add("TFX", "Great Falls");
            weatherForecastingOffices.Add("MSO", "Missoula");
            weatherForecastingOffices.Add("LKN", "Elko");
            weatherForecastingOffices.Add("VEF", "Las Vegas");
            weatherForecastingOffices.Add("REV", "Reno");
            weatherForecastingOffices.Add("MFR", "Medford");
            weatherForecastingOffices.Add("PDT", "Pendleton");
            weatherForecastingOffices.Add("PQR", "Portland");
            weatherForecastingOffices.Add("SLC", "Salt Lake City");
            weatherForecastingOffices.Add("SEW", "Seattle/Tacoma");
            weatherForecastingOffices.Add("OTX", "Spokane");
            weatherForecastingOffices.Add("PAFC", "Anchorage");
            weatherForecastingOffices.Add("PAFG", "Fairbanks");
            weatherForecastingOffices.Add("PAJK", "Juneau");
            weatherForecastingOffices.Add("HNL", "Honolulu");
            weatherForecastingOffices.Add("GUAM", "Guam");
            weatherForecastingOffices.Add("SAMOA", "Pago Pago");
        }
    }
}