using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NUnit.Framework;
using System.Data;

namespace artefact.classes.testing
{
    [TestFixture]
    public class StatisticsTesting
    {
        private DataTable table;

        [Test]
        public void CalculateStatisticsNonNullDataTable()
        {
            table = MakeNonNullDataTable();
            
            Statistics s = new Statistics(table);
            s.CalculateStatistics();
        }

        [Test]
        public void CalculateStatisticsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.CalculateStatistics();
        }

        [Test]
        public void CalculateTotalNumberOfEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.CalculateTotalNumberOfEvents();
        }

        [Test]
        public void CalculateTotalNumberOfEventsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.CalculateTotalNumberOfEvents();
        }

        [Test]
        public void GetDayWithMostEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetDayWithMostEvents();
        }

        [Test]
        public void GetDayWithMostEventsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetDayWithMostEvents();
        }

        [Test]
        public void GetCountOfTornadoEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetCountOfTornadoEvents();
        }

        [Test]
        public void GetCountOfTornadoEventsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetCountOfTornadoEvents();
        }

        [Test]
        public void GetStrongestTornadoNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetStrongestTornado();
        }

        [Test]
        public void GetStrongestTornadoNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetStrongestTornado();
        }

        [Test]
        public void ConvertEnhancedFujitaScaleTornadoIntensitySupplied()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.ConvertEnhancedFujitaScaleToFujitaScale("EF5");
        }

        [Test]
        public void ConvertEnhancedFujitaScaleNoTornadoIntensitySupplied()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.ConvertEnhancedFujitaScaleToFujitaScale("");
        }

        [Test]
        public void GetLongestTornadoNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetLongestTornado();
        }

        [Test]
        public void GetLongestTornadoNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetLongestTornado();
        }

        [Test]
        public void GetWidestTornadoNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetWidestTornado();
        }

        [Test]
        public void GetWidestTornadoNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetWidestTornado();
        }

        [Test]
        public void GetTornadoWithMostInjuriesNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetTornadoWithMostInjuries();
        }

        [Test]
        public void GetTornadoWithMostInjuriesNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetTornadoWithMostInjuries();
        }

        [Test]
        public void GetTornadoWithMostDeathsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetTornadoWithMostDeaths();
        }

        [Test]
        public void GetTornadoWithMostDeathsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetTornadoWithMostDeaths();
        }

        [Test]
        public void GetTornadoWithMostCropDamageNonNullDataTable() {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetTornadoWithMostCropDamage();
        }

        [Test]
        public void GetTornadoWithMostCropDamageNullDataTable() {
            Statistics s = new Statistics(null);
            s.GetTornadoWithMostCropDamage();
        }

        [Test]
        public void GetTornadoWithMostPropertyDamageNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetTornadoWithMostPropertyDamage();
        }

        [Test]
        public void GetTornadoWithMostPropertyDamageNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetTornadoWithMostPropertyDamage();
        }

        [Test]
        public void ConvertValueStringToDoubleValidDamamgeValue()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            double result = s.ConvertValueStringToDouble("10K");
        }

        [Test]
        public void ConvertValueStringToDoubleInvalidDamamgeValue()
        {
            Statistics s = new Statistics(table);
            double result = s.ConvertValueStringToDouble("");
        }

        [Test]
        public void GetHighestCropDamageEventNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetHighestCropDamageEvent();
        }

        [Test]
        public void GetHighestCropDamageEventNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetHighestCropDamageEvent();
        }

        [Test]
        public void GetHighestPropertyDamageEventNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetHighestPropertyDamageEvent();
        }

        [Test]
        public void GetHighestPropertyDamageEventNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetHighestPropertyDamageEvent();
        }

        [Test]
        public void GetDayWithMostPropertyDamageEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetDayWithMostPropertyDamageEvents();
        }

        [Test]
        public void GetDayWithMostPropertyDamageEventsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetDayWithMostPropertyDamageEvents();
        }

        [Test]
        public void GetDayWithMostCropDamageEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetDayWithMostCropDamageEvents();
        }

        [Test]
        public void GetDayWithMostCropDamageEventsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetDayWithMostCropDamageEvents();
        }

        [Test]
        public void GetEventWithMostDeathsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetEventWithMostDeaths();
        }

        [Test]
        public void GetEventWithMostDeathsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetEventWithMostDeaths();
        }

        [Test]
        public void GetDayWithMostDeathsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetDayWithMostDeaths();
        }

        [Test]
        public void GetDayWithMostDeathsNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetDayWithMostDeaths();
        }

        [Test]
        public void GetEventWithMostInjuriesNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetEventWithMostInjuries();
        }

        [Test]
        public void GetEventWithMostInjuriesNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetEventWithMostInjuries();
        }

        [Test]
        public void GetDayWithMostInjuriesNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetDayWithMostInjuries();
        }

        [Test]
        public void GetDayWithMostInjuriesNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetDayWithMostInjuries();
        }

        /*[Test]
        public void GetStateWithMostEventsNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetStateWithMostEvents();
        }

        [Test]
        public void GetStateWithMostEventsNullDataTable()
        {
            Statistics s = new Statistics(table);
            s.GetStateWithMostEvents();
        }*/

        [Test]
        public void GetCountOfEventsPerStateNonNullDataTable()
        {
            table = MakeNonNullDataTable();

            Statistics s = new Statistics(table);
            s.GetCountOfEventsPerState();
        }

        [Test]
        public void GetCountOfEventsPerStateNullDataTable()
        {
            Statistics s = new Statistics(null);
            s.GetCountOfEventsPerState();
        }

        public DataTable MakeNonNullDataTable()
        {
            table = new DataTable();
            DataRow row = table.NewRow();
            row[0] = "Test";
            table.Rows.Add(row);

            return table;
        }
    }
}