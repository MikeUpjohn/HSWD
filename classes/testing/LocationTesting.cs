using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using artefact.enums;

namespace artefact.classes.testing
{
    public class LocationTesting
    {
        [Test]
        public void CheckStateFIPSExistenceNoFIPSCodeSpecified()
        {
            Location location = new Location();
            bool result = location.CheckStateFIPSExistance();
        }

        [Test]
        public void CheckStateFIPSExistenceValidFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            bool result = location.CheckStateFIPSExistance();
        }

        [Test]
        public void CheckStateFIPSExistenceInvalidFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            bool result = location.CheckStateFIPSExistance();
        }

        [Test]
        public void CheckStateFIPSExistenceValidFIPSCodeSpecified_SecondOverload()
        {
            Location location = new Location();
            bool result = location.CheckStateFIPSExistance(6);
        }

        [Test]
        public void CheckStateFIPSExistenceInvalidFIPSCodeSpecified_SecondOverload()
        {
            Location location = new Location();
            bool result = location.CheckStateFIPSExistance(999);
        }

        [Test]
        public void CheckCountyFIPSExistenceNoStateFIPSSpecifiedNoCountyFIPSSpecified()
        {
            Location location = new Location();
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceStateFIPSSpecifiedNoCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceNoStateFIPSSpecifiedCountyFIPSSpecified()
        {
            Location location = new Location();
            location.CountyFIPS = 45;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceValidStateFIPSSpecifiedValidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            location.CountyFIPS = 45;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceValidStateFIPSSpecifiedInvalidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            location.CountyFIPS = 999;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceInvalidStateFIPSSpecifiedValidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            location.CountyFIPS = 45;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistenceInvalidStateFIPSSpecifiedInvalidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            location.CountyFIPS = 999;
            bool result = location.CheckCountyFIPSExistance();
        }

        [Test]
        public void CheckCountyFIPSExistanceNoStateFIPSSpecified()
        {
            Location location = new Location();
            bool result = location.CheckCountyFIPSExistance(45);
        }

        [Test]
        public void CheckCountyFIPSExistanceValidStateFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            bool result = location.CheckCountyFIPSExistance(45);
        }

        [Test]
        public void CheckCountyFIPSExistanceInvalidStateFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            bool result = location.CheckCountyFIPSExistance(45);
        }

        [Test]
        public void CheckCountyFIPSExistanceValidStateFIPSValidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            bool result = location.CheckCountyFIPSExistance(45);
        }

        [Test]
        public void CheckCountyFIPSExistanceValidStateFIPSInvalidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            bool result = location.CheckCountyFIPSExistance(999);
        }

        [Test]
        public void CheckCountyFIPSExistanceInvalidStateFIPSValidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            bool result = location.CheckCountyFIPSExistance(45);
        }

        [Test]
        public void CheckCountyFIPSExistanceInvalidStateFIPSInvalidCountyFIPSSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            bool result = location.CheckCountyFIPSExistance(999);
        }

        [Test]
        public void GetStateNameFromFIPSCodeNoStateFIPSCodeSpecified()
        {
            Location location = new Location();
            string result = location.GetStateNameFromFIPSCode();
        }

        [Test]
        public void GetStateNameFromFIPSCodeValidStateFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            string result = location.GetStateNameFromFIPSCode();
        }

        [Test]
        public void GetStateNameFromFIPSCodeInvalidStateFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            string result = location.GetStateNameFromFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeNoStateFIPSCodeNoCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeStateFIPSCodeNoCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeNoStateFIPSCodeCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.CountyFIPS = 45;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeValidStateFIPSCodeValidCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 45;
            location.CountyFIPS = 6;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeValidStateFIPSCodeInvalidCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 6;
            location.CountyFIPS = 999;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeInvalidStateFIPSCodeValidCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            location.CountyFIPS = 45;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }

        [Test]
        public void GetCountyNameFromStateAndCountyFIPSCodeInvalidStateFIPSCodeInvalidCountyFIPSCodeSpecified()
        {
            Location location = new Location();
            location.StateFIPS = 999;
            location.CountyFIPS = 999;
            string result = location.GetCountyNameFromStateAndCountyFIPSCode();
        }
    }
}