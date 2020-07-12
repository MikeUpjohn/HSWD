using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.dictionaries
{
    public class CountyDictionary
    {
        #region Dictionary declarations
        public Dictionary<int, Dictionary<int, string>> stateCounties;
        private Dictionary<int, string> alabama;
        private Dictionary<int, string> alaska;
        private Dictionary<int, string> arizona;
        private Dictionary<int, string> arkansas;
        private Dictionary<int, string> california;
        private Dictionary<int, string> colorado;
        private Dictionary<int, string> connecticut;
        private Dictionary<int, string> delaware;
        private Dictionary<int, string> districtOfColumbia;
        private Dictionary<int, string> florida;
        private Dictionary<int, string> georgia;
        private Dictionary<int, string> hawaii;
        private Dictionary<int, string> idaho;
        private Dictionary<int, string> illinois;
        private Dictionary<int, string> indiana;
        private Dictionary<int, string> iowa;
        private Dictionary<int, string> kansas;
        private Dictionary<int, string> kentucky;
        private Dictionary<int, string> louisiana;
        private Dictionary<int, string> maine;
        private Dictionary<int, string> maryland;
        private Dictionary<int, string> massachusetts;
        private Dictionary<int, string> michigan;
        private Dictionary<int, string> minnesota;
        private Dictionary<int, string> mississippi;
        private Dictionary<int, string> missouri;
        private Dictionary<int, string> montana;
        private Dictionary<int, string> nebraska;
        private Dictionary<int, string> nevada;
        private Dictionary<int, string> newHampshire;
        private Dictionary<int, string> newJersey;
        private Dictionary<int, string> newMexico;
        private Dictionary<int, string> newYork;
        private Dictionary<int, string> northCarolina;
        private Dictionary<int, string> northDakota;
        private Dictionary<int, string> ohio;
        private Dictionary<int, string> oklahoma;
        private Dictionary<int, string> oregon;
        private Dictionary<int, string> pennsylvania;
        private Dictionary<int, string> rhodeIsland;
        private Dictionary<int, string> southCarolina;
        private Dictionary<int, string> southDakota;
        private Dictionary<int, string> tennessee;
        private Dictionary<int, string> texas;
        private Dictionary<int, string> utah;
        private Dictionary<int, string> vermont;
        private Dictionary<int, string> virginia;
        private Dictionary<int, string> washington;
        private Dictionary<int, string> westVirginia;
        private Dictionary<int, string> wisconsin;
        private Dictionary<int, string> wyoming;
        private Dictionary<int, string> puertoRico;
        #endregion

        #region Setting up states dictionaries
        /// <summary>
        /// County Dictionary constructor
        /// </summary>
        public CountyDictionary()
        {
            stateCounties = new Dictionary<int, Dictionary<int, string>>();

            InitialiseStateDictionaries();
            PopulateStateCounties();

            stateCounties.Add(1, alabama);
            stateCounties.Add(2, alaska);
            stateCounties.Add(4, arizona);
            stateCounties.Add(5, arkansas);
            stateCounties.Add(6, california);
            stateCounties.Add(8, colorado);
            stateCounties.Add(9, connecticut);
            stateCounties.Add(10, delaware);
            stateCounties.Add(11, districtOfColumbia);
            stateCounties.Add(12, florida);
            stateCounties.Add(13, georgia);
            stateCounties.Add(15, hawaii);
            stateCounties.Add(16, idaho);
            stateCounties.Add(17, illinois);
            stateCounties.Add(18, indiana);
            stateCounties.Add(19, iowa);
            stateCounties.Add(20, kansas);
            stateCounties.Add(21, kentucky);
            stateCounties.Add(22, louisiana);
            stateCounties.Add(23, maine);
            stateCounties.Add(24, maryland);
            stateCounties.Add(25, massachusetts);
            stateCounties.Add(26, michigan);
            stateCounties.Add(27, minnesota);
            stateCounties.Add(28, mississippi);
            stateCounties.Add(29, missouri);
            stateCounties.Add(30, montana);
            stateCounties.Add(31, nebraska);
            stateCounties.Add(32, nevada);
            stateCounties.Add(33, newHampshire);
            stateCounties.Add(34, newJersey);
            stateCounties.Add(35, newMexico);
            stateCounties.Add(36, newYork);
            stateCounties.Add(37, northCarolina);
            stateCounties.Add(38, northDakota);
            stateCounties.Add(39, ohio);
            stateCounties.Add(40, oklahoma);
            stateCounties.Add(41, oregon);
            stateCounties.Add(42, pennsylvania);
            stateCounties.Add(44, rhodeIsland);
            stateCounties.Add(45, southCarolina);
            stateCounties.Add(46, southDakota);
            stateCounties.Add(47, tennessee);
            stateCounties.Add(48, texas);
            stateCounties.Add(49, utah);
            stateCounties.Add(50, vermont);
            stateCounties.Add(51, virginia);
            stateCounties.Add(53, washington);
            stateCounties.Add(54, westVirginia);
            stateCounties.Add(55, wisconsin);
            stateCounties.Add(56, wyoming);
            stateCounties.Add(72, puertoRico);
        }

        /// <summary>
        /// Initialise all state dictionaries.
        /// </summary>
        private void InitialiseStateDictionaries()
        {
            alabama = new Dictionary<int, string>();
            alaska = new Dictionary<int, string>();
            arizona = new Dictionary<int, string>();
            arkansas = new Dictionary<int, string>();
            california = new Dictionary<int, string>();
            colorado = new Dictionary<int, string>();
            connecticut = new Dictionary<int, string>();
            delaware = new Dictionary<int, string>();
            districtOfColumbia = new Dictionary<int, string>();
            florida = new Dictionary<int, string>();
            georgia = new Dictionary<int, string>();
            hawaii = new Dictionary<int, string>();
            idaho = new Dictionary<int, string>();
            illinois = new Dictionary<int, string>();
            indiana = new Dictionary<int, string>();
            iowa = new Dictionary<int, string>();
            kansas = new Dictionary<int, string>();
            kentucky = new Dictionary<int, string>();
            louisiana = new Dictionary<int, string>();
            maine = new Dictionary<int, string>();
            maryland = new Dictionary<int, string>();
            massachusetts = new Dictionary<int, string>();
            michigan = new Dictionary<int, string>();
            minnesota = new Dictionary<int, string>();
            mississippi = new Dictionary<int, string>();
            missouri = new Dictionary<int, string>();
            montana = new Dictionary<int, string>();
            nebraska = new Dictionary<int, string>();
            nevada = new Dictionary<int, string>();
            newHampshire = new Dictionary<int, string>();
            newJersey = new Dictionary<int, string>();
            newMexico = new Dictionary<int, string>();
            newYork = new Dictionary<int, string>();
            northCarolina = new Dictionary<int, string>();
            northDakota = new Dictionary<int, string>();
            ohio = new Dictionary<int, string>();
            oklahoma = new Dictionary<int, string>();
            oregon = new Dictionary<int, string>();
            pennsylvania = new Dictionary<int, string>();
            rhodeIsland = new Dictionary<int, string>();
            southCarolina = new Dictionary<int, string>();
            southDakota = new Dictionary<int, string>();
            tennessee = new Dictionary<int, string>();
            texas = new Dictionary<int, string>();
            utah = new Dictionary<int, string>();
            vermont = new Dictionary<int, string>();
            virginia = new Dictionary<int, string>();
            washington = new Dictionary<int, string>();
            westVirginia = new Dictionary<int, string>();
            wisconsin = new Dictionary<int, string>();
            wyoming = new Dictionary<int, string>();
            puertoRico = new Dictionary<int, string>();

        }
        #endregion

        #region Poulating All States
        /// <summary>
        /// Populate all states with their counties
        /// </summary>
        private void PopulateStateCounties()
        {
            PopulateAlabama();
            PopulateAlaska();
            PopulateArizona();
            PopulateArkansas();
            PopulateCalifornia();
            PopulateColorado();
            PopulateConnecticut();
            PopulateDelaware();
            PopulateDistrictOfColumbia();
            PopulateFlorida();
            PopulateGeorgia();
            PopulateHawaii();
            PopulateIdaho();
            PopulateIllinois();
            PopulateIndiana();
            PopulateIowa();
            PopulateKansas();
            PopulateKentucky();
            PopulateLouisiana();
            PopulateMaine();
            PopulateMaryland();
            PopulateMassachusetts();
            PopulateMichigan();
            PopulateMinnesota();
            PopulateMississippi();
            PopulateMissouri();
            PopulateMontana();
            PopulateNebraska();
            PopulateNevada();
            PopulateNewHampshire();
            PopulateNewJersey();
            PopulateNewMexico();
            PopulateNewYork();
            PopulateNorthCarolina();
            PopulateNorthDakota();
            PopulateOhio();
            PopulateOklahoma();
            PopulateOregon();
            PopulatePennsylvania();
            PopulateRhodeIsland();
            PopulateSouthCarolina();
            PopulateSouthDakota();
            PopulateTennessee();
            PopulateTexas();
            PopulateUtah();
            PopulateVermont();
            PopulateVirginia();
            PopulateWashington();
            PopulateWestVirginia();
            PopulateWisconsin();
            PopulateWyoming();
            PopulatePuertoRico();

        }
        #endregion

        #region Populate Individual States
        /// <summary>
        /// Populate Alabama with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateAlabama()
        {
            alabama.Add(001, "Autauga");
            alabama.Add(003, "Baldwin");
            alabama.Add(005, "Barbour");
            alabama.Add(007, "Bibb");
            alabama.Add(009, "Blount");
            alabama.Add(011, "Bullock");
            alabama.Add(013, "Butler");
            alabama.Add(015, "Calhoun");
            alabama.Add(017, "Chambers");
            alabama.Add(019, "Cherokee");
            alabama.Add(021, "Chilton");
            alabama.Add(023, "Choctaw");
            alabama.Add(025, "Clarke");
            alabama.Add(027, "Clay");
            alabama.Add(029, "Cleburne");
            alabama.Add(031, "Coffee");
            alabama.Add(033, "Colbert");
            alabama.Add(035, "Conecuh");
            alabama.Add(037, "Coosa");
            alabama.Add(039, "Covington");
            alabama.Add(041, "Crenshaw");
            alabama.Add(043, "Cullman");
            alabama.Add(045, "Dale");
            alabama.Add(047, "Dallas");
            alabama.Add(049, "De Kalb");
            alabama.Add(051, "Elmore");
            alabama.Add(053, "Escambia");
            alabama.Add(055, "Etowah");
            alabama.Add(057, "Fayette");
            alabama.Add(059, "Franklin");
            alabama.Add(061, "Geneva");
            alabama.Add(063, "Greene");
            alabama.Add(065, "Hale");
            alabama.Add(067, "Henry");
            alabama.Add(069, "Houston");
            alabama.Add(071, "Jackson");
            alabama.Add(073, "Jefferson");
            alabama.Add(075, "Lamar");
            alabama.Add(077, "Lauderdale");
            alabama.Add(079, "Lawrence");
            alabama.Add(081, "Lee");
            alabama.Add(083, "Limestone");
            alabama.Add(085, "Lowndes");
            alabama.Add(087, "Macon");
            alabama.Add(089, "Madison");
            alabama.Add(091, "Marengo");
            alabama.Add(093, "Marion");
            alabama.Add(095, "Marshall");
            alabama.Add(097, "Mobile");
            alabama.Add(099, "Monroe");
            alabama.Add(101, "Montgomery");
            alabama.Add(103, "Morgan");
            alabama.Add(105, "Perry");
            alabama.Add(107, "Pickens");
            alabama.Add(109, "Pike");
            alabama.Add(111, "Randolph");
            alabama.Add(113, "Russell");
            alabama.Add(115, "St Clair");
            alabama.Add(117, "Shelby");
            alabama.Add(119, "Sumter");
            alabama.Add(121, "Talladega");
            alabama.Add(123, "Tallapoosa");
            alabama.Add(125, "Tuscaloosa");
            alabama.Add(127, "Walker");
            alabama.Add(129, "Washington");
            alabama.Add(131, "Wilcox");
            alabama.Add(133, "Winston");

        }

        /// <summary>
        /// Populate Alaska with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateAlaska()
        {
            alaska.Add(013, "Aleutians East");
            alaska.Add(016, "Aleutians West");
            alaska.Add(020, "Anchorage");
            alaska.Add(050, "Bethel");
            alaska.Add(060, "Bristol Bay");
            alaska.Add(068, "Denali");
            alaska.Add(070, "Dillingham");
            alaska.Add(090, "Fairbanks North Star");
            alaska.Add(100, "Haines");
            alaska.Add(110, "Juneau");
            alaska.Add(122, "Kenai Peninsula");
            alaska.Add(130, "Ketchikan Gateway");
            alaska.Add(150, "Kodiak Island");
            alaska.Add(164, "Lake and Peninsula");
            alaska.Add(170, "Matanuska Susitna");
            alaska.Add(180, "Nome");
            alaska.Add(185, "North Slope");
            alaska.Add(188, "Northwest Arctic");
            alaska.Add(201, "Prince Wales Ketchikan");
            alaska.Add(220, "Sitka");
            alaska.Add(232, "Skagway Hoonah Angoon");
            alaska.Add(240, "Southeast Fairbanks");
            alaska.Add(261, "Valdez Cordova");
            alaska.Add(270, "Wade Hampton");
            alaska.Add(280, "Wrangell Petersburg");
            alaska.Add(282, "Yakutat");
            alaska.Add(290, "Yukon Koyukuk");

        }

        /// <summary>
        /// Populate Arizona with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateArizona()
        {
            arizona.Add(001, "Apache");
            arizona.Add(003, "Cochise");
            arizona.Add(005, "Coconino");
            arizona.Add(007, "Gila");
            arizona.Add(009, "Graham");
            arizona.Add(011, "Greenlee");
            arizona.Add(012, "La Paz");
            arizona.Add(013, "Maricopa");
            arizona.Add(015, "Mohave");
            arizona.Add(017, "Navajo");
            arizona.Add(019, "Pima");
            arizona.Add(021, "Pinal");
            arizona.Add(023, "Santa Cruz");
            arizona.Add(025, "Yavapai");
            arizona.Add(027, "Yuma");

        }

        /// <summary>
        /// Populate Arkansas with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateArkansas()
        {
            arkansas.Add(001, "Arkansas");
            arkansas.Add(003, "Ashley");
            arkansas.Add(005, "Baxter");
            arkansas.Add(007, "Benton");
            arkansas.Add(009, "Boone");
            arkansas.Add(011, "Bradley");
            arkansas.Add(013, "Calhoun");
            arkansas.Add(015, "Carroll");
            arkansas.Add(017, "Chicot");
            arkansas.Add(019, "Clark");
            arkansas.Add(021, "Clay");
            arkansas.Add(023, "Cleburne");
            arkansas.Add(025, "Cleveland");
            arkansas.Add(027, "Columbia");
            arkansas.Add(029, "Conway");
            arkansas.Add(031, "Craighead");
            arkansas.Add(033, "Crawford");
            arkansas.Add(035, "Crittenden");
            arkansas.Add(037, "Cross");
            arkansas.Add(039, "Dallas");
            arkansas.Add(041, "Desha");
            arkansas.Add(043, "Drew");
            arkansas.Add(045, "Faulkner");
            arkansas.Add(047, "Franklin");
            arkansas.Add(049, "Fulton");
            arkansas.Add(051, "Garland");
            arkansas.Add(053, "Grant");
            arkansas.Add(055, "Greene");
            arkansas.Add(057, "Hempstead");
            arkansas.Add(059, "Hot Spring");
            arkansas.Add(061, "Howard");
            arkansas.Add(063, "Independence");
            arkansas.Add(065, "Izard");
            arkansas.Add(067, "Jackson");
            arkansas.Add(069, "Jefferson");
            arkansas.Add(071, "Johnson");
            arkansas.Add(073, "Lafayette");
            arkansas.Add(075, "Lawrence");
            arkansas.Add(077, "Lee");
            arkansas.Add(079, "Lincoln");
            arkansas.Add(081, "Little River");
            arkansas.Add(083, "Logan");
            arkansas.Add(085, "Lonoke");
            arkansas.Add(087, "Madison");
            arkansas.Add(089, "Marion");
            arkansas.Add(091, "Miller");
            arkansas.Add(093, "Mississippi");
            arkansas.Add(095, "Monroe");
            arkansas.Add(099, "Nevada");
            arkansas.Add(101, "Newton");
            arkansas.Add(103, "Ouachita");
            arkansas.Add(105, "Perry");
            arkansas.Add(107, "Phillips");
            arkansas.Add(109, "Pike");
            arkansas.Add(111, "Poinsett");
            arkansas.Add(113, "Polk");
            arkansas.Add(115, "Pope");
            arkansas.Add(117, "Prairie");
            arkansas.Add(119, "Pulaski");
            arkansas.Add(121, "Randolph");
            arkansas.Add(123, "St Francis");
            arkansas.Add(125, "Saline");
            arkansas.Add(127, "Scott");
            arkansas.Add(129, "Searcy");
            arkansas.Add(131, "Sebastian");
            arkansas.Add(133, "Sevier");
            arkansas.Add(135, "Sharp");
            arkansas.Add(137, "Stone");
            arkansas.Add(139, "Union");
            arkansas.Add(141, "Van Buren");
            arkansas.Add(143, "Washington");
            arkansas.Add(145, "White");
            arkansas.Add(147, "Woodruff");
            arkansas.Add(149, "Yell");

        }

        /// <summary>
        /// Populate California with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateCalifornia()
        {
            california.Add(001, "Alameda");
            california.Add(003, "Alpine");
            california.Add(005, "Amador");
            california.Add(007, "Butte");
            california.Add(009, "Calaveras");
            california.Add(011, "Colusa");
            california.Add(013, "Contra Costa");
            california.Add(015, "Del Norte");
            california.Add(017, "El Dorado");
            california.Add(019, "Fresno");
            california.Add(021, "Glenn");
            california.Add(023, "Humboldt");
            california.Add(025, "Imperial");
            california.Add(027, "Inyo");
            california.Add(029, "Kern");
            california.Add(031, "Kings");
            california.Add(033, "Lake");
            california.Add(035, "Lassen");
            california.Add(037, "Los Angeles");
            california.Add(039, "Madera");
            california.Add(041, "Marin");
            california.Add(043, "Mariposa");
            california.Add(045, "Mendocino");
            california.Add(047, "Merced");
            california.Add(049, "Modoc");
            california.Add(051, "Mono");
            california.Add(053, "Monterey");
            california.Add(055, "Napa");
            california.Add(057, "Nevada");
            california.Add(059, "Orange");
            california.Add(061, "Placer");
            california.Add(063, "Plumas");
            california.Add(065, "Riverside");
            california.Add(067, "Sacramento");
            california.Add(069, "San Benito");
            california.Add(071, "San Bernardino");
            california.Add(073, "San Diego");
            california.Add(075, "San Francisco");
            california.Add(077, "San Joaquin");
            california.Add(079, "San Luis Obispo");
            california.Add(081, "San Mateo");
            california.Add(083, "Santa Barbara");
            california.Add(085, "Santa Clara");
            california.Add(087, "Santa Cruz");
            california.Add(089, "Shasta");
            california.Add(091, "Sierra");
            california.Add(093, "Siskiyou");
            california.Add(095, "Solano");
            california.Add(097, "Sonoma");
            california.Add(099, "Stanislaus");
            california.Add(101, "Sutter");
            california.Add(103, "Tehama");
            california.Add(105, "Trinity");
            california.Add(107, "Tulare");
            california.Add(109, "Tuolumne");
            california.Add(111, "Ventura");
            california.Add(113, "Yolo");
            california.Add(115, "Yuba");

        }

        /// <summary>
        /// Populate Colorado with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateColorado()
        {
            colorado.Add(001, "Adams");
            colorado.Add(003, "Alamosa");
            colorado.Add(005, "Arapahoe");
            colorado.Add(007, "Archuleta");
            colorado.Add(009, "Baca");
            colorado.Add(011, "Bent");
            colorado.Add(013, "Boulder");
            colorado.Add(014, "Broomfield");
            colorado.Add(015, "Chaffee");
            colorado.Add(017, "Cheyenne");
            colorado.Add(019, "Clear Creek");
            colorado.Add(021, "Conejos");
            colorado.Add(023, "Costilla");
            colorado.Add(025, "Crowley");
            colorado.Add(027, "Custer");
            colorado.Add(029, "Delta");
            colorado.Add(031, "Denver");
            colorado.Add(033, "Dolores");
            colorado.Add(035, "Douglas");
            colorado.Add(037, "Eagle");
            colorado.Add(039, "Elbert");
            colorado.Add(041, "El Paso");
            colorado.Add(043, "Fremont");
            colorado.Add(045, "Garfield");
            colorado.Add(047, "Gilpin");
            colorado.Add(049, "Grand");
            colorado.Add(051, "Gunnison");
            colorado.Add(053, "Hinsdale");
            colorado.Add(055, "Huerfano");
            colorado.Add(057, "Jackson");
            colorado.Add(059, "Jefferson");
            colorado.Add(061, "Kiowa");
            colorado.Add(063, "Kit Carson");
            colorado.Add(065, "Lake");
            colorado.Add(067, "La Plata");
            colorado.Add(069, "Larimer");
            colorado.Add(071, "Las Animas");
            colorado.Add(073, "Lincoln");
            colorado.Add(075, "Logan");
            colorado.Add(077, "Mesa");
            colorado.Add(079, "Mineral");
            colorado.Add(081, "Moffat");
            colorado.Add(083, "Montezuma");
            colorado.Add(085, "Montrose");
            colorado.Add(087, "Morgan");
            colorado.Add(089, "Otero");
            colorado.Add(091, "Ouray");
            colorado.Add(093, "Park");
            colorado.Add(095, "Phillips");
            colorado.Add(097, "Pitkin");
            colorado.Add(099, "Prowers");
            colorado.Add(101, "Pueblo");
            colorado.Add(103, "Rio Blanco");
            colorado.Add(105, "Rio Grande");
            colorado.Add(107, "Routt");
            colorado.Add(109, "Saguache");
            colorado.Add(111, "San Juan");
            colorado.Add(113, "San Miguel");
            colorado.Add(115, "Sedgwick");
            colorado.Add(117, "Summit");
            colorado.Add(119, "Teller");
            colorado.Add(121, "Washington");
            colorado.Add(123, "Weld");
            colorado.Add(125, "Yuma");

        }

        /// <summary>
        /// Populate Connecticut with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateConnecticut()
        {
            connecticut.Add(001, "Fairfield");
            connecticut.Add(003, "Hartford");
            connecticut.Add(005, "Litchfield");
            connecticut.Add(007, "Middlesex");
            connecticut.Add(009, "New Haven");
            connecticut.Add(011, "New London");
            connecticut.Add(013, "Tolland");
            connecticut.Add(015, "Windham");

        }

        /// <summary>
        /// Populate Delaware with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateDelaware()
        {
            delaware.Add(001, "Kent");
            delaware.Add(003, "New Castle");
            delaware.Add(005, "Sussex");

        }

        /// <summary>
        /// Populate District of Columbia with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateDistrictOfColumbia()
        {
            districtOfColumbia.Add(001, "District of Columbia");
            districtOfColumbia.Add(031, "Montgomery");

        }

        /// <summary>
        /// Populate Florida with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateFlorida()
        {
            florida.Add(001, "Alachua");
            florida.Add(003, "Baker");
            florida.Add(005, "Bay");
            florida.Add(007, "Bradford");
            florida.Add(009, "Brevard");
            florida.Add(011, "Broward");
            florida.Add(013, "Calhoun");
            florida.Add(015, "Charlotte");
            florida.Add(017, "Citrus");
            florida.Add(019, "Clay");
            florida.Add(021, "Collier");
            florida.Add(023, "Columbia");
            florida.Add(027, "De Soto");
            florida.Add(029, "Dixie");
            florida.Add(031, "Duval");
            florida.Add(033, "Escambia");
            florida.Add(035, "Flagler");
            florida.Add(037, "Franklin");
            florida.Add(039, "Gadsden");
            florida.Add(041, "Gilchrist");
            florida.Add(043, "Glades");
            florida.Add(045, "Gulf");
            florida.Add(047, "Hamilton");
            florida.Add(049, "Hardee");
            florida.Add(051, "Hendry");
            florida.Add(053, "Hernando");
            florida.Add(055, "Highlands");
            florida.Add(057, "Hillsborough");
            florida.Add(059, "Holmes");
            florida.Add(061, "Indian River");
            florida.Add(063, "Jackson");
            florida.Add(065, "Jefferson");
            florida.Add(067, "Lafayette");
            florida.Add(069, "Lake");
            florida.Add(071, "Lee");
            florida.Add(073, "Leon");
            florida.Add(075, "Levy");
            florida.Add(077, "Liberty");
            florida.Add(079, "Madison");
            florida.Add(081, "Manatee");
            florida.Add(083, "Marion");
            florida.Add(085, "Martin");
            florida.Add(086, "Miami-Dade");
            florida.Add(087, "Monroe");
            florida.Add(089, "Nassau");
            florida.Add(091, "Okaloosa");
            florida.Add(093, "Okeechobee");
            florida.Add(095, "Orange");
            florida.Add(097, "Osceola");
            florida.Add(099, "Palm Beach");
            florida.Add(101, "Pasco");
            florida.Add(103, "Pinellas");
            florida.Add(105, "Polk");
            florida.Add(107, "Putnam");
            florida.Add(109, "St Johns");
            florida.Add(111, "St Lucie");
            florida.Add(113, "Santa Rosa");
            florida.Add(115, "Sarasota");
            florida.Add(117, "Seminole");
            florida.Add(119, "Sumter");
            florida.Add(121, "Suwannee");
            florida.Add(123, "Taylor");
            florida.Add(125, "Union");
            florida.Add(127, "Volusia");
            florida.Add(129, "Wakulla");
            florida.Add(131, "Walton");
            florida.Add(133, "Washington");

        }

        /// <summary>
        /// Populate Georgia with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateGeorgia()
        {
            georgia.Add(001, "Appling");
            georgia.Add(003, "Atkinson");
            georgia.Add(005, "Bacon");
            georgia.Add(007, "Baker");
            georgia.Add(009, "Baldwin");
            georgia.Add(011, "Banks");
            georgia.Add(013, "Barrow");
            georgia.Add(015, "Bartow");
            georgia.Add(017, "Ben Hill");
            georgia.Add(019, "Berrien");
            georgia.Add(021, "Bibb");
            georgia.Add(023, "Bleckley");
            georgia.Add(025, "Brantley");
            georgia.Add(027, "Brooks");
            georgia.Add(029, "Bryan");
            georgia.Add(031, "Bulloch");
            georgia.Add(033, "Burke");
            georgia.Add(035, "Butts");
            georgia.Add(037, "Calhoun");
            georgia.Add(039, "Camden");
            georgia.Add(043, "Candler");
            georgia.Add(045, "Carroll");
            georgia.Add(047, "Catoosa");
            georgia.Add(049, "Charlton");
            georgia.Add(051, "Chatham");
            georgia.Add(053, "Chattahoochee");
            georgia.Add(055, "Chattooga");
            georgia.Add(057, "Cherokee");
            georgia.Add(059, "Clarke");
            georgia.Add(061, "Clay");
            georgia.Add(063, "Clayton");
            georgia.Add(065, "Clinch");
            georgia.Add(067, "Cobb");
            georgia.Add(069, "Coffee");
            georgia.Add(071, "Colquitt");
            georgia.Add(073, "Columbia");
            georgia.Add(075, "Cook");
            georgia.Add(077, "Coweta");
            georgia.Add(079, "Crawford");
            georgia.Add(081, "Crisp");
            georgia.Add(083, "Dade");
            georgia.Add(085, "Dawson");
            georgia.Add(087, "Decatur");
            georgia.Add(089, "De Kalb");
            georgia.Add(091, "Dodge");
            georgia.Add(093, "Dooly");
            georgia.Add(095, "Dougherty");
            georgia.Add(097, "Douglas");
            georgia.Add(099, "Early");
            georgia.Add(101, "Echols");
            georgia.Add(103, "Effingham");
            georgia.Add(105, "Elbert");
            georgia.Add(107, "Emanuel");
            georgia.Add(109, "Evans");
            georgia.Add(111, "Fannin");
            georgia.Add(113, "Fayette");
            georgia.Add(115, "Floyd");
            georgia.Add(117, "Forsyth");
            georgia.Add(119, "Franklin");
            georgia.Add(121, "Fulton");
            georgia.Add(123, "Gilmer");
            georgia.Add(125, "Glascock");
            georgia.Add(127, "Glynn");
            georgia.Add(129, "Gordon");
            georgia.Add(131, "Grady");
            georgia.Add(133, "Greene");
            georgia.Add(135, "Gwinnett");
            georgia.Add(137, "Habersham");
            georgia.Add(139, "Hall");
            georgia.Add(141, "Hancock");
            georgia.Add(143, "Haralson");
            georgia.Add(145, "Harris");
            georgia.Add(147, "Hart");
            georgia.Add(149, "Heard");
            georgia.Add(151, "Henry");
            georgia.Add(153, "Houston");
            georgia.Add(155, "Irwin");
            georgia.Add(157, "Jackson");
            georgia.Add(159, "Jasper");
            georgia.Add(161, "Jeff Davis");
            georgia.Add(163, "Jefferson");
            georgia.Add(165, "Jenkins");
            georgia.Add(167, "Johnson");
            georgia.Add(169, "Jones");
            georgia.Add(171, "Lamar");
            georgia.Add(173, "Lanier");
            georgia.Add(175, "Laurens");
            georgia.Add(177, "Lee");
            georgia.Add(179, "Liberty");
            georgia.Add(181, "Lincoln");
            georgia.Add(183, "Long");
            georgia.Add(185, "Lowndes");
            georgia.Add(187, "Lumpkin");
            georgia.Add(189, "McDuffie");
            georgia.Add(191, "McIntosh");
            georgia.Add(193, "Macon");
            georgia.Add(195, "Madison");
            georgia.Add(197, "Marion");
            georgia.Add(199, "Meriwether");
            georgia.Add(201, "Miller");
            georgia.Add(205, "Mitchell");
            georgia.Add(207, "Monroe");
            georgia.Add(209, "Montgomery");
            georgia.Add(211, "Morgan");
            georgia.Add(213, "Murray");
            georgia.Add(215, "Muscogee");
            georgia.Add(217, "Newton");
            georgia.Add(219, "Oconee");
            georgia.Add(221, "Oglethorpe");
            georgia.Add(223, "Paulding");
            georgia.Add(225, "Peach");
            georgia.Add(227, "Pickens");
            georgia.Add(229, "Pierce");
            georgia.Add(231, "Pike");
            georgia.Add(233, "Polk");
            georgia.Add(235, "Pulaski");
            georgia.Add(237, "Putnam");
            georgia.Add(239, "Quitman");
            georgia.Add(241, "Rabun");
            georgia.Add(243, "Randolph");
            georgia.Add(245, "Richmond");
            georgia.Add(247, "Rockdale");
            georgia.Add(249, "Schley");
            georgia.Add(251, "Screven");
            georgia.Add(253, "Seminole");
            georgia.Add(255, "Spalding");
            georgia.Add(257, "Stephens");
            georgia.Add(259, "Stewart");
            georgia.Add(261, "Sumter");
            georgia.Add(263, "Talbot");
            georgia.Add(265, "Taliaferro");
            georgia.Add(267, "Tattnall");
            georgia.Add(269, "Taylor");
            georgia.Add(271, "Telfair");
            georgia.Add(273, "Terrell");
            georgia.Add(275, "Thomas");
            georgia.Add(277, "Tift");
            georgia.Add(279, "Toombs");
            georgia.Add(281, "Towns");
            georgia.Add(283, "Treutlen");
            georgia.Add(285, "Troup");
            georgia.Add(287, "Turner");
            georgia.Add(289, "Twiggs");
            georgia.Add(291, "Union");
            georgia.Add(293, "Upson");
            georgia.Add(295, "Walker");
            georgia.Add(297, "Walton");
            georgia.Add(299, "Ware");
            georgia.Add(301, "Warren");
            georgia.Add(303, "Washington");
            georgia.Add(305, "Wayne");
            georgia.Add(307, "Webster");
            georgia.Add(309, "Wheeler");
            georgia.Add(311, "White");
            georgia.Add(313, "Whitfield");
            georgia.Add(315, "Wilcox");
            georgia.Add(317, "Wilkes");
            georgia.Add(319, "Wilkinson");
            georgia.Add(321, "Worth");

        }

        /// <summary>
        /// Populate Hawaii with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateHawaii()
        {
            hawaii.Add(001, "Hawaii");
            hawaii.Add(003, "Honolulu");
            hawaii.Add(007, "Kauai");
            hawaii.Add(009, "Maui");

        }

        /// <summary>
        /// Populate Idaho with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateIdaho()
        {
            idaho.Add(001, "Ada");
            idaho.Add(003, "Adams");
            idaho.Add(005, "Bannock");
            idaho.Add(007, "Bear Lake");
            idaho.Add(009, "Benewah");
            idaho.Add(011, "Bingham");
            idaho.Add(013, "Blaine");
            idaho.Add(015, "Boise");
            idaho.Add(017, "Bonner");
            idaho.Add(019, "Bonneville");
            idaho.Add(021, "Boundary");
            idaho.Add(023, "Butte");
            idaho.Add(025, "Camas");
            idaho.Add(027, "Canyon");
            idaho.Add(029, "Caribou");
            idaho.Add(031, "Cassia");
            idaho.Add(033, "Clark");
            idaho.Add(035, "Clearwater");
            idaho.Add(037, "Custer");
            idaho.Add(039, "Elmore");
            idaho.Add(041, "Franklin");
            idaho.Add(043, "Fremont");
            idaho.Add(045, "Gem");
            idaho.Add(047, "Gooding");
            idaho.Add(049, "Idaho");
            idaho.Add(051, "Jefferson");
            idaho.Add(053, "Jerome");
            idaho.Add(055, "Kootenai");
            idaho.Add(057, "Latah");
            idaho.Add(059, "Lemhi");
            idaho.Add(061, "Lewis");
            idaho.Add(063, "Lincoln");
            idaho.Add(065, "Madison");
            idaho.Add(067, "Minidoka");
            idaho.Add(069, "Nez Perce");
            idaho.Add(071, "Oneida");
            idaho.Add(073, "Owyhee");
            idaho.Add(075, "Payette");
            idaho.Add(077, "Power");
            idaho.Add(079, "Shoshone");
            idaho.Add(081, "Teton");
            idaho.Add(083, "Twin Falls");
            idaho.Add(085, "Valley");
            idaho.Add(087, "Washington");

        }

        /// <summary>
        /// Populate Illinois with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateIllinois()
        {
            illinois.Add(001, "Adams");
            illinois.Add(003, "Alexander");
            illinois.Add(005, "Bond");
            illinois.Add(007, "Boone");
            illinois.Add(009, "Brown");
            illinois.Add(011, "Bureau");
            illinois.Add(013, "Calhoun");
            illinois.Add(015, "Carroll");
            illinois.Add(017, "Cass");
            illinois.Add(019, "Champaign");
            illinois.Add(021, "Christian");
            illinois.Add(023, "Clark");
            illinois.Add(025, "Clay");
            illinois.Add(027, "Clinton");
            illinois.Add(029, "Coles");
            illinois.Add(031, "Cook");
            illinois.Add(033, "Crawford");
            illinois.Add(035, "Cumberland");
            illinois.Add(037, "De Kalb");
            illinois.Add(039, "Dewitt");
            illinois.Add(041, "Douglas");
            illinois.Add(043, "Du Page");
            illinois.Add(045, "Edgar");
            illinois.Add(047, "Edwards");
            illinois.Add(049, "Effingham");
            illinois.Add(051, "Fayette");
            illinois.Add(053, "Ford");
            illinois.Add(055, "Franklin");
            illinois.Add(057, "Fulton");
            illinois.Add(059, "Gallatin");
            illinois.Add(061, "Greene");
            illinois.Add(063, "Grundy");
            illinois.Add(065, "Hamilton");
            illinois.Add(067, "Hancock");
            illinois.Add(069, "Hardin");
            illinois.Add(071, "Henderson");
            illinois.Add(073, "Henry");
            illinois.Add(075, "Iroquois");
            illinois.Add(077, "Jackson");
            illinois.Add(079, "Jasper");
            illinois.Add(081, "Jefferson");
            illinois.Add(083, "Jersey");
            illinois.Add(085, "Jo Daviess");
            illinois.Add(087, "Johnson");
            illinois.Add(089, "Kane");
            illinois.Add(091, "Kankakee");
            illinois.Add(093, "Kendall");
            illinois.Add(095, "Knox");
            illinois.Add(097, "Lake");
            illinois.Add(099, "La Salle");
            illinois.Add(101, "Lawrence");
            illinois.Add(103, "Lee");
            illinois.Add(105, "Livingston");
            illinois.Add(107, "Logan");
            illinois.Add(109, "McDonough");
            illinois.Add(111, "McHenry");
            illinois.Add(113, "Mclean");
            illinois.Add(115, "Macon");
            illinois.Add(117, "Macoupin");
            illinois.Add(119, "Madison");
            illinois.Add(121, "Marion");
            illinois.Add(123, "Marshall");
            illinois.Add(125, "Mason");
            illinois.Add(127, "Massac");
            illinois.Add(129, "Menard");
            illinois.Add(131, "Mercer");
            illinois.Add(133, "Monroe");
            illinois.Add(135, "Montgomery");
            illinois.Add(137, "Morgan");
            illinois.Add(139, "Moultrie");
            illinois.Add(141, "Ogle");
            illinois.Add(143, "Peoria");
            illinois.Add(145, "Perry");
            illinois.Add(147, "Piatt");
            illinois.Add(149, "Pike");
            illinois.Add(151, "Pope");
            illinois.Add(153, "Pulaski");
            illinois.Add(155, "Putnam");
            illinois.Add(157, "Randolph");
            illinois.Add(159, "Richland");
            illinois.Add(161, "Rock Island");
            illinois.Add(163, "St Clair");
            illinois.Add(165, "Saline");
            illinois.Add(167, "Sangamon");
            illinois.Add(169, "Schuyler");
            illinois.Add(171, "Scott");
            illinois.Add(173, "Shelby");
            illinois.Add(175, "Stark");
            illinois.Add(177, "Stephenson");
            illinois.Add(179, "Tazewell");
            illinois.Add(181, "Union");
            illinois.Add(183, "Vermilion");
            illinois.Add(185, "Wabash");
            illinois.Add(187, "Warren");
            illinois.Add(189, "Washington");
            illinois.Add(191, "Wayne");
            illinois.Add(193, "White");
            illinois.Add(195, "Whiteside");
            illinois.Add(197, "Will");
            illinois.Add(199, "Williamson");
            illinois.Add(201, "Winnebago");
            illinois.Add(203, "Woodford");

        }

        /// <summary>
        /// Populate Indiana with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateIndiana()
        {
            indiana.Add(001, "Adams");
            indiana.Add(003, "Allen");
            indiana.Add(005, "Bartholomew");
            indiana.Add(007, "Benton");
            indiana.Add(009, "Blackford");
            indiana.Add(011, "Boone");
            indiana.Add(013, "Brown");
            indiana.Add(015, "Carroll");
            indiana.Add(017, "Cass");
            indiana.Add(019, "Clark");
            indiana.Add(021, "Clay");
            indiana.Add(023, "Clinton");
            indiana.Add(025, "Crawford");
            indiana.Add(027, "Daviess");
            indiana.Add(029, "Dearborn");
            indiana.Add(031, "Decatur");
            indiana.Add(033, "De Kalb");
            indiana.Add(035, "Delaware");
            indiana.Add(037, "Dubois");
            indiana.Add(039, "Elkhart");
            indiana.Add(041, "Fayette");
            indiana.Add(043, "Floyd");
            indiana.Add(045, "Fountain");
            indiana.Add(047, "Franklin");
            indiana.Add(049, "Fulton");
            indiana.Add(051, "Gibson");
            indiana.Add(053, "Grant");
            indiana.Add(055, "Greene");
            indiana.Add(057, "Hamilton");
            indiana.Add(059, "Hancock");
            indiana.Add(061, "Harrison");
            indiana.Add(063, "Hendricks");
            indiana.Add(065, "Henry");
            indiana.Add(067, "Howard");
            indiana.Add(069, "Huntington");
            indiana.Add(071, "Jackson");
            indiana.Add(073, "Jasper");
            indiana.Add(075, "Jay");
            indiana.Add(077, "Jefferson");
            indiana.Add(079, "Jennings");
            indiana.Add(081, "Johnson");
            indiana.Add(083, "Knox");
            indiana.Add(085, "Kosciusko");
            indiana.Add(087, "Lagrange");
            indiana.Add(089, "Lake");
            indiana.Add(091, "La Porte");
            indiana.Add(093, "Lawrence");
            indiana.Add(095, "Madison");
            indiana.Add(097, "Marion");
            indiana.Add(099, "Marshall");
            indiana.Add(101, "Martin");
            indiana.Add(103, "Miami");
            indiana.Add(105, "Monroe");
            indiana.Add(107, "Montgomery");
            indiana.Add(109, "Morgan");
            indiana.Add(111, "Newton");
            indiana.Add(113, "Noble");
            indiana.Add(115, "Ohio");
            indiana.Add(117, "Orange");
            indiana.Add(119, "Owen");
            indiana.Add(121, "Parke");
            indiana.Add(123, "Perry");
            indiana.Add(125, "Pike");
            indiana.Add(127, "Porter");
            indiana.Add(129, "Posey");
            indiana.Add(131, "Pulaski");
            indiana.Add(133, "Putnam");
            indiana.Add(135, "Randolph");
            indiana.Add(137, "Ripley");
            indiana.Add(139, "Rush");
            indiana.Add(141, "St Joseph");
            indiana.Add(143, "Scott");
            indiana.Add(145, "Shelby");
            indiana.Add(147, "Spencer");
            indiana.Add(149, "Starke");
            indiana.Add(151, "Steuben");
            indiana.Add(153, "Sullivan");
            indiana.Add(155, "Switzerland");
            indiana.Add(157, "Tippecanoe");
            indiana.Add(159, "Tipton");
            indiana.Add(161, "Union");
            indiana.Add(163, "Vanderburgh");
            indiana.Add(165, "Vermillion");
            indiana.Add(167, "Vigo");
            indiana.Add(169, "Wabash");
            indiana.Add(171, "Warren");
            indiana.Add(173, "Warrick");
            indiana.Add(175, "Washington");
            indiana.Add(177, "Wayne");
            indiana.Add(179, "Wells");
            indiana.Add(181, "White");
            indiana.Add(183, "Whitley");

        }

        /// <summary>
        /// Populate Iowa with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateIowa()
        {
            iowa.Add(001, "Adair");
            iowa.Add(003, "Adams");
            iowa.Add(005, "Allamakee");
            iowa.Add(007, "Appanoose");
            iowa.Add(009, "Audubon");
            iowa.Add(011, "Benton");
            iowa.Add(013, "Black Hawk");
            iowa.Add(015, "Boone");
            iowa.Add(017, "Bremer");
            iowa.Add(019, "Buchanan");
            iowa.Add(021, "Buena Vista");
            iowa.Add(023, "Butler");
            iowa.Add(025, "Calhoun");
            iowa.Add(027, "Carroll");
            iowa.Add(029, "Cass");
            iowa.Add(031, "Cedar");
            iowa.Add(033, "Cerro Gordo");
            iowa.Add(035, "Cherokee");
            iowa.Add(037, "Chickasaw");
            iowa.Add(039, "Clarke");
            iowa.Add(041, "Clay");
            iowa.Add(043, "Clayton");
            iowa.Add(045, "Clinton");
            iowa.Add(047, "Crawford");
            iowa.Add(049, "Dallas");
            iowa.Add(051, "Davis");
            iowa.Add(053, "Decatur");
            iowa.Add(055, "Delaware");
            iowa.Add(057, "Des Moines");
            iowa.Add(059, "Dickinson");
            iowa.Add(061, "Dubuque");
            iowa.Add(063, "Emmet");
            iowa.Add(065, "Fayette");
            iowa.Add(067, "Floyd");
            iowa.Add(069, "Franklin");
            iowa.Add(071, "Fremont");
            iowa.Add(073, "Greene");
            iowa.Add(075, "Grundy");
            iowa.Add(077, "Guthrie");
            iowa.Add(079, "Hamilton");
            iowa.Add(081, "Hancock");
            iowa.Add(083, "Hardin");
            iowa.Add(085, "Harrison");
            iowa.Add(087, "Henry");
            iowa.Add(089, "Howard");
            iowa.Add(091, "Humboldt");
            iowa.Add(093, "Ida");
            iowa.Add(095, "Iowa");
            iowa.Add(097, "Jackson");
            iowa.Add(099, "Jasper");
            iowa.Add(101, "Jefferson");
            iowa.Add(103, "Johnson");
            iowa.Add(105, "Jones");
            iowa.Add(107, "Keokuk");
            iowa.Add(109, "Kossuth");
            iowa.Add(111, "Lee");
            iowa.Add(113, "Linn");
            iowa.Add(115, "Louisa");
            iowa.Add(117, "Lucas");
            iowa.Add(119, "Lyon");
            iowa.Add(121, "Madison");
            iowa.Add(123, "Mahaska");
            iowa.Add(125, "Marion");
            iowa.Add(127, "Marshall");
            iowa.Add(129, "Mills");
            iowa.Add(131, "Mitchell");
            iowa.Add(133, "Monona");
            iowa.Add(135, "Monroe");
            iowa.Add(137, "Montgomery");
            iowa.Add(139, "Muscatine");
            iowa.Add(141, "Obrien");
            iowa.Add(143, "Osceola");
            iowa.Add(145, "Page");
            iowa.Add(147, "Palo Alto");
            iowa.Add(149, "Plymouth");
            iowa.Add(151, "Pocahontas");
            iowa.Add(153, "Polk");
            iowa.Add(155, "Pottawattamie");
            iowa.Add(157, "Poweshiek");
            iowa.Add(159, "Ringgold");
            iowa.Add(161, "Sac");
            iowa.Add(163, "Scott");
            iowa.Add(165, "Shelby");
            iowa.Add(167, "Sioux");
            iowa.Add(169, "Story");
            iowa.Add(171, "Tama");
            iowa.Add(173, "Taylor");
            iowa.Add(175, "Union");
            iowa.Add(177, "Van Buren");
            iowa.Add(179, "Wapello");
            iowa.Add(181, "Warren");
            iowa.Add(183, "Washington");
            iowa.Add(185, "Wayne");
            iowa.Add(187, "Webster");
            iowa.Add(189, "Winnebago");
            iowa.Add(191, "Winneshiek");
            iowa.Add(193, "Woodbury");
            iowa.Add(195, "Worth");
            iowa.Add(197, "Wright");

        }

        /// <summary>
        /// Populate Kansas with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateKansas()
        {
            kansas.Add(001, "Allen");
            kansas.Add(003, "Anderson");
            kansas.Add(005, "Atchison");
            kansas.Add(007, "Barber");
            kansas.Add(009, "Barton");
            kansas.Add(011, "Bourbon");
            kansas.Add(013, "Brown");
            kansas.Add(015, "Butler");
            kansas.Add(017, "Chase");
            kansas.Add(019, "Chautauqua");
            kansas.Add(021, "Cherokee");
            kansas.Add(023, "Cheyenne");
            kansas.Add(025, "Clark");
            kansas.Add(027, "Clay");
            kansas.Add(029, "Cloud");
            kansas.Add(031, "Coffey");
            kansas.Add(033, "Comanche");
            kansas.Add(035, "Cowley");
            kansas.Add(037, "Crawford");
            kansas.Add(039, "Decatur");
            kansas.Add(041, "Dickinson");
            kansas.Add(043, "Doniphan");
            kansas.Add(045, "Douglas");
            kansas.Add(047, "Edwards");
            kansas.Add(049, "Elk");
            kansas.Add(051, "Ellis");
            kansas.Add(053, "Ellsworth");
            kansas.Add(055, "Finney");
            kansas.Add(057, "Ford");
            kansas.Add(059, "Franklin");
            kansas.Add(061, "Geary");
            kansas.Add(063, "Gove");
            kansas.Add(065, "Graham");
            kansas.Add(067, "Grant");
            kansas.Add(069, "Gray");
            kansas.Add(071, "Greeley");
            kansas.Add(073, "Greenwood");
            kansas.Add(075, "Hamilton");
            kansas.Add(077, "Harper");
            kansas.Add(079, "Harvey");
            kansas.Add(081, "Haskell");
            kansas.Add(083, "Hodgeman");
            kansas.Add(085, "Jackson");
            kansas.Add(087, "Jefferson");
            kansas.Add(089, "Jewell");
            kansas.Add(091, "Johnson");
            kansas.Add(093, "Kearny");
            kansas.Add(095, "Kingman");
            kansas.Add(097, "Kiowa");
            kansas.Add(099, "Labette");
            kansas.Add(101, "Lane");
            kansas.Add(103, "Leavenworth");
            kansas.Add(105, "Lincoln");
            kansas.Add(107, "Linn");
            kansas.Add(109, "Logan");
            kansas.Add(111, "Lyon");
            kansas.Add(113, "McPherson");
            kansas.Add(115, "Marion");
            kansas.Add(117, "Marshall");
            kansas.Add(119, "Meade");
            kansas.Add(121, "Miami");
            kansas.Add(123, "Mitchell");
            kansas.Add(125, "Montgomery");
            kansas.Add(127, "Morris");
            kansas.Add(129, "Morton");
            kansas.Add(131, "Nemaha");
            kansas.Add(133, "Neosho");
            kansas.Add(135, "Ness");
            kansas.Add(137, "Norton");
            kansas.Add(139, "Osage");
            kansas.Add(141, "Osborne");
            kansas.Add(143, "Ottawa");
            kansas.Add(145, "Pawnee");
            kansas.Add(147, "Phillips");
            kansas.Add(149, "Pottawatomie");
            kansas.Add(151, "Pratt");
            kansas.Add(153, "Rawlins");
            kansas.Add(155, "Reno");
            kansas.Add(157, "Republic");
            kansas.Add(159, "Rice");
            kansas.Add(161, "Riley");
            kansas.Add(163, "Rooks");
            kansas.Add(165, "Rush");
            kansas.Add(167, "Russell");
            kansas.Add(169, "Saline");
            kansas.Add(171, "Scott");
            kansas.Add(173, "Sedgwick");
            kansas.Add(175, "Seward");
            kansas.Add(177, "Shawnee");
            kansas.Add(179, "Sheridan");
            kansas.Add(181, "Sherman");
            kansas.Add(183, "Smith");
            kansas.Add(185, "Stafford");
            kansas.Add(187, "Stanton");
            kansas.Add(189, "Stevens");
            kansas.Add(191, "Sumner");
            kansas.Add(193, "Thomas");
            kansas.Add(195, "Trego");
            kansas.Add(197, "Wabaunsee");
            kansas.Add(199, "Wallace");
            kansas.Add(201, "Washington");
            kansas.Add(203, "Wichita");
            kansas.Add(205, "Wilson");
            kansas.Add(207, "Woodson");
            kansas.Add(209, "Wyandotte");

        }

        /// <summary>
        /// Populate Kentucky with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateKentucky()
        {
            kentucky.Add(001, "Adair");
            kentucky.Add(003, "Allen");
            kentucky.Add(005, "Anderson");
            kentucky.Add(007, "Ballard");
            kentucky.Add(009, "Barren");
            kentucky.Add(011, "Bath");
            kentucky.Add(013, "Bell");
            kentucky.Add(015, "Boone");
            kentucky.Add(017, "Bourbon");
            kentucky.Add(019, "Boyd");
            kentucky.Add(021, "Boyle");
            kentucky.Add(023, "Bracken");
            kentucky.Add(025, "Breathitt");
            kentucky.Add(027, "Breckinridge");
            kentucky.Add(029, "Bullitt");
            kentucky.Add(031, "Butler");
            kentucky.Add(033, "Caldwell");
            kentucky.Add(035, "Calloway");
            kentucky.Add(037, "Campbell");
            kentucky.Add(039, "Carlisle");
            kentucky.Add(041, "Carroll");
            kentucky.Add(043, "Carter");
            kentucky.Add(045, "Casey");
            kentucky.Add(047, "Christian");
            kentucky.Add(049, "Clark");
            kentucky.Add(051, "Clay");
            kentucky.Add(053, "Clinton");
            kentucky.Add(055, "Crittenden");
            kentucky.Add(057, "Cumberland");
            kentucky.Add(059, "Daviess");
            kentucky.Add(061, "Edmonson");
            kentucky.Add(063, "Elliott");
            kentucky.Add(065, "Estill");
            kentucky.Add(067, "Fayette");
            kentucky.Add(069, "Fleming");
            kentucky.Add(071, "Floyd");
            kentucky.Add(073, "Franklin");
            kentucky.Add(075, "Fulton");
            kentucky.Add(077, "Gallatin");
            kentucky.Add(079, "Garrard");
            kentucky.Add(081, "Grant");
            kentucky.Add(083, "Graves");
            kentucky.Add(085, "Grayson");
            kentucky.Add(087, "Green");
            kentucky.Add(089, "Greenup");
            kentucky.Add(091, "Hancock");
            kentucky.Add(093, "Hardin");
            kentucky.Add(095, "Harlan");
            kentucky.Add(097, "Harrison");
            kentucky.Add(099, "Hart");
            kentucky.Add(101, "Henderson");
            kentucky.Add(103, "Henry");
            kentucky.Add(105, "Hickman");
            kentucky.Add(107, "Hopkins");
            kentucky.Add(109, "Jackson");
            kentucky.Add(111, "Jefferson");
            kentucky.Add(113, "Jessamine");
            kentucky.Add(115, "Johnson");
            kentucky.Add(117, "Kenton");
            kentucky.Add(119, "Knott");
            kentucky.Add(121, "Knox");
            kentucky.Add(123, "Larue");
            kentucky.Add(125, "Laurel");
            kentucky.Add(127, "Lawrence");
            kentucky.Add(129, "Lee");
            kentucky.Add(131, "Leslie");
            kentucky.Add(133, "Letcher");
            kentucky.Add(135, "Lewis");
            kentucky.Add(137, "Lincoln");
            kentucky.Add(139, "Livingston");
            kentucky.Add(141, "Logan");
            kentucky.Add(143, "Lyon");
            kentucky.Add(145, "McCracken");
            kentucky.Add(147, "McCreary");
            kentucky.Add(149, "Mclean");
            kentucky.Add(151, "Madison");
            kentucky.Add(153, "Magoffin");
            kentucky.Add(155, "Marion");
            kentucky.Add(157, "Marshall");
            kentucky.Add(159, "Martin");
            kentucky.Add(161, "Mason");
            kentucky.Add(163, "Meade");
            kentucky.Add(165, "Menifee");
            kentucky.Add(167, "Mercer");
            kentucky.Add(169, "Metcalfe");
            kentucky.Add(171, "Monroe");
            kentucky.Add(173, "Montgomery");
            kentucky.Add(175, "Morgan");
            kentucky.Add(177, "Muhlenberg");
            kentucky.Add(179, "Nelson");
            kentucky.Add(181, "Nicholas");
            kentucky.Add(183, "Ohio");
            kentucky.Add(185, "Oldham");
            kentucky.Add(187, "Owen");
            kentucky.Add(189, "Owsley");
            kentucky.Add(191, "Pendleton");
            kentucky.Add(193, "Perry");
            kentucky.Add(195, "Pike");
            kentucky.Add(197, "Powell");
            kentucky.Add(199, "Pulaski");
            kentucky.Add(201, "Robertson");
            kentucky.Add(203, "Rockcastle");
            kentucky.Add(205, "Rowan");
            kentucky.Add(207, "Russell");
            kentucky.Add(209, "Scott");
            kentucky.Add(211, "Shelby");
            kentucky.Add(213, "Simpson");
            kentucky.Add(215, "Spencer");
            kentucky.Add(217, "Taylor");
            kentucky.Add(219, "Todd");
            kentucky.Add(221, "Trigg");
            kentucky.Add(223, "Trimble");
            kentucky.Add(225, "Union");
            kentucky.Add(227, "Warren");
            kentucky.Add(229, "Washington");
            kentucky.Add(231, "Wayne");
            kentucky.Add(233, "Webster");
            kentucky.Add(235, "Whitley");
            kentucky.Add(237, "Wolfe");
            kentucky.Add(239, "Woodford");

        }

        /// <summary>
        /// Populate Louisiana with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateLouisiana()
        {
            louisiana.Add(001, "Acadia");
            louisiana.Add(003, "Allen");
            louisiana.Add(005, "Ascension");
            louisiana.Add(007, "Assumption");
            louisiana.Add(009, "Avoyelles");
            louisiana.Add(011, "Beauregard");
            louisiana.Add(013, "Bienville");
            louisiana.Add(015, "Bossier");
            louisiana.Add(017, "Caddo");
            louisiana.Add(019, "Calcasieu");
            louisiana.Add(021, "Caldwell");
            louisiana.Add(023, "Cameron");
            louisiana.Add(025, "Catahoula");
            louisiana.Add(027, "Claiborne");
            louisiana.Add(029, "Concordia");
            louisiana.Add(031, "De Soto");
            louisiana.Add(033, "East Baton Rouge");
            louisiana.Add(035, "East Carroll");
            louisiana.Add(037, "East Feliciana");
            louisiana.Add(039, "Evangeline");
            louisiana.Add(041, "Franklin");
            louisiana.Add(043, "Grant");
            louisiana.Add(045, "Iberia");
            louisiana.Add(047, "Iberville");
            louisiana.Add(049, "Jackson");
            louisiana.Add(051, "Jefferson");
            louisiana.Add(053, "Jefferson Davis");
            louisiana.Add(055, "Lafayette");
            louisiana.Add(057, "Lafourche");
            louisiana.Add(059, "La Salle");
            louisiana.Add(061, "Lincoln");
            louisiana.Add(063, "Livingston");
            louisiana.Add(065, "Madison");
            louisiana.Add(067, "Morehouse");
            louisiana.Add(069, "Natchitoches");
            louisiana.Add(071, "Orleans");
            louisiana.Add(073, "Ouachita");
            louisiana.Add(075, "Plaquemines");
            louisiana.Add(077, "Pointe Coupee");
            louisiana.Add(079, "Rapides");
            louisiana.Add(081, "Red River");
            louisiana.Add(083, "Richland");
            louisiana.Add(085, "Sabine");
            louisiana.Add(087, "St Bernard");
            louisiana.Add(089, "St Charles");
            louisiana.Add(091, "St Helena");
            louisiana.Add(093, "St James");
            louisiana.Add(095, "St John The Baptist");
            louisiana.Add(097, "St Landry");
            louisiana.Add(099, "St Martin");
            louisiana.Add(101, "St Mary");
            louisiana.Add(103, "St Tammany");
            louisiana.Add(105, "Tangipahoa");
            louisiana.Add(107, "Tensas");
            louisiana.Add(109, "Terrebonne");
            louisiana.Add(111, "Union");
            louisiana.Add(113, "Vermilion");
            louisiana.Add(115, "Vernon");
            louisiana.Add(117, "Washington");
            louisiana.Add(119, "Webster");
            louisiana.Add(121, "West Baton Rouge");
            louisiana.Add(123, "West Carroll");
            louisiana.Add(125, "West Feliciana");
            louisiana.Add(127, "Winn");

        }

        /// <summary>
        /// Populate Maine with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMaine()
        {
            maine.Add(001, "Androscoggin");
            maine.Add(003, "Aroostook");
            maine.Add(005, "Cumberland");
            maine.Add(007, "Franklin");
            maine.Add(009, "Hancock");
            maine.Add(011, "Kennebec");
            maine.Add(013, "Knox");
            maine.Add(015, "Lincoln");
            maine.Add(017, "Oxford");
            maine.Add(019, "Penobscot");
            maine.Add(021, "Piscataquis");
            maine.Add(023, "Sagadahoc");
            maine.Add(025, "Somerset");
            maine.Add(027, "Waldo");
            maine.Add(029, "Washington");
            maine.Add(031, "York");

        }

        /// <summary>
        /// Populate Maryland with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMaryland()
        {
            maryland.Add(001, "Allegany");
            maryland.Add(003, "Anne Arundel");
            maryland.Add(005, "Baltimore");
            maryland.Add(009, "Calvert");
            maryland.Add(011, "Caroline");
            maryland.Add(013, "Carroll");
            maryland.Add(015, "Cecil");
            maryland.Add(017, "Charles");
            maryland.Add(019, "Dorchester");
            maryland.Add(021, "Frederick");
            maryland.Add(023, "Garrett");
            maryland.Add(025, "Harford");
            maryland.Add(027, "Howard");
            maryland.Add(029, "Kent");
            maryland.Add(031, "Montgomery");
            maryland.Add(033, "Prince Georges");
            maryland.Add(035, "Queen Annes");
            maryland.Add(037, "St Marys");
            maryland.Add(039, "Somerset");
            maryland.Add(041, "Talbot");
            maryland.Add(043, "Washington");
            maryland.Add(045, "Wicomico");
            maryland.Add(047, "Worcester");
            maryland.Add(510, "Baltimore City");

        }

        /// <summary>
        /// Populate Massachusetts with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMassachusetts()
        {
            massachusetts.Add(001, "Barnstable");
            massachusetts.Add(003, "Berkshire");
            massachusetts.Add(005, "Bristol");
            massachusetts.Add(007, "Dukes");
            massachusetts.Add(009, "Essex");
            massachusetts.Add(011, "Franklin");
            massachusetts.Add(013, "Hampden");
            massachusetts.Add(015, "Hampshire");
            massachusetts.Add(017, "Middlesex");
            massachusetts.Add(019, "Nantucket");
            massachusetts.Add(021, "Norfolk");
            massachusetts.Add(023, "Plymouth");
            massachusetts.Add(025, "Suffolk");
            massachusetts.Add(027, "Worcester");

        }

        /// <summary>
        /// Populate Michigan with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMichigan()
        {
            michigan.Add(001, "Alcona");
            michigan.Add(003, "Alger");
            michigan.Add(005, "Allegan");
            michigan.Add(007, "Alpena");
            michigan.Add(009, "Antrim");
            michigan.Add(011, "Arenac");
            michigan.Add(013, "Baraga");
            michigan.Add(015, "Barry");
            michigan.Add(017, "Bay");
            michigan.Add(019, "Benzie");
            michigan.Add(021, "Berrien");
            michigan.Add(023, "Branch");
            michigan.Add(025, "Calhoun");
            michigan.Add(027, "Cass");
            michigan.Add(029, "Charlevoix");
            michigan.Add(031, "Cheboygan");
            michigan.Add(033, "Chippewa");
            michigan.Add(035, "Clare");
            michigan.Add(037, "Clinton");
            michigan.Add(039, "Crawford");
            michigan.Add(041, "Delta");
            michigan.Add(043, "Dickinson");
            michigan.Add(045, "Eaton");
            michigan.Add(047, "Emmet");
            michigan.Add(049, "Genesee");
            michigan.Add(051, "Gladwin");
            michigan.Add(053, "Gogebic");
            michigan.Add(055, "Grand Traverse");
            michigan.Add(057, "Gratiot");
            michigan.Add(059, "Hillsdale");
            michigan.Add(061, "Houghton");
            michigan.Add(063, "Huron");
            michigan.Add(065, "Ingham");
            michigan.Add(067, "Ionia");
            michigan.Add(069, "Iosco");
            michigan.Add(071, "Iron");
            michigan.Add(073, "Isabella");
            michigan.Add(075, "Jackson");
            michigan.Add(077, "Kalamazoo");
            michigan.Add(079, "Kalkaska");
            michigan.Add(081, "Kent");
            michigan.Add(083, "Keweenaw");
            michigan.Add(085, "Lake");
            michigan.Add(087, "Lapeer");
            michigan.Add(089, "Leelanau");
            michigan.Add(091, "Lenawee");
            michigan.Add(093, "Livingston");
            michigan.Add(095, "Luce");
            michigan.Add(097, "Mackinac");
            michigan.Add(099, "Macomb");
            michigan.Add(101, "Manistee");
            michigan.Add(103, "Marquette");
            michigan.Add(105, "Mason");
            michigan.Add(107, "Mecosta");
            michigan.Add(109, "Menominee");
            michigan.Add(111, "Midland");
            michigan.Add(113, "Missaukee");
            michigan.Add(115, "Monroe");
            michigan.Add(117, "Montcalm");
            michigan.Add(119, "Montmorency");
            michigan.Add(121, "Muskegon");
            michigan.Add(123, "Newaygo");
            michigan.Add(125, "Oakland");
            michigan.Add(127, "Oceana");
            michigan.Add(129, "Ogemaw");
            michigan.Add(131, "Ontonagon");
            michigan.Add(133, "Osceola");
            michigan.Add(135, "Oscoda");
            michigan.Add(137, "Otsego");
            michigan.Add(139, "Ottawa");
            michigan.Add(141, "Presque Isle");
            michigan.Add(143, "Roscommon");
            michigan.Add(145, "Saginaw");
            michigan.Add(147, "St Clair");
            michigan.Add(149, "St Joseph");
            michigan.Add(151, "Sanilac");
            michigan.Add(153, "Schoolcraft");
            michigan.Add(155, "Shiawassee");
            michigan.Add(157, "Tuscola");
            michigan.Add(159, "Van Buren");
            michigan.Add(161, "Washtenaw");
            michigan.Add(163, "Wayne");
            michigan.Add(165, "Wexford");

        }

        /// <summary>
        /// Populate Minnesota with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMinnesota()
        {
            minnesota.Add(001, "Aitkin");
            minnesota.Add(003, "Anoka");
            minnesota.Add(005, "Becker");
            minnesota.Add(007, "Beltrami");
            minnesota.Add(009, "Benton");
            minnesota.Add(011, "Big Stone");
            minnesota.Add(013, "Blue Earth");
            minnesota.Add(015, "Brown");
            minnesota.Add(017, "Carlton");
            minnesota.Add(019, "Carver");
            minnesota.Add(021, "Cass");
            minnesota.Add(023, "Chippewa");
            minnesota.Add(025, "Chisago");
            minnesota.Add(027, "Clay");
            minnesota.Add(029, "Clearwater");
            minnesota.Add(031, "Cook");
            minnesota.Add(033, "Cottonwood");
            minnesota.Add(035, "Crow Wing");
            minnesota.Add(037, "Dakota");
            minnesota.Add(039, "Dodge");
            minnesota.Add(041, "Douglas");
            minnesota.Add(043, "Faribault");
            minnesota.Add(045, "Fillmore");
            minnesota.Add(047, "Freeborn");
            minnesota.Add(049, "Goodhue");
            minnesota.Add(051, "Grant");
            minnesota.Add(053, "Hennepin");
            minnesota.Add(055, "Houston");
            minnesota.Add(057, "Hubbard");
            minnesota.Add(059, "Isanti");
            minnesota.Add(061, "Itasca");
            minnesota.Add(063, "Jackson");
            minnesota.Add(065, "Kanabec");
            minnesota.Add(067, "Kandiyohi");
            minnesota.Add(069, "Kittson");
            minnesota.Add(071, "Koochiching");
            minnesota.Add(073, "Lac Qui Parle");
            minnesota.Add(075, "Lake");
            minnesota.Add(077, "Lake of The Woods");
            minnesota.Add(079, "Le Sueur");
            minnesota.Add(081, "Lincoln");
            minnesota.Add(083, "Lyon");
            minnesota.Add(085, "McLeod");
            minnesota.Add(087, "Mahnomen");
            minnesota.Add(089, "Marshall");
            minnesota.Add(091, "Martin");
            minnesota.Add(093, "Meeker");
            minnesota.Add(095, "Mille Lacs");
            minnesota.Add(097, "Morrison");
            minnesota.Add(099, "Mower");
            minnesota.Add(101, "Murray");
            minnesota.Add(103, "Nicollet");
            minnesota.Add(105, "Nobles");
            minnesota.Add(107, "Norman");
            minnesota.Add(109, "Olmsted");
            minnesota.Add(111, "Otter Tail");
            minnesota.Add(113, "Pennington");
            minnesota.Add(115, "Pine");
            minnesota.Add(117, "Pipestone");
            minnesota.Add(119, "Polk");
            minnesota.Add(121, "Pope");
            minnesota.Add(123, "Ramsey");
            minnesota.Add(125, "Red Lake");
            minnesota.Add(127, "Redwood");
            minnesota.Add(129, "Renville");
            minnesota.Add(131, "Rice");
            minnesota.Add(133, "Rock");
            minnesota.Add(135, "Roseau");
            minnesota.Add(137, "St Louis");
            minnesota.Add(139, "Scott");
            minnesota.Add(141, "Sherburne");
            minnesota.Add(143, "Sibley");
            minnesota.Add(145, "Stearns");
            minnesota.Add(147, "Steele");
            minnesota.Add(149, "Stevens");
            minnesota.Add(151, "Swift");
            minnesota.Add(153, "Todd");
            minnesota.Add(155, "Traverse");
            minnesota.Add(157, "Wabasha");
            minnesota.Add(159, "Wadena");
            minnesota.Add(161, "Waseca");
            minnesota.Add(163, "Washington");
            minnesota.Add(165, "Watonwan");
            minnesota.Add(167, "Wilkin");
            minnesota.Add(169, "Winona");
            minnesota.Add(171, "Wright");
            minnesota.Add(173, "Yellow Medicine");

        }

        /// <summary>
        /// Populate Mississippi with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMississippi()
        {
            mississippi.Add(001, "Adams");
            mississippi.Add(003, "Alcorn");
            mississippi.Add(005, "Amite");
            mississippi.Add(007, "Attala");
            mississippi.Add(009, "Benton");
            mississippi.Add(011, "Bolivar");
            mississippi.Add(013, "Calhoun");
            mississippi.Add(015, "Carroll");
            mississippi.Add(017, "Chickasaw");
            mississippi.Add(019, "Choctaw");
            mississippi.Add(021, "Claiborne");
            mississippi.Add(023, "Clarke");
            mississippi.Add(025, "Clay");
            mississippi.Add(027, "Coahoma");
            mississippi.Add(029, "Copiah");
            mississippi.Add(031, "Covington");
            mississippi.Add(033, "De Soto");
            mississippi.Add(035, "Forrest");
            mississippi.Add(037, "Franklin");
            mississippi.Add(039, "George");
            mississippi.Add(041, "Greene");
            mississippi.Add(043, "Grenada");
            mississippi.Add(045, "Hancock");
            mississippi.Add(047, "Harrison");
            mississippi.Add(049, "Hinds");
            mississippi.Add(051, "Holmes");
            mississippi.Add(053, "Humphreys");
            mississippi.Add(055, "Issaquena");
            mississippi.Add(057, "Itawamba");
            mississippi.Add(059, "Jackson");
            mississippi.Add(061, "Jasper");
            mississippi.Add(063, "Jefferson");
            mississippi.Add(065, "Jefferson Davis");
            mississippi.Add(067, "Jones");
            mississippi.Add(069, "Kemper");
            mississippi.Add(071, "Lafayette");
            mississippi.Add(073, "Lamar");
            mississippi.Add(075, "Lauderdale");
            mississippi.Add(077, "Lawrence");
            mississippi.Add(079, "Leake");
            mississippi.Add(081, "Lee");
            mississippi.Add(083, "Leflore");
            mississippi.Add(085, "Lincoln");
            mississippi.Add(087, "Lowndes");
            mississippi.Add(089, "Madison");
            mississippi.Add(091, "Marion");
            mississippi.Add(093, "Marshall");
            mississippi.Add(095, "Monroe");
            mississippi.Add(097, "Montgomery");
            mississippi.Add(099, "Neshoba");
            mississippi.Add(101, "Newton");
            mississippi.Add(103, "Noxubee");
            mississippi.Add(105, "Oktibbeha");
            mississippi.Add(107, "Panola");
            mississippi.Add(109, "Pearl River");
            mississippi.Add(111, "Perry");
            mississippi.Add(113, "Pike");
            mississippi.Add(115, "Pontotoc");
            mississippi.Add(117, "Prentiss");
            mississippi.Add(119, "Quitman");
            mississippi.Add(121, "Rankin");
            mississippi.Add(123, "Scott");
            mississippi.Add(125, "Sharkey");
            mississippi.Add(127, "Simpson");
            mississippi.Add(129, "Smith");
            mississippi.Add(131, "Stone");
            mississippi.Add(133, "Sunflower");
            mississippi.Add(135, "Tallahatchie");
            mississippi.Add(137, "Tate");
            mississippi.Add(139, "Tippah");
            mississippi.Add(141, "Tishomingo");
            mississippi.Add(143, "Tunica");
            mississippi.Add(145, "Union");
            mississippi.Add(147, "Walthall");
            mississippi.Add(149, "Warren");
            mississippi.Add(151, "Washington");
            mississippi.Add(153, "Wayne");
            mississippi.Add(155, "Webster");
            mississippi.Add(157, "Wilkinson");
            mississippi.Add(159, "Winston");
            mississippi.Add(161, "Yalobusha");
            mississippi.Add(163, "Yazoo");

        }

        /// <summary>
        /// Populate Missouri with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMissouri()
        {
            missouri.Add(001, "Adair");
            missouri.Add(003, "Andrew");
            missouri.Add(005, "Atchison");
            missouri.Add(007, "Audrain");
            missouri.Add(009, "Barry");
            missouri.Add(011, "Barton");
            missouri.Add(013, "Bates");
            missouri.Add(015, "Benton");
            missouri.Add(017, "Bollinger");
            missouri.Add(019, "Boone");
            missouri.Add(021, "Buchanan");
            missouri.Add(023, "Butler");
            missouri.Add(025, "Caldwell");
            missouri.Add(027, "Callaway");
            missouri.Add(029, "Camden");
            missouri.Add(031, "Cape Girardeau");
            missouri.Add(033, "Carroll");
            missouri.Add(035, "Carter");
            missouri.Add(037, "Cass");
            missouri.Add(039, "Cedar");
            missouri.Add(041, "Chariton");
            missouri.Add(043, "Christian");
            missouri.Add(045, "Clark");
            missouri.Add(047, "Clay");
            missouri.Add(049, "Clinton");
            missouri.Add(051, "Cole");
            missouri.Add(053, "Cooper");
            missouri.Add(055, "Crawford");
            missouri.Add(057, "Dade");
            missouri.Add(059, "Dallas");
            missouri.Add(061, "Daviess");
            missouri.Add(063, "Dekalb");
            missouri.Add(065, "Dent");
            missouri.Add(067, "Douglas");
            missouri.Add(069, "Dunklin");
            missouri.Add(071, "Franklin");
            missouri.Add(073, "Gasconade");
            missouri.Add(075, "Gentry");
            missouri.Add(077, "Greene");
            missouri.Add(079, "Grundy");
            missouri.Add(081, "Harrison");
            missouri.Add(083, "Henry");
            missouri.Add(085, "Hickory");
            missouri.Add(087, "Holt");
            missouri.Add(089, "Howard");
            missouri.Add(091, "Howell");
            missouri.Add(093, "Iron");
            missouri.Add(095, "Jackson");
            missouri.Add(097, "Jasper");
            missouri.Add(099, "Jefferson");
            missouri.Add(101, "Johnson");
            missouri.Add(103, "Knox");
            missouri.Add(105, "Laclede");
            missouri.Add(107, "Lafayette");
            missouri.Add(109, "Lawrence");
            missouri.Add(111, "Lewis");
            missouri.Add(113, "Lincoln");
            missouri.Add(115, "Linn");
            missouri.Add(117, "Livingston");
            missouri.Add(119, "Mcdonald");
            missouri.Add(121, "Macon");
            missouri.Add(123, "Madison");
            missouri.Add(125, "Maries");
            missouri.Add(127, "Marion");
            missouri.Add(129, "Mercer");
            missouri.Add(131, "Miller");
            missouri.Add(133, "Mississippi");
            missouri.Add(135, "Moniteau");
            missouri.Add(137, "Monroe");
            missouri.Add(139, "Montgomery");
            missouri.Add(141, "Morgan");
            missouri.Add(143, "New Madrid");
            missouri.Add(145, "Newton");
            missouri.Add(147, "Nodaway");
            missouri.Add(149, "Oregon");
            missouri.Add(151, "Osage");
            missouri.Add(153, "Ozark");
            missouri.Add(155, "Pemiscot");
            missouri.Add(157, "Perry");
            missouri.Add(159, "Pettis");
            missouri.Add(161, "Phelps");
            missouri.Add(163, "Pike");
            missouri.Add(165, "Platte");
            missouri.Add(167, "Polk");
            missouri.Add(169, "Pulaski");
            missouri.Add(171, "Putnam");
            missouri.Add(173, "Ralls");
            missouri.Add(175, "Randolph");
            missouri.Add(177, "Ray");
            missouri.Add(179, "Reynolds");
            missouri.Add(181, "Ripley");
            missouri.Add(183, "St Charles");
            missouri.Add(185, "St Clair");
            missouri.Add(186, "Ste Genevieve");
            missouri.Add(187, "St Francois");
            missouri.Add(189, "St Louis");
            missouri.Add(195, "Saline");
            missouri.Add(197, "Schuyler");
            missouri.Add(199, "Scotland");
            missouri.Add(201, "Scott");
            missouri.Add(203, "Shannon");
            missouri.Add(205, "Shelby");
            missouri.Add(207, "Stoddard");
            missouri.Add(209, "Stone");
            missouri.Add(211, "Sullivan");
            missouri.Add(213, "Taney");
            missouri.Add(215, "Texas");
            missouri.Add(217, "Vernon");
            missouri.Add(219, "Warren");
            missouri.Add(221, "Washington");
            missouri.Add(223, "Wayne");
            missouri.Add(225, "Webster");
            missouri.Add(227, "Worth");
            missouri.Add(229, "Wright");
            missouri.Add(510, "St Louis City");

        }

        /// <summary>
        /// Populate Montana with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateMontana()
        {
            montana.Add(001, "Beaverhead");
            montana.Add(003, "Big Horn");
            montana.Add(005, "Blaine");
            montana.Add(007, "Broadwater");
            montana.Add(009, "Carbon");
            montana.Add(011, "Carter");
            montana.Add(013, "Cascade");
            montana.Add(015, "Chouteau");
            montana.Add(017, "Custer");
            montana.Add(019, "Daniels");
            montana.Add(021, "Dawson");
            montana.Add(023, "Deer Lodge");
            montana.Add(025, "Fallon");
            montana.Add(027, "Fergus");
            montana.Add(029, "Flathead");
            montana.Add(031, "Gallatin");
            montana.Add(033, "Garfield");
            montana.Add(035, "Glacier");
            montana.Add(037, "Golden Valley");
            montana.Add(039, "Granite");
            montana.Add(041, "Hill");
            montana.Add(043, "Jefferson");
            montana.Add(045, "Judith Basin");
            montana.Add(047, "Lake");
            montana.Add(049, "Lewis and Clark");
            montana.Add(051, "Liberty");
            montana.Add(053, "Lincoln");
            montana.Add(055, "McCone");
            montana.Add(057, "Madison");
            montana.Add(059, "Meagher");
            montana.Add(061, "Mineral");
            montana.Add(063, "Missoula");
            montana.Add(065, "Musselshell");
            montana.Add(067, "Park");
            montana.Add(069, "Petroleum");
            montana.Add(071, "Phillips");
            montana.Add(073, "Pondera");
            montana.Add(075, "Powder River");
            montana.Add(077, "Powell");
            montana.Add(079, "Prairie");
            montana.Add(081, "Ravalli");
            montana.Add(083, "Richland");
            montana.Add(085, "Roosevelt");
            montana.Add(087, "Rosebud");
            montana.Add(089, "Sanders");
            montana.Add(091, "Sheridan");
            montana.Add(093, "Silver Bow");
            montana.Add(095, "Stillwater");
            montana.Add(097, "Sweet Grass");
            montana.Add(099, "Teton");
            montana.Add(101, "Toole");
            montana.Add(103, "Treasure");
            montana.Add(105, "Valley");
            montana.Add(107, "Wheatland");
            montana.Add(109, "Wibaux");
            montana.Add(111, "Yellowstone");

        }

        /// <summary>
        /// Populate Nebraska with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNebraska()
        {
            nebraska.Add(001, "Adams");
            nebraska.Add(003, "Antelope");
            nebraska.Add(005, "Arthur");
            nebraska.Add(007, "Banner");
            nebraska.Add(009, "Blaine");
            nebraska.Add(011, "Boone");
            nebraska.Add(013, "Box Butte");
            nebraska.Add(015, "Boyd");
            nebraska.Add(017, "Brown");
            nebraska.Add(019, "Buffalo");
            nebraska.Add(021, "Burt");
            nebraska.Add(023, "Butler");
            nebraska.Add(025, "Cass");
            nebraska.Add(027, "Cedar");
            nebraska.Add(029, "Chase");
            nebraska.Add(031, "Cherry");
            nebraska.Add(033, "Cheyenne");
            nebraska.Add(035, "Clay");
            nebraska.Add(037, "Colfax");
            nebraska.Add(039, "Cuming");
            nebraska.Add(041, "Custer");
            nebraska.Add(043, "Dakota");
            nebraska.Add(045, "Dawes");
            nebraska.Add(047, "Dawson");
            nebraska.Add(049, "Deuel");
            nebraska.Add(051, "Dixon");
            nebraska.Add(053, "Dodge");
            nebraska.Add(055, "Douglas");
            nebraska.Add(057, "Dundy");
            nebraska.Add(059, "Fillmore");
            nebraska.Add(061, "Franklin");
            nebraska.Add(063, "Frontier");
            nebraska.Add(065, "Furnas");
            nebraska.Add(067, "Gage");
            nebraska.Add(069, "Garden");
            nebraska.Add(071, "Garfield");
            nebraska.Add(073, "Gosper");
            nebraska.Add(075, "Grant");
            nebraska.Add(077, "Greeley");
            nebraska.Add(079, "Hall");
            nebraska.Add(081, "Hamilton");
            nebraska.Add(083, "Harlan");
            nebraska.Add(085, "Hayes");
            nebraska.Add(087, "Hitchcock");
            nebraska.Add(089, "Holt");
            nebraska.Add(091, "Hooker");
            nebraska.Add(093, "Howard");
            nebraska.Add(095, "Jefferson");
            nebraska.Add(097, "Johnson");
            nebraska.Add(099, "Kearney");
            nebraska.Add(101, "Keith");
            nebraska.Add(103, "Keya Paha");
            nebraska.Add(105, "Kimball");
            nebraska.Add(107, "Knox");
            nebraska.Add(109, "Lancaster");
            nebraska.Add(111, "Lincoln");
            nebraska.Add(113, "Logan");
            nebraska.Add(115, "Loup");
            nebraska.Add(117, "McPherson");
            nebraska.Add(119, "Madison");
            nebraska.Add(121, "Merrick");
            nebraska.Add(123, "Morrill");
            nebraska.Add(125, "Nance");
            nebraska.Add(127, "Nemaha");
            nebraska.Add(129, "Nuckolls");
            nebraska.Add(131, "Otoe");
            nebraska.Add(133, "Pawnee");
            nebraska.Add(135, "Perkins");
            nebraska.Add(137, "Phelps");
            nebraska.Add(139, "Pierce");
            nebraska.Add(141, "Platte");
            nebraska.Add(143, "Polk");
            nebraska.Add(145, "Red Willow");
            nebraska.Add(147, "Richardson");
            nebraska.Add(149, "Rock");
            nebraska.Add(151, "Saline");
            nebraska.Add(153, "Sarpy");
            nebraska.Add(155, "Saunders");
            nebraska.Add(157, "Scotts Bluff");
            nebraska.Add(159, "Seward");
            nebraska.Add(161, "Sheridan");
            nebraska.Add(163, "Sherman");
            nebraska.Add(165, "Sioux");
            nebraska.Add(167, "Stanton");
            nebraska.Add(169, "Thayer");
            nebraska.Add(171, "Thomas");
            nebraska.Add(173, "Thurston");
            nebraska.Add(175, "Valley");
            nebraska.Add(177, "Washington");
            nebraska.Add(179, "Wayne");
            nebraska.Add(181, "Webster");
            nebraska.Add(183, "Wheeler");
            nebraska.Add(185, "York");

        }

        /// <summary>
        /// Populate Nevada with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNevada()
        {
            nevada.Add(001, "Churchill");
            nevada.Add(003, "Clark");
            nevada.Add(005, "Douglas");
            nevada.Add(007, "Elko");
            nevada.Add(009, "Esmeralda");
            nevada.Add(011, "Eureka");
            nevada.Add(013, "Humboldt");
            nevada.Add(015, "Lander");
            nevada.Add(017, "Lincoln");
            nevada.Add(019, "Lyon");
            nevada.Add(021, "Mineral");
            nevada.Add(023, "Nye");
            nevada.Add(027, "Pershing");
            nevada.Add(029, "Storey");
            nevada.Add(031, "Washoe");
            nevada.Add(033, "White Pine");
            nevada.Add(510, "Carson City");

        }

        /// <summary>
        /// Populate New Hampshire with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNewHampshire()
        {
            newHampshire.Add(001, "Belknap");
            newHampshire.Add(003, "Carroll");
            newHampshire.Add(005, "Cheshire");
            newHampshire.Add(007, "Coos");
            newHampshire.Add(009, "Grafton");
            newHampshire.Add(011, "Hillsborough");
            newHampshire.Add(013, "Merrimack");
            newHampshire.Add(015, "Rockingham");
            newHampshire.Add(017, "Strafford");
            newHampshire.Add(019, "Sullivan");

        }

        /// <summary>
        /// Populate New Jersey with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNewJersey()
        {
            newJersey.Add(001, "Atlantic");
            newJersey.Add(003, "Bergen");
            newJersey.Add(005, "Burlington");
            newJersey.Add(007, "Camden");
            newJersey.Add(009, "Cape May");
            newJersey.Add(011, "Cumberland");
            newJersey.Add(013, "Essex");
            newJersey.Add(015, "Gloucester");
            newJersey.Add(017, "Hudson");
            newJersey.Add(019, "Hunterdon");
            newJersey.Add(021, "Mercer");
            newJersey.Add(023, "Middlesex");
            newJersey.Add(025, "Monmouth");
            newJersey.Add(027, "Morris");
            newJersey.Add(029, "Ocean");
            newJersey.Add(031, "Passaic");
            newJersey.Add(033, "Salem");
            newJersey.Add(035, "Somerset");
            newJersey.Add(037, "Sussex");
            newJersey.Add(039, "Union");
            newJersey.Add(041, "Warren");

        }

        /// <summary>
        /// Populate New Mexico with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNewMexico()
        {
            newMexico.Add(001, "Bernalillo");
            newMexico.Add(003, "Catron");
            newMexico.Add(005, "Chaves");
            newMexico.Add(006, "Cibola");
            newMexico.Add(007, "Colfax");
            newMexico.Add(009, "Curry");
            newMexico.Add(011, "De Baca");
            newMexico.Add(013, "Dona Ana");
            newMexico.Add(015, "Eddy");
            newMexico.Add(017, "Grant");
            newMexico.Add(019, "Guadalupe");
            newMexico.Add(021, "Harding");
            newMexico.Add(023, "Hidalgo");
            newMexico.Add(025, "Lea");
            newMexico.Add(027, "Lincoln");
            newMexico.Add(028, "Los Alamos");
            newMexico.Add(029, "Luna");
            newMexico.Add(031, "Mckinley");
            newMexico.Add(033, "Mora");
            newMexico.Add(035, "Otero");
            newMexico.Add(037, "Quay");
            newMexico.Add(039, "Rio Arriba");
            newMexico.Add(041, "Roosevelt");
            newMexico.Add(043, "Sandoval");
            newMexico.Add(045, "San Juan");
            newMexico.Add(047, "San Miguel");
            newMexico.Add(049, "Santa Fe");
            newMexico.Add(051, "Sierra");
            newMexico.Add(053, "Socorro");
            newMexico.Add(055, "Taos");
            newMexico.Add(057, "Torrance");
            newMexico.Add(059, "Union");
            newMexico.Add(061, "Valencia");

        }

        /// <summary>
        /// Populate New York with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNewYork()
        {
            newYork.Add(001, "Albany");
            newYork.Add(003, "Allegany");
            newYork.Add(005, "Bronx");
            newYork.Add(007, "Broome");
            newYork.Add(009, "Cattaraugus");
            newYork.Add(011, "Cayuga");
            newYork.Add(013, "Chautauqua");
            newYork.Add(015, "Chemung");
            newYork.Add(017, "Chenango");
            newYork.Add(019, "Clinton");
            newYork.Add(021, "Columbia");
            newYork.Add(023, "Cortland");
            newYork.Add(025, "Delaware");
            newYork.Add(027, "Dutchess");
            newYork.Add(029, "Erie");
            newYork.Add(031, "Essex");
            newYork.Add(033, "Franklin");
            newYork.Add(035, "Fulton");
            newYork.Add(037, "Genesee");
            newYork.Add(039, "Greene");
            newYork.Add(041, "Hamilton");
            newYork.Add(043, "Herkimer");
            newYork.Add(045, "Jefferson");
            newYork.Add(047, "Kings");
            newYork.Add(049, "Lewis");
            newYork.Add(051, "Livingston");
            newYork.Add(053, "Madison");
            newYork.Add(055, "Monroe");
            newYork.Add(057, "Montgomery");
            newYork.Add(059, "Nassau");
            newYork.Add(061, "New York");
            newYork.Add(063, "Niagara");
            newYork.Add(065, "Oneida");
            newYork.Add(067, "Onondaga");
            newYork.Add(069, "Ontario");
            newYork.Add(071, "Orange");
            newYork.Add(073, "Orleans");
            newYork.Add(075, "Oswego");
            newYork.Add(077, "Otsego");
            newYork.Add(079, "Putnam");
            newYork.Add(081, "Queens");
            newYork.Add(083, "Rensselaer");
            newYork.Add(085, "Richmond");
            newYork.Add(087, "Rockland");
            newYork.Add(089, "St Lawrence");
            newYork.Add(091, "Saratoga");
            newYork.Add(093, "Schenectady");
            newYork.Add(095, "Schoharie");
            newYork.Add(097, "Schuyler");
            newYork.Add(099, "Seneca");
            newYork.Add(101, "Steuben");
            newYork.Add(103, "Suffolk");
            newYork.Add(105, "Sullivan");
            newYork.Add(107, "Tioga");
            newYork.Add(109, "Tompkins");
            newYork.Add(111, "Ulster");
            newYork.Add(113, "Warren");
            newYork.Add(115, "Washington");
            newYork.Add(117, "Wayne");
            newYork.Add(119, "Westchester");
            newYork.Add(121, "Wyoming");
            newYork.Add(123, "Yates");

        }

        /// <summary>
        /// Populate North Carolina with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNorthCarolina()
        {
            northCarolina.Add(001, "Alamance");
            northCarolina.Add(003, "Alexander");
            northCarolina.Add(005, "Alleghany");
            northCarolina.Add(007, "Anson");
            northCarolina.Add(009, "Ashe");
            northCarolina.Add(011, "Avery");
            northCarolina.Add(013, "Beaufort");
            northCarolina.Add(015, "Bertie");
            northCarolina.Add(017, "Bladen");
            northCarolina.Add(019, "Brunswick");
            northCarolina.Add(021, "Buncombe");
            northCarolina.Add(023, "Burke");
            northCarolina.Add(025, "Cabarrus");
            northCarolina.Add(027, "Caldwell");
            northCarolina.Add(029, "Camden");
            northCarolina.Add(031, "Carteret");
            northCarolina.Add(033, "Caswell");
            northCarolina.Add(035, "Catawba");
            northCarolina.Add(037, "Chatham");
            northCarolina.Add(039, "Cherokee");
            northCarolina.Add(041, "Chowan");
            northCarolina.Add(043, "Clay");
            northCarolina.Add(045, "Cleveland");
            northCarolina.Add(047, "Columbus");
            northCarolina.Add(049, "Craven");
            northCarolina.Add(051, "Cumberland");
            northCarolina.Add(053, "Currituck");
            northCarolina.Add(055, "Dare");
            northCarolina.Add(057, "Davidson");
            northCarolina.Add(059, "Davie");
            northCarolina.Add(061, "Duplin");
            northCarolina.Add(063, "Durham");
            northCarolina.Add(065, "Edgecombe");
            northCarolina.Add(067, "Forsyth");
            northCarolina.Add(069, "Franklin");
            northCarolina.Add(071, "Gaston");
            northCarolina.Add(073, "Gates");
            northCarolina.Add(075, "Graham");
            northCarolina.Add(077, "Granville");
            northCarolina.Add(079, "Greene");
            northCarolina.Add(081, "Guilford");
            northCarolina.Add(083, "Halifax");
            northCarolina.Add(085, "Harnett");
            northCarolina.Add(087, "Haywood");
            northCarolina.Add(089, "Henderson");
            northCarolina.Add(091, "Hertford");
            northCarolina.Add(093, "Hoke");
            northCarolina.Add(095, "Hyde");
            northCarolina.Add(097, "Iredell");
            northCarolina.Add(099, "Jackson");
            northCarolina.Add(101, "Johnston");
            northCarolina.Add(103, "Jones");
            northCarolina.Add(105, "Lee");
            northCarolina.Add(107, "Lenoir");
            northCarolina.Add(109, "Lincoln");
            northCarolina.Add(111, "McDowell");
            northCarolina.Add(113, "Macon");
            northCarolina.Add(115, "Madison");
            northCarolina.Add(117, "Martin");
            northCarolina.Add(119, "Mecklenburg");
            northCarolina.Add(121, "Mitchell");
            northCarolina.Add(123, "Montgomery");
            northCarolina.Add(125, "Moore");
            northCarolina.Add(127, "Nash");
            northCarolina.Add(129, "New Hanover");
            northCarolina.Add(131, "Northampton");
            northCarolina.Add(133, "Onslow");
            northCarolina.Add(135, "Orange");
            northCarolina.Add(137, "Pamlico");
            northCarolina.Add(139, "Pasquotank");
            northCarolina.Add(141, "Pender");
            northCarolina.Add(143, "Perquimans");
            northCarolina.Add(145, "Person");
            northCarolina.Add(147, "Pitt");
            northCarolina.Add(149, "Polk");
            northCarolina.Add(151, "Randolph");
            northCarolina.Add(153, "Richmond");
            northCarolina.Add(155, "Robeson");
            northCarolina.Add(157, "Rockingham");
            northCarolina.Add(159, "Rowan");
            northCarolina.Add(161, "Rutherford");
            northCarolina.Add(163, "Sampson");
            northCarolina.Add(165, "Scotland");
            northCarolina.Add(167, "Stanly");
            northCarolina.Add(169, "Stokes");
            northCarolina.Add(171, "Surry");
            northCarolina.Add(173, "Swain");
            northCarolina.Add(175, "Transylvania");
            northCarolina.Add(177, "Tyrrell");
            northCarolina.Add(179, "Union");
            northCarolina.Add(181, "Vance");
            northCarolina.Add(183, "Wake");
            northCarolina.Add(185, "Warren");
            northCarolina.Add(187, "Washington");
            northCarolina.Add(189, "Watauga");
            northCarolina.Add(191, "Wayne");
            northCarolina.Add(193, "Wilkes");
            northCarolina.Add(195, "Wilson");
            northCarolina.Add(197, "Yadkin");
            northCarolina.Add(199, "Yancey");

        }

        /// <summary>
        /// Populate North Dakota with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateNorthDakota()
        {
            northDakota.Add(001, "Adams");
            northDakota.Add(003, "Barnes");
            northDakota.Add(005, "Benson");
            northDakota.Add(007, "Billings");
            northDakota.Add(009, "Bottineau");
            northDakota.Add(011, "Bowman");
            northDakota.Add(013, "Burke");
            northDakota.Add(015, "Burleigh");
            northDakota.Add(017, "Cass");
            northDakota.Add(019, "Cavalier");
            northDakota.Add(021, "Dickey");
            northDakota.Add(023, "Divide");
            northDakota.Add(025, "Dunn");
            northDakota.Add(027, "Eddy");
            northDakota.Add(029, "Emmons");
            northDakota.Add(031, "Foster");
            northDakota.Add(033, "Golden Valley");
            northDakota.Add(035, "Grand Forks");
            northDakota.Add(037, "Grant");
            northDakota.Add(039, "Griggs");
            northDakota.Add(041, "Hettinger");
            northDakota.Add(043, "Kidder");
            northDakota.Add(045, "Lamoure");
            northDakota.Add(047, "Logan");
            northDakota.Add(049, "McHenry");
            northDakota.Add(051, "McIntosh");
            northDakota.Add(053, "Mckenzie");
            northDakota.Add(055, "Mclean");
            northDakota.Add(057, "Mercer");
            northDakota.Add(059, "Morton");
            northDakota.Add(061, "Mountrail");
            northDakota.Add(063, "Nelson");
            northDakota.Add(065, "Oliver");
            northDakota.Add(067, "Pembina");
            northDakota.Add(069, "Pierce");
            northDakota.Add(071, "Ramsey");
            northDakota.Add(073, "Ransom");
            northDakota.Add(075, "Renville");
            northDakota.Add(077, "Richland");
            northDakota.Add(079, "Rolette");
            northDakota.Add(081, "Sargent");
            northDakota.Add(083, "Sheridan");
            northDakota.Add(085, "Sioux");
            northDakota.Add(087, "Slope");
            northDakota.Add(089, "Stark");
            northDakota.Add(091, "Steele");
            northDakota.Add(093, "Stutsman");
            northDakota.Add(095, "Towner");
            northDakota.Add(097, "Traill");
            northDakota.Add(099, "Walsh");
            northDakota.Add(101, "Ward");
            northDakota.Add(103, "Wells");
            northDakota.Add(105, "Williams");

        }

        /// <summary>
        /// Populate Ohio with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateOhio()
        {
            ohio.Add(001, "Adams");
            ohio.Add(003, "Allen");
            ohio.Add(005, "Ashland");
            ohio.Add(007, "Ashtabula");
            ohio.Add(009, "Athens");
            ohio.Add(011, "Auglaize");
            ohio.Add(013, "Belmont");
            ohio.Add(015, "Brown");
            ohio.Add(017, "Butler");
            ohio.Add(019, "Carroll");
            ohio.Add(021, "Champaign");
            ohio.Add(023, "Clark");
            ohio.Add(025, "Clermont");
            ohio.Add(027, "Clinton");
            ohio.Add(029, "Columbiana");
            ohio.Add(031, "Coshocton");
            ohio.Add(033, "Crawford");
            ohio.Add(035, "Cuyahoga");
            ohio.Add(037, "Darke");
            ohio.Add(039, "Defiance");
            ohio.Add(041, "Delaware");
            ohio.Add(043, "Erie");
            ohio.Add(045, "Fairfield");
            ohio.Add(047, "Fayette");
            ohio.Add(049, "Franklin");
            ohio.Add(051, "Fulton");
            ohio.Add(053, "Gallia");
            ohio.Add(055, "Geauga");
            ohio.Add(057, "Greene");
            ohio.Add(059, "Guernsey");
            ohio.Add(061, "Hamilton");
            ohio.Add(063, "Hancock");
            ohio.Add(065, "Hardin");
            ohio.Add(067, "Harrison");
            ohio.Add(069, "Henry");
            ohio.Add(071, "Highland");
            ohio.Add(073, "Hocking");
            ohio.Add(075, "Holmes");
            ohio.Add(077, "Huron");
            ohio.Add(079, "Jackson");
            ohio.Add(081, "Jefferson");
            ohio.Add(083, "Knox");
            ohio.Add(085, "Lake");
            ohio.Add(087, "Lawrence");
            ohio.Add(089, "Licking");
            ohio.Add(091, "Logan");
            ohio.Add(093, "Lorain");
            ohio.Add(095, "Lucas");
            ohio.Add(097, "Madison");
            ohio.Add(099, "Mahoning");
            ohio.Add(101, "Marion");
            ohio.Add(103, "Medina");
            ohio.Add(105, "Meigs");
            ohio.Add(107, "Mercer");
            ohio.Add(109, "Miami");
            ohio.Add(111, "Monroe");
            ohio.Add(113, "Montgomery");
            ohio.Add(115, "Morgan");
            ohio.Add(117, "Morrow");
            ohio.Add(119, "Muskingum");
            ohio.Add(121, "Noble");
            ohio.Add(123, "Ottawa");
            ohio.Add(125, "Paulding");
            ohio.Add(127, "Perry");
            ohio.Add(129, "Pickaway");
            ohio.Add(131, "Pike");
            ohio.Add(133, "Portage");
            ohio.Add(135, "Preble");
            ohio.Add(137, "Putnam");
            ohio.Add(139, "Richland");
            ohio.Add(141, "Ross");
            ohio.Add(143, "Sandusky");
            ohio.Add(145, "Scioto");
            ohio.Add(147, "Seneca");
            ohio.Add(149, "Shelby");
            ohio.Add(151, "Stark");
            ohio.Add(153, "Summit");
            ohio.Add(155, "Trumbull");
            ohio.Add(157, "Tuscarawas");
            ohio.Add(159, "Union");
            ohio.Add(161, "Van Wert");
            ohio.Add(163, "Vinton");
            ohio.Add(165, "Warren");
            ohio.Add(167, "Washington");
            ohio.Add(169, "Wayne");
            ohio.Add(171, "Williams");
            ohio.Add(173, "Wood");
            ohio.Add(175, "Wyandot");

        }

        /// <summary>
        /// Populate Oklahoma with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateOklahoma()
        {
            oklahoma.Add(001, "Adair");
            oklahoma.Add(003, "Alfalfa");
            oklahoma.Add(005, "Atoka");
            oklahoma.Add(007, "Beaver");
            oklahoma.Add(009, "Beckham");
            oklahoma.Add(011, "Blaine");
            oklahoma.Add(013, "Bryan");
            oklahoma.Add(015, "Caddo");
            oklahoma.Add(017, "Canadian");
            oklahoma.Add(019, "Carter");
            oklahoma.Add(021, "Cherokee");
            oklahoma.Add(023, "Choctaw");
            oklahoma.Add(025, "Cimarron");
            oklahoma.Add(027, "Cleveland");
            oklahoma.Add(029, "Coal");
            oklahoma.Add(031, "Comanche");
            oklahoma.Add(033, "Cotton");
            oklahoma.Add(035, "Craig");
            oklahoma.Add(037, "Creek");
            oklahoma.Add(039, "Custer");
            oklahoma.Add(041, "Delaware");
            oklahoma.Add(043, "Dewey");
            oklahoma.Add(045, "Ellis");
            oklahoma.Add(047, "Garfield");
            oklahoma.Add(049, "Garvin");
            oklahoma.Add(051, "Grady");
            oklahoma.Add(053, "Grant");
            oklahoma.Add(055, "Greer");
            oklahoma.Add(057, "Harmon");
            oklahoma.Add(059, "Harper");
            oklahoma.Add(061, "Haskell");
            oklahoma.Add(063, "Hughes");
            oklahoma.Add(065, "Jackson");
            oklahoma.Add(067, "Jefferson");
            oklahoma.Add(069, "Johnston");
            oklahoma.Add(071, "Kay");
            oklahoma.Add(073, "Kingfisher");
            oklahoma.Add(075, "Kiowa");
            oklahoma.Add(077, "Latimer");
            oklahoma.Add(079, "Le Flore");
            oklahoma.Add(081, "Lincoln");
            oklahoma.Add(083, "Logan");
            oklahoma.Add(085, "Love");
            oklahoma.Add(087, "Mcclain");
            oklahoma.Add(089, "McCurtain");
            oklahoma.Add(091, "McIntosh");
            oklahoma.Add(093, "Major");
            oklahoma.Add(095, "Marshall");
            oklahoma.Add(097, "Mayes");
            oklahoma.Add(099, "Murray");
            oklahoma.Add(101, "Muskogee");
            oklahoma.Add(103, "Noble");
            oklahoma.Add(105, "Nowata");
            oklahoma.Add(107, "Okfuskee");
            oklahoma.Add(109, "Oklahoma");
            oklahoma.Add(111, "Okmulgee");
            oklahoma.Add(113, "Osage");
            oklahoma.Add(115, "Ottawa");
            oklahoma.Add(117, "Pawnee");
            oklahoma.Add(119, "Payne");
            oklahoma.Add(121, "Pittsburg");
            oklahoma.Add(123, "Pontotoc");
            oklahoma.Add(125, "Pottawatomie");
            oklahoma.Add(127, "Pushmataha");
            oklahoma.Add(129, "Roger Mills");
            oklahoma.Add(131, "Rogers");
            oklahoma.Add(133, "Seminole");
            oklahoma.Add(135, "Sequoyah");
            oklahoma.Add(137, "Stephens");
            oklahoma.Add(139, "Texas");
            oklahoma.Add(141, "Tillman");
            oklahoma.Add(143, "Tulsa");
            oklahoma.Add(145, "Wagoner");
            oklahoma.Add(147, "Washington");
            oklahoma.Add(149, "Washita");
            oklahoma.Add(151, "Woods");
            oklahoma.Add(153, "Woodward");

        }

        /// <summary>
        /// Populate Oregon with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateOregon()
        {
            oregon.Add(001, "Baker");
            oregon.Add(003, "Benton");
            oregon.Add(005, "Clackamas");
            oregon.Add(007, "Clatsop");
            oregon.Add(009, "Columbia");
            oregon.Add(011, "Coos");
            oregon.Add(013, "Crook");
            oregon.Add(015, "Curry");
            oregon.Add(017, "Deschutes");
            oregon.Add(019, "Douglas");
            oregon.Add(021, "Gilliam");
            oregon.Add(023, "Grant");
            oregon.Add(025, "Harney");
            oregon.Add(027, "Hood River");
            oregon.Add(029, "Jackson");
            oregon.Add(031, "Jefferson");
            oregon.Add(033, "Josephine");
            oregon.Add(035, "Klamath");
            oregon.Add(037, "Lake");
            oregon.Add(039, "Lane");
            oregon.Add(041, "Lincoln");
            oregon.Add(043, "Linn");
            oregon.Add(045, "Malheur");
            oregon.Add(047, "Marion");
            oregon.Add(049, "Morrow");
            oregon.Add(051, "Multnomah");
            oregon.Add(053, "Polk");
            oregon.Add(055, "Sherman");
            oregon.Add(057, "Tillamook");
            oregon.Add(059, "Umatilla");
            oregon.Add(061, "Union");
            oregon.Add(063, "Wallowa");
            oregon.Add(065, "Wasco");
            oregon.Add(067, "Washington");
            oregon.Add(069, "Wheeler");
            oregon.Add(071, "Yamhill");

        }

        /// <summary>
        /// Populate Pennsylvania with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulatePennsylvania()
        {
            pennsylvania.Add(001, "Adams");
            pennsylvania.Add(003, "Allegheny");
            pennsylvania.Add(005, "Armstrong");
            pennsylvania.Add(007, "Beaver");
            pennsylvania.Add(009, "Bedford");
            pennsylvania.Add(011, "Berks");
            pennsylvania.Add(013, "Blair");
            pennsylvania.Add(015, "Bradford");
            pennsylvania.Add(017, "Bucks");
            pennsylvania.Add(019, "Butler");
            pennsylvania.Add(021, "Cambria");
            pennsylvania.Add(023, "Cameron");
            pennsylvania.Add(025, "Carbon");
            pennsylvania.Add(027, "Centre");
            pennsylvania.Add(029, "Chester");
            pennsylvania.Add(031, "Clarion");
            pennsylvania.Add(033, "Clearfield");
            pennsylvania.Add(035, "Clinton");
            pennsylvania.Add(037, "Columbia");
            pennsylvania.Add(039, "Crawford");
            pennsylvania.Add(041, "Cumberland");
            pennsylvania.Add(043, "Dauphin");
            pennsylvania.Add(045, "Delaware");
            pennsylvania.Add(047, "Elk");
            pennsylvania.Add(049, "Erie");
            pennsylvania.Add(051, "Fayette");
            pennsylvania.Add(053, "Forest");
            pennsylvania.Add(055, "Franklin");
            pennsylvania.Add(057, "Fulton");
            pennsylvania.Add(059, "Greene");
            pennsylvania.Add(061, "Huntingdon");
            pennsylvania.Add(063, "Indiana");
            pennsylvania.Add(065, "Jefferson");
            pennsylvania.Add(067, "Juniata");
            pennsylvania.Add(069, "Lackawanna");
            pennsylvania.Add(071, "Lancaster");
            pennsylvania.Add(073, "Lawrence");
            pennsylvania.Add(075, "Lebanon");
            pennsylvania.Add(077, "Lehigh");
            pennsylvania.Add(079, "Luzerne");
            pennsylvania.Add(081, "Lycoming");
            pennsylvania.Add(083, "McKean");
            pennsylvania.Add(085, "Mercer");
            pennsylvania.Add(087, "Mifflin");
            pennsylvania.Add(089, "Monroe");
            pennsylvania.Add(091, "Montgomery");
            pennsylvania.Add(093, "Montour");
            pennsylvania.Add(095, "Northampton");
            pennsylvania.Add(097, "Northumberland");
            pennsylvania.Add(099, "Perry");
            pennsylvania.Add(101, "Philadelphia");
            pennsylvania.Add(103, "Pike");
            pennsylvania.Add(105, "Potter");
            pennsylvania.Add(107, "Schuylkill");
            pennsylvania.Add(109, "Snyder");
            pennsylvania.Add(111, "Somerset");
            pennsylvania.Add(113, "Sullivan");
            pennsylvania.Add(115, "Susquehanna");
            pennsylvania.Add(117, "Tioga");
            pennsylvania.Add(119, "Union");
            pennsylvania.Add(121, "Venango");
            pennsylvania.Add(123, "Warren");
            pennsylvania.Add(125, "Washington");
            pennsylvania.Add(127, "Wayne");
            pennsylvania.Add(129, "Westmoreland");
            pennsylvania.Add(131, "Wyoming");
            pennsylvania.Add(133, "York");

        }

        /// <summary>
        /// Populate Rhode Island with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateRhodeIsland()
        {
            rhodeIsland.Add(001, "Bristol");
            rhodeIsland.Add(003, "Kent");
            rhodeIsland.Add(005, "Newport");
            rhodeIsland.Add(007, "Providence");
            rhodeIsland.Add(009, "Washington");

        }

        /// <summary>
        /// Populate South Carolina with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateSouthCarolina()
        {
            southCarolina.Add(001, "Abbeville");
            southCarolina.Add(003, "Aiken");
            southCarolina.Add(005, "Allendale");
            southCarolina.Add(007, "Anderson");
            southCarolina.Add(009, "Bamberg");
            southCarolina.Add(011, "Barnwell");
            southCarolina.Add(013, "Beaufort");
            southCarolina.Add(015, "Berkeley");
            southCarolina.Add(017, "Calhoun");
            southCarolina.Add(019, "Charleston");
            southCarolina.Add(021, "Cherokee");
            southCarolina.Add(023, "Chester");
            southCarolina.Add(025, "Chesterfield");
            southCarolina.Add(027, "Clarendon");
            southCarolina.Add(029, "Colleton");
            southCarolina.Add(031, "Darlington");
            southCarolina.Add(033, "Dillon");
            southCarolina.Add(035, "Dorchester");
            southCarolina.Add(037, "Edgefield");
            southCarolina.Add(039, "Fairfield");
            southCarolina.Add(041, "Florence");
            southCarolina.Add(043, "Georgetown");
            southCarolina.Add(045, "Greenville");
            southCarolina.Add(047, "Greenwood");
            southCarolina.Add(049, "Hampton");
            southCarolina.Add(051, "Horry");
            southCarolina.Add(053, "Jasper");
            southCarolina.Add(055, "Kershaw");
            southCarolina.Add(057, "Lancaster");
            southCarolina.Add(059, "Laurens");
            southCarolina.Add(061, "Lee");
            southCarolina.Add(063, "Lexington");
            southCarolina.Add(065, "McCormick");
            southCarolina.Add(067, "Marion");
            southCarolina.Add(069, "Marlboro");
            southCarolina.Add(071, "Newberry");
            southCarolina.Add(073, "Oconee");
            southCarolina.Add(075, "Orangeburg");
            southCarolina.Add(077, "Pickens");
            southCarolina.Add(079, "Richland");
            southCarolina.Add(081, "Saluda");
            southCarolina.Add(083, "Spartanburg");
            southCarolina.Add(085, "Sumter");
            southCarolina.Add(087, "Union");
            southCarolina.Add(089, "Williamsburg");
            southCarolina.Add(091, "York");

        }

        /// <summary>
        /// Populate South Dakota with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateSouthDakota()
        {
            southDakota.Add(003, "Aurora");
            southDakota.Add(005, "Beadle");
            southDakota.Add(007, "Bennett");
            southDakota.Add(009, "Bon Homme");
            southDakota.Add(011, "Brookings");
            southDakota.Add(013, "Brown");
            southDakota.Add(015, "Brule");
            southDakota.Add(017, "Buffalo");
            southDakota.Add(019, "Butte");
            southDakota.Add(021, "Campbell");
            southDakota.Add(023, "Charles Mix");
            southDakota.Add(025, "Clark");
            southDakota.Add(027, "Clay");
            southDakota.Add(029, "Codington");
            southDakota.Add(031, "Corson");
            southDakota.Add(033, "Custer");
            southDakota.Add(035, "Davison");
            southDakota.Add(037, "Day");
            southDakota.Add(039, "Deuel");
            southDakota.Add(041, "Dewey");
            southDakota.Add(043, "Douglas");
            southDakota.Add(045, "Edmunds");
            southDakota.Add(047, "Fall River");
            southDakota.Add(049, "Faulk");
            southDakota.Add(051, "Grant");
            southDakota.Add(053, "Gregory");
            southDakota.Add(055, "Haakon");
            southDakota.Add(057, "Hamlin");
            southDakota.Add(059, "Hand");
            southDakota.Add(061, "Hanson");
            southDakota.Add(063, "Harding");
            southDakota.Add(065, "Hughes");
            southDakota.Add(067, "Hutchinson");
            southDakota.Add(069, "Hyde");
            southDakota.Add(071, "Jackson");
            southDakota.Add(073, "Jerauld");
            southDakota.Add(075, "Jones");
            southDakota.Add(077, "Kingsbury");
            southDakota.Add(079, "Lake");
            southDakota.Add(081, "Lawrence");
            southDakota.Add(083, "Lincoln");
            southDakota.Add(085, "Lyman");
            southDakota.Add(087, "McCook");
            southDakota.Add(089, "McPherson");
            southDakota.Add(091, "Marshall");
            southDakota.Add(093, "Meade");
            southDakota.Add(095, "Mellette");
            southDakota.Add(097, "Miner");
            southDakota.Add(099, "Minnehaha");
            southDakota.Add(101, "Moody");
            southDakota.Add(103, "Pennington");
            southDakota.Add(105, "Perkins");
            southDakota.Add(107, "Potter");
            southDakota.Add(109, "Roberts");
            southDakota.Add(111, "Sanborn");
            southDakota.Add(113, "Shannon");
            southDakota.Add(115, "Spink");
            southDakota.Add(117, "Stanley");
            southDakota.Add(119, "Sully");
            southDakota.Add(121, "Todd");
            southDakota.Add(123, "Tripp");
            southDakota.Add(125, "Turner");
            southDakota.Add(127, "Union");
            southDakota.Add(129, "Walworth");
            southDakota.Add(135, "Yankton");
            southDakota.Add(137, "Ziebach");

        }

        /// <summary>
        /// Populate Tennessee with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateTennessee()
        {
            tennessee.Add(001, "Anderson");
            tennessee.Add(003, "Bedford");
            tennessee.Add(005, "Benton");
            tennessee.Add(007, "Bledsoe");
            tennessee.Add(009, "Blount");
            tennessee.Add(011, "Bradley");
            tennessee.Add(013, "Campbell");
            tennessee.Add(015, "Cannon");
            tennessee.Add(017, "Carroll");
            tennessee.Add(019, "Carter");
            tennessee.Add(021, "Cheatham");
            tennessee.Add(023, "Chester");
            tennessee.Add(025, "Claiborne");
            tennessee.Add(027, "Clay");
            tennessee.Add(029, "Cocke");
            tennessee.Add(031, "Coffee");
            tennessee.Add(033, "Crockett");
            tennessee.Add(035, "Cumberland");
            tennessee.Add(037, "Davidson");
            tennessee.Add(039, "Decatur");
            tennessee.Add(041, "Dekalb");
            tennessee.Add(043, "Dickson");
            tennessee.Add(045, "Dyer");
            tennessee.Add(047, "Fayette");
            tennessee.Add(049, "Fentress");
            tennessee.Add(051, "Franklin");
            tennessee.Add(053, "Gibson");
            tennessee.Add(055, "Giles");
            tennessee.Add(057, "Grainger");
            tennessee.Add(059, "Greene");
            tennessee.Add(061, "Grundy");
            tennessee.Add(063, "Hamblen");
            tennessee.Add(065, "Hamilton");
            tennessee.Add(067, "Hancock");
            tennessee.Add(069, "Hardeman");
            tennessee.Add(071, "Hardin");
            tennessee.Add(073, "Hawkins");
            tennessee.Add(075, "Haywood");
            tennessee.Add(077, "Henderson");
            tennessee.Add(079, "Henry");
            tennessee.Add(081, "Hickman");
            tennessee.Add(083, "Houston");
            tennessee.Add(085, "Humphreys");
            tennessee.Add(087, "Jackson");
            tennessee.Add(089, "Jefferson");
            tennessee.Add(091, "Johnson");
            tennessee.Add(093, "Knox");
            tennessee.Add(095, "Lake");
            tennessee.Add(097, "Lauderdale");
            tennessee.Add(099, "Lawrence");
            tennessee.Add(101, "Lewis");
            tennessee.Add(103, "Lincoln");
            tennessee.Add(105, "Loudon");
            tennessee.Add(107, "McMinn");
            tennessee.Add(109, "McNairy");
            tennessee.Add(111, "Macon");
            tennessee.Add(113, "Madison");
            tennessee.Add(115, "Marion");
            tennessee.Add(117, "Marshall");
            tennessee.Add(119, "Maury");
            tennessee.Add(121, "Meigs");
            tennessee.Add(123, "Monroe");
            tennessee.Add(125, "Montgomery");
            tennessee.Add(127, "Moore");
            tennessee.Add(129, "Morgan");
            tennessee.Add(131, "Obion");
            tennessee.Add(133, "Overton");
            tennessee.Add(135, "Perry");
            tennessee.Add(137, "Pickett");
            tennessee.Add(139, "Polk");
            tennessee.Add(141, "Putnam");
            tennessee.Add(143, "Rhea");
            tennessee.Add(145, "Roane");
            tennessee.Add(147, "Robertson");
            tennessee.Add(149, "Rutherford");
            tennessee.Add(151, "Scott");
            tennessee.Add(153, "Sequatchie");
            tennessee.Add(155, "Sevier");
            tennessee.Add(157, "Shelby");
            tennessee.Add(159, "Smith");
            tennessee.Add(161, "Stewart");
            tennessee.Add(163, "Sullivan");
            tennessee.Add(165, "Sumner");
            tennessee.Add(167, "Tipton");
            tennessee.Add(169, "Trousdale");
            tennessee.Add(171, "Unicoi");
            tennessee.Add(173, "Union");
            tennessee.Add(175, "Van Buren");
            tennessee.Add(177, "Warren");
            tennessee.Add(179, "Washington");
            tennessee.Add(181, "Wayne");
            tennessee.Add(183, "Weakley");
            tennessee.Add(185, "White");
            tennessee.Add(187, "Williamson");
            tennessee.Add(189, "Wilson");

        }

        /// <summary>
        /// Populate Texas with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateTexas()
        {
            texas.Add(001, "Anderson");
            texas.Add(003, "Andrews");
            texas.Add(005, "Angelina");
            texas.Add(007, "Aransas");
            texas.Add(009, "Archer");
            texas.Add(011, "Armstrong");
            texas.Add(013, "Atascosa");
            texas.Add(015, "Austin");
            texas.Add(017, "Bailey");
            texas.Add(019, "Bandera");
            texas.Add(021, "Bastrop");
            texas.Add(023, "Baylor");
            texas.Add(025, "Bee");
            texas.Add(027, "Bell");
            texas.Add(029, "Bexar");
            texas.Add(031, "Blanco");
            texas.Add(033, "Borden");
            texas.Add(035, "Bosque");
            texas.Add(037, "Bowie");
            texas.Add(039, "Brazoria");
            texas.Add(041, "Brazos");
            texas.Add(043, "Brewster");
            texas.Add(045, "Briscoe");
            texas.Add(047, "Brooks");
            texas.Add(049, "Brown");
            texas.Add(051, "Burleson");
            texas.Add(053, "Burnet");
            texas.Add(055, "Caldwell");
            texas.Add(057, "Calhoun");
            texas.Add(059, "Callahan");
            texas.Add(061, "Cameron");
            texas.Add(063, "Camp");
            texas.Add(065, "Carson");
            texas.Add(067, "Cass");
            texas.Add(069, "Castro");
            texas.Add(071, "Chambers");
            texas.Add(073, "Cherokee");
            texas.Add(075, "Childress");
            texas.Add(077, "Clay");
            texas.Add(079, "Cochran");
            texas.Add(081, "Coke");
            texas.Add(083, "Coleman");
            texas.Add(085, "Collin");
            texas.Add(087, "Collingsworth");
            texas.Add(089, "Colorado");
            texas.Add(091, "Comal");
            texas.Add(093, "Comanche");
            texas.Add(095, "Concho");
            texas.Add(097, "Cooke");
            texas.Add(099, "Coryell");
            texas.Add(101, "Cottle");
            texas.Add(103, "Crane");
            texas.Add(105, "Crockett");
            texas.Add(107, "Crosby");
            texas.Add(109, "Culberson");
            texas.Add(111, "Dallam");
            texas.Add(113, "Dallas");
            texas.Add(115, "Dawson");
            texas.Add(117, "Deaf Smith");
            texas.Add(119, "Delta");
            texas.Add(121, "Denton");
            texas.Add(123, "De Witt");
            texas.Add(125, "Dickens");
            texas.Add(127, "Dimmit");
            texas.Add(129, "Donley");
            texas.Add(131, "Duval");
            texas.Add(133, "Eastland");
            texas.Add(135, "Ector");
            texas.Add(137, "Edwards");
            texas.Add(139, "Ellis");
            texas.Add(141, "El Paso");
            texas.Add(143, "Erath");
            texas.Add(145, "Falls");
            texas.Add(147, "Fannin");
            texas.Add(149, "Fayette");
            texas.Add(151, "Fisher");
            texas.Add(153, "Floyd");
            texas.Add(155, "Foard");
            texas.Add(157, "Fort Bend");
            texas.Add(159, "Franklin");
            texas.Add(161, "Freestone");
            texas.Add(163, "Frio");
            texas.Add(165, "Gaines");
            texas.Add(167, "Galveston");
            texas.Add(169, "Garza");
            texas.Add(171, "Gillespie");
            texas.Add(173, "Glasscock");
            texas.Add(175, "Goliad");
            texas.Add(177, "Gonzales");
            texas.Add(179, "Gray");
            texas.Add(181, "Grayson");
            texas.Add(183, "Gregg");
            texas.Add(185, "Grimes");
            texas.Add(187, "Guadalupe");
            texas.Add(189, "Hale");
            texas.Add(191, "Hall");
            texas.Add(193, "Hamilton");
            texas.Add(195, "Hansford");
            texas.Add(197, "Hardeman");
            texas.Add(199, "Hardin");
            texas.Add(201, "Harris");
            texas.Add(203, "Harrison");
            texas.Add(205, "Hartley");
            texas.Add(207, "Haskell");
            texas.Add(209, "Hays");
            texas.Add(211, "Hemphill");
            texas.Add(213, "Henderson");
            texas.Add(215, "Hidalgo");
            texas.Add(217, "Hill");
            texas.Add(219, "Hockley");
            texas.Add(221, "Hood");
            texas.Add(223, "Hopkins");
            texas.Add(225, "Houston");
            texas.Add(227, "Howard");
            texas.Add(229, "Hudspeth");
            texas.Add(231, "Hunt");
            texas.Add(233, "Hutchinson");
            texas.Add(235, "Irion");
            texas.Add(237, "Jack");
            texas.Add(239, "Jackson");
            texas.Add(241, "Jasper");
            texas.Add(243, "Jeff Davis");
            texas.Add(245, "Jefferson");
            texas.Add(247, "Jim Hogg");
            texas.Add(249, "Jim Wells");
            texas.Add(251, "Johnson");
            texas.Add(253, "Jones");
            texas.Add(255, "Karnes");
            texas.Add(257, "Kaufman");
            texas.Add(259, "Kendall");
            texas.Add(261, "Kenedy");
            texas.Add(263, "Kent");
            texas.Add(265, "Kerr");
            texas.Add(267, "Kimble");
            texas.Add(269, "King");
            texas.Add(271, "Kinney");
            texas.Add(273, "Kleberg");
            texas.Add(275, "Knox");
            texas.Add(277, "Lamar");
            texas.Add(279, "Lamb");
            texas.Add(281, "Lampasas");
            texas.Add(283, "La Salle");
            texas.Add(285, "Lavaca");
            texas.Add(287, "Lee");
            texas.Add(289, "Leon");
            texas.Add(291, "Liberty");
            texas.Add(293, "Limestone");
            texas.Add(295, "Lipscomb");
            texas.Add(297, "Live Oak");
            texas.Add(299, "Llano");
            texas.Add(301, "Loving");
            texas.Add(303, "Lubbock");
            texas.Add(305, "Lynn");
            texas.Add(307, "McCulloch");
            texas.Add(309, "McLennan");
            texas.Add(311, "McMullen");
            texas.Add(313, "Madison");
            texas.Add(315, "Marion");
            texas.Add(317, "Martin");
            texas.Add(319, "Mason");
            texas.Add(321, "Matagorda");
            texas.Add(323, "Maverick");
            texas.Add(325, "Medina");
            texas.Add(327, "Menard");
            texas.Add(329, "Midland");
            texas.Add(331, "Milam");
            texas.Add(333, "Mills");
            texas.Add(335, "Mitchell");
            texas.Add(337, "Montague");
            texas.Add(339, "Montgomery");
            texas.Add(341, "Moore");
            texas.Add(343, "Morris");
            texas.Add(345, "Motley");
            texas.Add(347, "Nacogdoches");
            texas.Add(349, "Navarro");
            texas.Add(351, "Newton");
            texas.Add(353, "Nolan");
            texas.Add(355, "Nueces");
            texas.Add(357, "Ochiltree");
            texas.Add(359, "Oldham");
            texas.Add(361, "Orange");
            texas.Add(363, "Palo Pinto");
            texas.Add(365, "Panola");
            texas.Add(367, "Parker");
            texas.Add(369, "Parmer");
            texas.Add(371, "Pecos");
            texas.Add(373, "Polk");
            texas.Add(375, "Potter");
            texas.Add(377, "Presidio");
            texas.Add(379, "Rains");
            texas.Add(381, "Randall");
            texas.Add(383, "Reagan");
            texas.Add(385, "Real");
            texas.Add(387, "Red River");
            texas.Add(389, "Reeves");
            texas.Add(391, "Refugio");
            texas.Add(393, "Roberts");
            texas.Add(395, "Robertson");
            texas.Add(397, "Rockwall");
            texas.Add(399, "Runnels");
            texas.Add(401, "Rusk");
            texas.Add(403, "Sabine");
            texas.Add(405, "San Augustine");
            texas.Add(407, "San Jacinto");
            texas.Add(409, "San Patricio");
            texas.Add(411, "San Saba");
            texas.Add(413, "Schleicher");
            texas.Add(415, "Scurry");
            texas.Add(417, "Shackelford");
            texas.Add(419, "Shelby");
            texas.Add(421, "Sherman");
            texas.Add(423, "Smith");
            texas.Add(425, "Somervell");
            texas.Add(427, "Starr");
            texas.Add(429, "Stephens");
            texas.Add(431, "Sterling");
            texas.Add(433, "Stonewall");
            texas.Add(435, "Sutton");
            texas.Add(437, "Swisher");
            texas.Add(439, "Tarrant");
            texas.Add(441, "Taylor");
            texas.Add(443, "Terrell");
            texas.Add(445, "Terry");
            texas.Add(447, "Throckmorton");
            texas.Add(449, "Titus");
            texas.Add(451, "Tom Green");
            texas.Add(453, "Travis");
            texas.Add(455, "Trinity");
            texas.Add(457, "Tyler");
            texas.Add(459, "Upshur");
            texas.Add(461, "Upton");
            texas.Add(463, "Uvalde");
            texas.Add(465, "Val Verde");
            texas.Add(467, "Van Zandt");
            texas.Add(469, "Victoria");
            texas.Add(471, "Walker");
            texas.Add(473, "Waller");
            texas.Add(475, "Ward");
            texas.Add(477, "Washington");
            texas.Add(479, "Webb");
            texas.Add(481, "Wharton");
            texas.Add(483, "Wheeler");
            texas.Add(485, "Wichita");
            texas.Add(487, "Wilbarger");
            texas.Add(489, "Willacy");
            texas.Add(491, "Williamson");
            texas.Add(493, "Wilson");
            texas.Add(495, "Winkler");
            texas.Add(497, "Wise");
            texas.Add(499, "Wood");
            texas.Add(501, "Yoakum");
            texas.Add(503, "Young");
            texas.Add(505, "Zapata");
            texas.Add(507, "Zavala");

        }

        /// <summary>
        /// Populate Utah with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateUtah()
        {
            utah.Add(001, "Beaver");
            utah.Add(003, "Box Elder");
            utah.Add(005, "Cache");
            utah.Add(007, "Carbon");
            utah.Add(009, "Daggett");
            utah.Add(011, "Davis");
            utah.Add(013, "Duchesne");
            utah.Add(015, "Emery");
            utah.Add(017, "Garfield");
            utah.Add(019, "Grand");
            utah.Add(021, "Iron");
            utah.Add(023, "Juab");
            utah.Add(025, "Kane");
            utah.Add(027, "Millard");
            utah.Add(029, "Morgan");
            utah.Add(031, "Piute");
            utah.Add(033, "Rich");
            utah.Add(035, "Salt Lake");
            utah.Add(037, "San Juan");
            utah.Add(039, "Sanpete");
            utah.Add(041, "Sevier");
            utah.Add(043, "Summit");
            utah.Add(045, "Tooele");
            utah.Add(047, "Uintah");
            utah.Add(049, "Utah");
            utah.Add(051, "Wasatch");
            utah.Add(053, "Washington");
            utah.Add(055, "Wayne");
            utah.Add(057, "Weber");

        }

        /// <summary>
        /// Populate Vermont with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateVermont()
        {
            vermont.Add(001, "Addison");
            vermont.Add(003, "Bennington");
            vermont.Add(005, "Caledonia");
            vermont.Add(007, "Chittenden");
            vermont.Add(009, "Essex");
            vermont.Add(011, "Franklin");
            vermont.Add(013, "Grand Isle");
            vermont.Add(015, "Lamoille");
            vermont.Add(017, "Orange");
            vermont.Add(019, "Orleans");
            vermont.Add(021, "Rutland");
            vermont.Add(023, "Washington");
            vermont.Add(025, "Windham");
            vermont.Add(027, "Windsor");

        }

        /// <summary>
        /// Populate Virginia with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateVirginia()
        {
            virginia.Add(001, "Accomack");
            virginia.Add(003, "Albemarle");
            virginia.Add(005, "Alleghany");
            virginia.Add(007, "Amelia");
            virginia.Add(009, "Amherst");
            virginia.Add(011, "Appomattox");
            virginia.Add(013, "Arlington");
            virginia.Add(015, "Augusta");
            virginia.Add(017, "Bath");
            virginia.Add(019, "Bedford");
            virginia.Add(021, "Bland");
            virginia.Add(023, "Botetourt");
            virginia.Add(025, "Brunswick");
            virginia.Add(027, "Buchanan");
            virginia.Add(029, "Buckingham");
            virginia.Add(031, "Campbell");
            virginia.Add(033, "Caroline");
            virginia.Add(035, "Carroll");
            virginia.Add(036, "Charles City");
            virginia.Add(037, "Charlotte");
            virginia.Add(041, "Chesterfield");
            virginia.Add(043, "Clarke");
            virginia.Add(045, "Craig");
            virginia.Add(047, "Culpeper");
            virginia.Add(049, "Cumberland");
            virginia.Add(051, "Dickenson");
            virginia.Add(053, "Dinwiddie");
            virginia.Add(057, "Essex");
            virginia.Add(059, "Fairfax");
            virginia.Add(061, "Fauquier");
            virginia.Add(063, "Floyd");
            virginia.Add(065, "Fluvanna");
            virginia.Add(067, "Franklin");
            virginia.Add(069, "Frederick");
            virginia.Add(071, "Giles");
            virginia.Add(073, "Gloucester");
            virginia.Add(075, "Goochland");
            virginia.Add(077, "Grayson");
            virginia.Add(079, "Greene");
            virginia.Add(081, "Greensville");
            virginia.Add(083, "Halifax");
            virginia.Add(085, "Hanover");
            virginia.Add(087, "Henrico");
            virginia.Add(089, "Henry");
            virginia.Add(091, "Highland");
            virginia.Add(093, "Isle of Wight");
            virginia.Add(095, "James City");
            virginia.Add(097, "King and Queen");
            virginia.Add(099, "King George");
            virginia.Add(101, "King William");
            virginia.Add(103, "Lancaster");
            virginia.Add(105, "Lee");
            virginia.Add(107, "Loudoun");
            virginia.Add(109, "Louisa");
            virginia.Add(111, "Lunenburg");
            virginia.Add(113, "Madison");
            virginia.Add(115, "Mathews");
            virginia.Add(117, "Mecklenburg");
            virginia.Add(119, "Middlesex");
            virginia.Add(121, "Montgomery");
            virginia.Add(125, "Nelson");
            virginia.Add(127, "New Kent");
            virginia.Add(131, "Northampton");
            virginia.Add(133, "Northumberland");
            virginia.Add(135, "Nottoway");
            virginia.Add(137, "Orange");
            virginia.Add(139, "Page");
            virginia.Add(141, "Patrick");
            virginia.Add(143, "Pittsylvania");
            virginia.Add(145, "Powhatan");
            virginia.Add(147, "Prince Edward");
            virginia.Add(149, "Prince George");
            virginia.Add(153, "Prince William");
            virginia.Add(155, "Pulaski");
            virginia.Add(157, "Rappahannock");
            virginia.Add(159, "Richmond");
            virginia.Add(161, "Roanoke");
            virginia.Add(163, "Rockbridge");
            virginia.Add(165, "Rockingham");
            virginia.Add(167, "Russell");
            virginia.Add(169, "Scott");
            virginia.Add(171, "Shenandoah");
            virginia.Add(173, "Smyth");
            virginia.Add(175, "Southampton");
            virginia.Add(177, "Spotsylvania");
            virginia.Add(179, "Stafford");
            virginia.Add(181, "Surry");
            virginia.Add(183, "Sussex");
            virginia.Add(185, "Tazewell");
            virginia.Add(187, "Warren");
            virginia.Add(191, "Washington");
            virginia.Add(193, "Westmoreland");
            virginia.Add(195, "Wise");
            virginia.Add(197, "Wythe");
            virginia.Add(199, "York");
            virginia.Add(510, "Alexandria City");
            virginia.Add(515, "Bedford City");
            virginia.Add(520, "Bristol City");
            virginia.Add(530, "Buena Vista City");
            virginia.Add(540, "Charlottesville City");
            virginia.Add(550, "Chesapeake City");
            virginia.Add(560, "Clifton Forge City");
            virginia.Add(570, "Colonial Heights City");
            virginia.Add(580, "Covington City");
            virginia.Add(590, "Danville City");
            virginia.Add(595, "Emporia City");
            virginia.Add(600, "Fairfax City");
            virginia.Add(610, "Falls Church City");
            virginia.Add(620, "Franklin City");
            virginia.Add(630, "Fredericksburg City");
            virginia.Add(640, "Galax City");
            virginia.Add(650, "Hampton City");
            virginia.Add(660, "Harrisonburg City");
            virginia.Add(670, "Hopewell City");
            virginia.Add(678, "Lexington City");
            virginia.Add(680, "Lynchburg City");
            virginia.Add(683, "Manassas City");
            virginia.Add(685, "Manassas Park City");
            virginia.Add(690, "Martinsville City");
            virginia.Add(700, "Newport News City");
            virginia.Add(710, "Norfolk City");
            virginia.Add(720, "Norton City");
            virginia.Add(730, "Petersburg City");
            virginia.Add(735, "Poquoson City");
            virginia.Add(740, "Portsmouth City");
            virginia.Add(750, "Radford");
            virginia.Add(760, "Richmond City");
            virginia.Add(770, "Roanoke City");
            virginia.Add(775, "Salem City");
            virginia.Add(780, "South Boston City");
            virginia.Add(790, "Staunton City");
            virginia.Add(800, "Suffolk City");
            virginia.Add(810, "Virginia Beach City");
            virginia.Add(820, "Waynesboro City");
            virginia.Add(830, "Williamsburg City");
            virginia.Add(840, "Winchester City");

        }

        /// <summary>
        /// Populate Washington with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateWashington()
        {
            washington.Add(001, "Adams");
            washington.Add(003, "Asotin");
            washington.Add(005, "Benton");
            washington.Add(007, "Chelan");
            washington.Add(009, "Clallam");
            washington.Add(011, "Clark");
            washington.Add(013, "Columbia");
            washington.Add(015, "Cowlitz");
            washington.Add(017, "Douglas");
            washington.Add(019, "Ferry");
            washington.Add(021, "Franklin");
            washington.Add(023, "Garfield");
            washington.Add(025, "Grant");
            washington.Add(027, "Grays Harbor");
            washington.Add(029, "Island");
            washington.Add(031, "Jefferson");
            washington.Add(033, "King");
            washington.Add(035, "Kitsap");
            washington.Add(037, "Kittitas");
            washington.Add(039, "Klickitat");
            washington.Add(041, "Lewis");
            washington.Add(043, "Lincoln");
            washington.Add(045, "Mason");
            washington.Add(047, "Okanogan");
            washington.Add(049, "Pacific");
            washington.Add(051, "Pend Oreille");
            washington.Add(053, "Pierce");
            washington.Add(055, "San Juan");
            washington.Add(057, "Skagit");
            washington.Add(059, "Skamania");
            washington.Add(061, "Snohomish");
            washington.Add(063, "Spokane");
            washington.Add(065, "Stevens");
            washington.Add(067, "Thurston");
            washington.Add(069, "Wahkiakum");
            washington.Add(071, "Walla Walla");
            washington.Add(073, "Whatcom");
            washington.Add(075, "Whitman");
            washington.Add(077, "Yakima");

        }

        /// <summary>
        /// Populate West Virginia with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateWestVirginia()
        {
            westVirginia.Add(001, "Barbour");
            westVirginia.Add(003, "Berkeley");
            westVirginia.Add(005, "Boone");
            westVirginia.Add(007, "Braxton");
            westVirginia.Add(009, "Brooke");
            westVirginia.Add(011, "Cabell");
            westVirginia.Add(013, "Calhoun");
            westVirginia.Add(015, "Clay");
            westVirginia.Add(017, "Doddridge");
            westVirginia.Add(019, "Fayette");
            westVirginia.Add(021, "Gilmer");
            westVirginia.Add(023, "Grant");
            westVirginia.Add(025, "Greenbrier");
            westVirginia.Add(027, "Hampshire");
            westVirginia.Add(029, "Hancock");
            westVirginia.Add(031, "Hardy");
            westVirginia.Add(033, "Harrison");
            westVirginia.Add(035, "Jackson");
            westVirginia.Add(037, "Jefferson");
            westVirginia.Add(039, "Kanawha");
            westVirginia.Add(041, "Lewis");
            westVirginia.Add(043, "Lincoln");
            westVirginia.Add(045, "Logan");
            westVirginia.Add(047, "McDowell");
            westVirginia.Add(049, "Marion");
            westVirginia.Add(051, "Marshall");
            westVirginia.Add(053, "Mason");
            westVirginia.Add(055, "Mercer");
            westVirginia.Add(057, "Mineral");
            westVirginia.Add(059, "Mingo");
            westVirginia.Add(061, "Monongalia");
            westVirginia.Add(063, "Monroe");
            westVirginia.Add(065, "Morgan");
            westVirginia.Add(067, "Nicholas");
            westVirginia.Add(069, "Ohio");
            westVirginia.Add(071, "Pendleton");
            westVirginia.Add(073, "Pleasants");
            westVirginia.Add(075, "Pocahontas");
            westVirginia.Add(077, "Preston");
            westVirginia.Add(079, "Putnam");
            westVirginia.Add(081, "Raleigh");
            westVirginia.Add(083, "Randolph");
            westVirginia.Add(085, "Ritchie");
            westVirginia.Add(087, "Roane");
            westVirginia.Add(089, "Summers");
            westVirginia.Add(091, "Taylor");
            westVirginia.Add(093, "Tucker");
            westVirginia.Add(095, "Tyler");
            westVirginia.Add(097, "Upshur");
            westVirginia.Add(099, "Wayne");
            westVirginia.Add(101, "Webster");
            westVirginia.Add(103, "Wetzel");
            westVirginia.Add(105, "Wirt");
            westVirginia.Add(107, "Wood");
            westVirginia.Add(109, "Wyoming");

        }

        /// <summary>
        /// Populate Wisconsin with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateWisconsin()
        {
            wisconsin.Add(001, "Adams");
            wisconsin.Add(003, "Ashland");
            wisconsin.Add(005, "Barron");
            wisconsin.Add(007, "Bayfield");
            wisconsin.Add(009, "Brown");
            wisconsin.Add(011, "Buffalo");
            wisconsin.Add(013, "Burnett");
            wisconsin.Add(015, "Calumet");
            wisconsin.Add(017, "Chippewa");
            wisconsin.Add(019, "Clark");
            wisconsin.Add(021, "Columbia");
            wisconsin.Add(023, "Crawford");
            wisconsin.Add(025, "Dane");
            wisconsin.Add(027, "Dodge");
            wisconsin.Add(029, "Door");
            wisconsin.Add(031, "Douglas");
            wisconsin.Add(033, "Dunn");
            wisconsin.Add(035, "Eau Claire");
            wisconsin.Add(037, "Florence");
            wisconsin.Add(039, "Fond Du Lac");
            wisconsin.Add(041, "Forest");
            wisconsin.Add(043, "Grant");
            wisconsin.Add(045, "Green");
            wisconsin.Add(047, "Green Lake");
            wisconsin.Add(049, "Iowa");
            wisconsin.Add(051, "Iron");
            wisconsin.Add(053, "Jackson");
            wisconsin.Add(055, "Jefferson");
            wisconsin.Add(057, "Juneau");
            wisconsin.Add(059, "Kenosha");
            wisconsin.Add(061, "Kewaunee");
            wisconsin.Add(063, "La Crosse");
            wisconsin.Add(065, "Lafayette");
            wisconsin.Add(067, "Langlade");
            wisconsin.Add(069, "Lincoln");
            wisconsin.Add(071, "Manitowoc");
            wisconsin.Add(073, "Marathon");
            wisconsin.Add(075, "Marinette");
            wisconsin.Add(077, "Marquette");
            wisconsin.Add(078, "Menominee");
            wisconsin.Add(079, "Milwaukee");
            wisconsin.Add(081, "Monroe");
            wisconsin.Add(083, "Oconto");
            wisconsin.Add(085, "Oneida");
            wisconsin.Add(087, "Outagamie");
            wisconsin.Add(089, "Ozaukee");
            wisconsin.Add(091, "Pepin");
            wisconsin.Add(093, "Pierce");
            wisconsin.Add(095, "Polk");
            wisconsin.Add(097, "Portage");
            wisconsin.Add(099, "Price");
            wisconsin.Add(101, "Racine");
            wisconsin.Add(103, "Richland");
            wisconsin.Add(105, "Rock");
            wisconsin.Add(107, "Rusk");
            wisconsin.Add(109, "St Croix");
            wisconsin.Add(111, "Sauk");
            wisconsin.Add(113, "Sawyer");
            wisconsin.Add(115, "Shawano");
            wisconsin.Add(117, "Sheboygan");
            wisconsin.Add(119, "Taylor");
            wisconsin.Add(121, "Trempealeau");
            wisconsin.Add(123, "Vernon");
            wisconsin.Add(125, "Vilas");
            wisconsin.Add(127, "Walworth");
            wisconsin.Add(129, "Washburn");
            wisconsin.Add(131, "Washington");
            wisconsin.Add(133, "Waukesha");
            wisconsin.Add(135, "Waupaca");
            wisconsin.Add(137, "Waushara");
            wisconsin.Add(139, "Winnebago");
            wisconsin.Add(141, "Wood");

        }

        /// <summary>
        /// Populate Wyoming with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulateWyoming()
        {
            wyoming.Add(001, "Albany");
            wyoming.Add(003, "Big Horn");
            wyoming.Add(005, "Campbell");
            wyoming.Add(007, "Carbon");
            wyoming.Add(009, "Converse");
            wyoming.Add(011, "Crook");
            wyoming.Add(013, "Fremont");
            wyoming.Add(015, "Goshen");
            wyoming.Add(017, "Hot Springs");
            wyoming.Add(019, "Johnson");
            wyoming.Add(021, "Laramie");
            wyoming.Add(023, "Lincoln");
            wyoming.Add(025, "Natrona");
            wyoming.Add(027, "Niobrara");
            wyoming.Add(029, "Park");
            wyoming.Add(031, "Platte");
            wyoming.Add(033, "Sheridan");
            wyoming.Add(035, "Sublette");
            wyoming.Add(037, "Sweetwater");
            wyoming.Add(039, "Teton");
            wyoming.Add(041, "Uinta");
            wyoming.Add(043, "Washakie");
            wyoming.Add(045, "Weston");

        }

        /// <summary>
        /// Populate Puerto Rico with its counties and corresponding FIPS codes
        /// </summary>
        private void PopulatePuertoRico()
        {
            puertoRico.Add(1, "Adjuntas");
            puertoRico.Add(3, "Aguada");
            puertoRico.Add(5, "Aguadilla");
            puertoRico.Add(7, "Aguas Buenas");
            puertoRico.Add(9, "Aibonito");
            puertoRico.Add(11, "Añasco");
            puertoRico.Add(13, "Arecibo");
            puertoRico.Add(15, "Arroyo");
            puertoRico.Add(17, "Barceloneta");
            puertoRico.Add(19, "Barranquitas");
            puertoRico.Add(21, "Bayamón");
            puertoRico.Add(23, "Cabo Rojo");
            puertoRico.Add(25, "Caguas");
            puertoRico.Add(27, "Camuy");
            puertoRico.Add(29, "Canóvanas");
            puertoRico.Add(31, "Carolina");
            puertoRico.Add(33, "Cataño");
            puertoRico.Add(35, "Cayey");
            puertoRico.Add(37, "Ceiba");
            puertoRico.Add(39, "Ciales");
            puertoRico.Add(41, "Cidra");
            puertoRico.Add(43, "Coamo");
            puertoRico.Add(45, "Comerío");
            puertoRico.Add(47, "Corozal");
            puertoRico.Add(49, "Culebra");
            puertoRico.Add(51, "Dorado");
            puertoRico.Add(53, "Fajardo");
            puertoRico.Add(54, "Florida");
            puertoRico.Add(55, "Guánica");
            puertoRico.Add(57, "Guayama");
            puertoRico.Add(59, "Guayanilla");
            puertoRico.Add(61, "Guaynabo");
            puertoRico.Add(63, "Gurabo");
            puertoRico.Add(65, "Hatillo");
            puertoRico.Add(67, "Hormigueros");
            puertoRico.Add(69, "Humacao");
            puertoRico.Add(71, "Isabela");
            puertoRico.Add(73, "Jayuya");
            puertoRico.Add(75, "Juana Díaz");
            puertoRico.Add(77, "Juncos");
            puertoRico.Add(79, "Lajas");
            puertoRico.Add(81, "Lares");
            puertoRico.Add(83, "Las Marías");
            puertoRico.Add(85, "Las Piedras");
            puertoRico.Add(87, "Loíza");
            puertoRico.Add(89, "Luquillo");
            puertoRico.Add(91, "Manatí");
            puertoRico.Add(93, "Maricao");
            puertoRico.Add(95, "Maunabo");
            puertoRico.Add(97, "Mayagüez");
            puertoRico.Add(99, "Moca");
            puertoRico.Add(101, "Morovis");
            puertoRico.Add(103, "Naguabo");
            puertoRico.Add(105, "Naranjito");
            puertoRico.Add(107, "Orocovis");
            puertoRico.Add(109, "Patillas");
            puertoRico.Add(111, "Peñuelas");
            puertoRico.Add(113, "Ponce");
            puertoRico.Add(115, "Quebradillas");
            puertoRico.Add(117, "Rincón");
            puertoRico.Add(119, "Río Grande");
            puertoRico.Add(121, "Sabana Grande");
            puertoRico.Add(123, "Salinas");
            puertoRico.Add(125, "San Germán");
            puertoRico.Add(127, "San Juan");
            puertoRico.Add(129, "San Lorenzo");
            puertoRico.Add(131, "San Sebastián");
            puertoRico.Add(133, "Santa Isabel");
            puertoRico.Add(135, "Toa Alta");
            puertoRico.Add(137, "Toa Baja");
            puertoRico.Add(139, "Trujillo Alto");
            puertoRico.Add(141, "Utuado");
            puertoRico.Add(143, "Vega Alta");
            puertoRico.Add(145, "Vega Baja");
            puertoRico.Add(147, "Vieques");
            puertoRico.Add(149, "Villalba");
            puertoRico.Add(151, "Yabucoa");
            puertoRico.Add(153, "Yauco");

        }

        #endregion
    }
}