using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace artefact.classes
{
    public class EventType
    {
        private bool isAstronomicalLowTideSelected;
        private bool isAvalancheSelected;
        private bool isBlizzardSelected;
        private bool isCoastalFloodSelected;
        private bool isColdWindChillSelected;
        private bool isDebrisFlowSelected;
        private bool isDenseFogSelected;
        private bool isDenseSmokeSelected;
        private bool isDroughtSelected;
        private bool isDustDevilSelected;
        private bool isDustStormSelected;
        private bool isExcessiveHeatSelected;
        private bool isExtremeColdWindChillSelected;
        private bool isFlashFloodSelected;
        private bool isFloodSelected;
        private bool isFreezingFogSelected;
        private bool isFrostFreezeSelected;
        private bool isFunnelCloudSelected;
        private bool isHailSelected;
        private bool isHeatSelected;
        private bool isHeavyRainSelected;
        private bool isHeavySnowSelected;
        private bool isHeavyWindSelected;
        private bool isHighSnowSelected;
        private bool isHighSurfSelected;
        private bool isHighWindSelected;
        private bool isHurricaneSelected;
        private bool isIceStormSelected;
        private bool isLakeEffectSnowSelected;
        private bool isLakeshoreFloodSelected;
        private bool isLandslideSelected;
        private bool isLightningSelected;
        private bool isMarineDenseFogSelected;
        private bool isMarineHailSelected;
        private bool isMarineHighWindSelected;
        private bool isMarineStrongWindSelected;
        private bool isMarineThunderstormWindSelected;
        private bool isMarineTropicalStormSelected;
        private bool isNorthernLightsSelected;
        private bool isOtherSelected;
        private bool isRipCurrentSelected;
        private bool isSeicheSelected;
        private bool isSleetSelected;
        private bool isStormSurgeTideSelected;
        private bool isStrongWindSelected;
        private bool isThunderstormWindSelected;
        private bool isTornadoSelected;
        private bool isTropicalDepressionSelected;
        private bool isTropicalStormSelected;
        private bool isTsunamiSelected;
        private bool isVolcanicAshSelected;
        private bool isVolcanicAshfallSelected;
        private bool isWaterspoutSelected;
        private bool isWildfireSelected;
        private bool isWinterStormSelected;
        private bool isWinterWeatherSelected;

        private bool eventTypeSelected = false;

        #region Properties
        /// <summary>
        /// Is Astronomical Low Tide Selected
        /// </summary>
        public bool IsAstronomicalLowTideSelected
        {
            get
            {
                return this.isAstronomicalLowTideSelected;
            }
            set
            {
                this.isAstronomicalLowTideSelected = value;
            }
        }

        /// <summary>
        ///Is Avalanche Selected Property
        /// </summary>
        public bool IsAvalancheSelected
        {
            get
            {
                return this.isAvalancheSelected;
            }
            set
            {
                this.isAvalancheSelected = value;
            }
        }

        /// <summary>
        ///Is Blizzard Selected Property
        /// </summary>
        public bool IsBlizzardSelected
        {
            get
            {
                return this.isBlizzardSelected;
            }
            set
            {
                this.isBlizzardSelected = value;
            }
        }

        /// <summary>
        ///Is Coastal Flood Selected Property
        /// </summary>
        public bool IsCoastalFloodSelected
        {
            get
            {
                return this.isCoastalFloodSelected;
            }
            set
            {
                this.isCoastalFloodSelected = value;
            }
        }

        /// <summary>
        ///Is Cold/Wind Chill Selected Property
        /// </summary>
        public bool IsColdWindChillSelected
        {
            get
            {
                return this.isColdWindChillSelected;
            }
            set
            {
                this.isColdWindChillSelected = value;
            }
        }

        /// <summary>
        ///Is Debris Flow Selected Property
        /// </summary>
        public bool IsDebrisFlowSelected
        {
            get
            {
                return this.isDebrisFlowSelected;
            }
            set
            {
                this.isDebrisFlowSelected = value;
            }
        }

        /// <summary>
        ///Is Dense Fog Selected Property
        /// </summary>
        public bool IsDenseFogSelected
        {
            get
            {
                return this.isDenseFogSelected;
            }
            set
            {
                this.isDenseFogSelected = value;
            }
        }

        /// <summary>
        ///Is Dense Smoke Selected Property
        /// </summary>
        public bool IsDenseSmokeSelected
        {
            get
            {
                return this.isDenseSmokeSelected;
            }
            set
            {
                this.isDenseSmokeSelected = value;
            }
        }

        /// <summary>
        ///Is Drought Selected Property
        /// </summary>
        public bool IsDroughtSelected
        {
            get
            {
                return this.isDroughtSelected;
            }
            set
            {
                this.isDroughtSelected = value;
            }
        }

        /// <summary>
        ///Is Dust Devil Selected Property
        /// </summary>
        public bool IsDustDevilSelected
        {
            get
            {
                return this.isDustDevilSelected;
            }
            set
            {
                this.isDustDevilSelected = value;
            }
        }

        /// <summary>
        ///Is Dust Storm Selected Property
        /// </summary>
        public bool IsDustStormSelected
        {
            get
            {
                return this.isDustStormSelected;
            }
            set
            {
                this.isDustStormSelected = value;
            }
        }

        /// <summary>
        ///Is Excessive Heat Selected Property
        /// </summary>
        public bool IsExcessiveHeatSelected
        {
            get
            {
                return this.isExcessiveHeatSelected;
            }
            set
            {
                this.isExcessiveHeatSelected = value;
            }
        }

        /// <summary>
        ///Is Extreme Cold/Wind Chill Selected Property
        /// </summary>
        public bool IsExtremeColdWindChillSelected
        {
            get
            {
                return this.isExtremeColdWindChillSelected;
            }
            set
            {
                this.isExtremeColdWindChillSelected = value;
            }
        }

        /// <summary>
        ///Is Flash Flood Selected Property
        /// </summary>
        public bool IsFlashFloodSelected
        {
            get
            {
                return this.isFlashFloodSelected;
            }
            set
            {
                this.isFlashFloodSelected = value;
            }
        }

        /// <summary>
        ///Is Flood Selected Property
        /// </summary>
        public bool IsFloodSelected
        {
            get
            {
                return this.isFloodSelected;
            }
            set
            {
                this.isFloodSelected = value;
            }
        }

        /// <summary>
        ///Is Freezing Fog Selected Property
        /// </summary>
        public bool IsFreezingFogSelected
        {
            get
            {
                return this.isFreezingFogSelected;
            }
            set
            {
                this.isFreezingFogSelected = value;
            }
        }

        /// <summary>
        ///Is Frost/Freeze Selected Property
        /// </summary>
        public bool IsFrostFreezeSelected
        {
            get
            {
                return this.isFrostFreezeSelected;
            }
            set
            {
                this.isFrostFreezeSelected = value;
            }
        }

        /// <summary>
        ///Is Funnel Cloud Selected Property
        /// </summary>
        public bool IsFunnelCloudSelected
        {
            get
            {
                return this.isFunnelCloudSelected;
            }
            set
            {
                this.isFunnelCloudSelected = value;
            }
        }

        /// <summary>
        ///Is Hail Selected Property
        /// </summary>
        public bool IsHailSelected
        {
            get
            {
                return this.isHailSelected;
            }
            set
            {
                this.isHailSelected = value;
            }
        }

        /// <summary>
        ///Is Heat Selected Property
        /// </summary>
        public bool IsHeatSelected
        {
            get
            {
                return this.isHeatSelected;
            }
            set
            {
                this.isHeatSelected = value;
            }
        }

        /// <summary>
        ///Is Heavy Rain Selected Property
        /// </summary>
        public bool IsHeavyRainSelected
        {
            get
            {
                return this.isHeavyRainSelected;
            }
            set
            {
                this.isHeavyRainSelected = value;
            }
        }

        /// <summary>
        ///Is Heavy Snow Selected Property
        /// </summary>
        public bool IsHeavySnowSelected
        {
            get
            {
                return this.isHeavySnowSelected;
            }
            set
            {
                this.isHeavySnowSelected = value;
            }
        }

        /// <summary>
        ///Is Heavy Wind Selected Property
        /// </summary>
        public bool IsHeavyWindSelected
        {
            get
            {
                return this.isHeavyWindSelected;
            }
            set
            {
                this.isHeavyWindSelected = value;
            }
        }

        /// <summary>
        ///Is High Snow Selected Property
        /// </summary>
        public bool IsHighSnowSelected
        {
            get
            {
                return this.isHighSnowSelected;
            }
            set
            {
                this.isHighSnowSelected = value;
            }
        }

        /// <summary>
        ///Is High Surf Selected Property
        /// </summary>
        public bool IsHighSurfSelected
        {
            get
            {
                return this.isHighSurfSelected;
            }
            set
            {
                this.isHighSurfSelected = value;
            }
        }

        /// <summary>
        ///Is High Wind Selected Property
        /// </summary>
        public bool IsHighWindSelected
        {
            get
            {
                return this.isHighWindSelected;
            }
            set
            {
                this.isHighWindSelected = value;
            }
        }

        /// <summary>
        ///Is Hurricane Selected Property
        /// </summary>
        public bool IsHurricaneSelected
        {
            get
            {
                return this.isHurricaneSelected;
            }
            set
            {
                this.isHurricaneSelected = value;
            }
        }

        /// <summary>
        ///Is Ice Storm Selected Property
        /// </summary>
        public bool IsIceStormSelected
        {
            get
            {
                return this.isIceStormSelected;
            }
            set
            {
                this.isIceStormSelected = value;
            }
        }

        /// <summary>
        ///Is Lake-Effect Snow Selected Property
        /// </summary>
        public bool IsLakeEffectSnowSelected
        {
            get
            {
                return this.isLakeEffectSnowSelected;
            }
            set
            {
                this.isLakeEffectSnowSelected = value;
            }
        }

        /// <summary>
        ///Is Lakeshore Flood Selected Property
        /// </summary>
        public bool IsLakeshoreFloodSelected
        {
            get
            {
                return this.isLakeshoreFloodSelected;
            }
            set
            {
                this.isLakeshoreFloodSelected = value;
            }
        }

        /// <summary>
        ///Is Landslide Selected Property
        /// </summary>
        public bool IsLandslideSelected
        {
            get
            {
                return this.isLandslideSelected;
            }
            set
            {
                this.isLandslideSelected = value;
            }
        }

        /// <summary>
        ///Is Lightning Selected Property
        /// </summary>
        public bool IsLightningSelected
        {
            get
            {
                return this.isLightningSelected;
            }
            set
            {
                this.isLightningSelected = value;
            }
        }

        /// <summary>
        ///Is Marine Dense Fog Selected Property
        /// </summary>
        public bool IsMarineDenseFogSelected
        {
            get
            {
                return this.isMarineDenseFogSelected;
            }
            set
            {
                this.isMarineDenseFogSelected = value;
            }
        }

        /// <summary>
        ///Is Marine Hail Selected Property
        /// </summary>
        public bool IsMarineHailSelected
        {
            get
            {
                return this.isMarineHailSelected;
            }
            set
            {
                this.isMarineHailSelected = value;
            }
        }

        /// <summary>
        ///Is Marine High Wind Selected Property
        /// </summary>
        public bool IsMarineHighWindSelected
        {
            get
            {
                return this.isMarineHighWindSelected;
            }
            set
            {
                this.isMarineHighWindSelected = value;
            }
        }

        /// <summary>
        ///Is Marine Strong Wind Selected Property
        /// </summary>
        public bool IsMarineStrongWindSelected
        {
            get
            {
                return this.isMarineStrongWindSelected;
            }
            set
            {
                this.isMarineStrongWindSelected = value;
            }
        }

        /// <summary>
        ///Is Marine Thunderstorm Wind Selected Property
        /// </summary>
        public bool IsMarineThunderstormWindSelected
        {
            get
            {
                return this.isMarineThunderstormWindSelected;
            }
            set
            {
                this.isMarineThunderstormWindSelected = value;
            }
        }

        /// <summary>
        ///Is Marine Tropical Storm Selected Property
        /// </summary>
        public bool IsMarineTropicalStormSelected
        {
            get
            {
                return this.isMarineTropicalStormSelected;
            }
            set
            {
                this.isMarineTropicalStormSelected = value;
            }
        }

        /// <summary>
        ///Is Northern Lights Selected Property
        /// </summary>
        public bool IsNorthernLightsSelected
        {
            get
            {
                return this.isNorthernLightsSelected;
            }
            set
            {
                this.isNorthernLightsSelected = value;
            }
        }

        /// <summary>
        ///Is Other Selected Property
        /// </summary>
        public bool IsOtherSelected
        {
            get
            {
                return this.isOtherSelected;
            }
            set
            {
                this.isOtherSelected = value;
            }
        }

        /// <summary>
        ///Is Rip Current Selected Property
        /// </summary>
        public bool IsRipCurrentSelected
        {
            get
            {
                return this.isRipCurrentSelected;
            }
            set
            {
                this.isRipCurrentSelected = value;
            }
        }

        /// <summary>
        ///Is Seiche Selected Property
        /// </summary>
        public bool IsSeicheSelected
        {
            get
            {
                return this.isSeicheSelected;
            }
            set
            {
                this.isSeicheSelected = value;
            }
        }

        /// <summary>
        ///Is Sleet Selected Property
        /// </summary>
        public bool IsSleetSelected
        {
            get
            {
                return this.isSleetSelected;
            }
            set
            {
                this.isSleetSelected = value;
            }
        }

        /// <summary>
        ///Is Storm Surge/Tide Selected Property
        /// </summary>
        public bool IsStormSurgeTideSelected
        {
            get
            {
                return this.isStormSurgeTideSelected;
            }
            set
            {
                this.isStormSurgeTideSelected = value;
            }
        }

        /// <summary>
        ///Is Strong Wind Selected Property
        /// </summary>
        public bool IsStrongWindSelected
        {
            get
            {
                return this.isStrongWindSelected;
            }
            set
            {
                this.isStrongWindSelected = value;
            }
        }

        /// <summary>
        ///Is Thunderstorm Wind Selected Property
        /// </summary>
        public bool IsThunderstormWindSelected
        {
            get
            {
                return this.isThunderstormWindSelected;
            }
            set
            {
                this.isThunderstormWindSelected = value;
            }
        }

        /// <summary>
        ///Is Tornado Selected Property
        /// </summary>
        public bool IsTornadoSelected
        {
            get
            {
                return this.isTornadoSelected;
            }
            set
            {
                this.isTornadoSelected = value;
            }
        }

        /// <summary>
        ///Is Tropical Depression Selected Property
        /// </summary>
        public bool IsTropicalDepressionSelected
        {
            get
            {
                return this.isTropicalDepressionSelected;
            }
            set
            {
                this.isTropicalDepressionSelected = value;
            }
        }

        /// <summary>
        ///Is Tropical Storm Selected Property
        /// </summary>
        public bool IsTropicalStormSelected
        {
            get
            {
                return this.isTropicalStormSelected;
            }
            set
            {
                this.isTropicalStormSelected = value;
            }
        }

        /// <summary>
        ///Is Tsunami Selected Property
        /// </summary>
        public bool IsTsunamiSelected
        {
            get
            {
                return this.isTsunamiSelected;
            }
            set
            {
                this.isTsunamiSelected = value;
            }
        }

        /// <summary>
        ///Is Volcanic Ash Selected Property
        /// </summary>
        public bool IsVolcanicAshSelected
        {
            get
            {
                return this.isVolcanicAshSelected;
            }
            set
            {
                this.isVolcanicAshSelected = value;
            }
        }

        /// <summary>
        ///Is Volcanic Ashfall Selected Property
        /// </summary>
        public bool IsVolcanicAshfallSelected
        {
            get
            {
                return this.isVolcanicAshfallSelected;
            }
            set
            {
                this.isVolcanicAshfallSelected = value;
            }
        }

        /// <summary>
        ///Is Waterspout Selected Property
        /// </summary>
        public bool IsWaterspoutSelected
        {
            get
            {
                return this.isWaterspoutSelected;
            }
            set
            {
                this.isWaterspoutSelected = value;
            }
        }

        /// <summary>
        ///Is Wildfire Selected Property
        /// </summary>
        public bool IsWildfireSelected
        {
            get
            {
                return this.isWildfireSelected;
            }
            set
            {
                this.isWildfireSelected = value;
            }
        }

        /// <summary>
        ///Is Winter Storm Selected Property
        /// </summary>
        public bool IsWinterStormSelected
        {
            get
            {
                return this.isWinterStormSelected;
            }
            set
            {
                this.isWinterStormSelected = value;
            }
        }

        /// <summary>
        ///Is Winter Weather Selected Property
        /// </summary>
        public bool IsWinterWeatherSelected
        {
            get
            {
                return this.isWinterWeatherSelected;
            }
            set
            {
                this.isWinterWeatherSelected = value;
            }
        }
        #endregion

        /// <summary>
        /// Generate a customised query based on selected event types on the form.
        /// </summary>
        /// <param name="isFirstWhereClauseAlreadyAdded">A boolean representation of whether the first where cluase has already been added to this query statement.</param>
        /// <param name="isFirstInStatementAlreadyAdded">A boolean representation of whether the first IN parameter has already been added to this query statement.</param>
        /// <param name="query">The current query string.</param>
        /// <returns>A customised query string that will search for the event types currently selected.</returns>
        public string GenerateEventQuery(ref bool isFirstWhereClauseAlreadyAdded, ref bool isFirstInStatementAlreadyAdded, string query)
        {
            if (this.IsAstronomicalLowTideSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Astronomical Low Tide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Astronomical Low Tide'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Astronomical Low Tide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Astronomical Low Tide'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsAvalancheSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Avalanche'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Avalanche'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Avalanche'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Avalanche'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsBlizzardSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Blizzard'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Blizzard'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Blizzard'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Blizzard'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsCoastalFloodSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Coastal Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Coastal Flood'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Coastal Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Coastal Flood'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsColdWindChillSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Cold/Wind Chill'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Cold/Wind Chill'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Cold/Wind Chill'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Cold/Wind Chill'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDebrisFlowSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Debris Flow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Debris Flow'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Debris Flow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Debris Flow'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDenseFogSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Dense Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dense Fog'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Dense Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dense Fog'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDenseSmokeSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Dense Smoke'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dense Smoke'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Dense Smoke'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dense Smoke'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDroughtSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Drought'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Drought'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Drought'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Drought'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDustDevilSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Dust Devil'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dust Devil'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Dust Devil'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dust Devil'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsDustStormSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Dust Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dust Storm'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Dust Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Dust Storm'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsExcessiveHeatSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Excessive Heat'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Excessive Heat'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Excessive Heat'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Excessive Heat'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsExtremeColdWindChillSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Extreme Cold/Wind Chill'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Extreme Cold/Wind Chill'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Extreme Cold/Wind Chill'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Extreme Cold/Wind Chill'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsFlashFloodSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Flash Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Flash Flood'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Flash Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Flash Flood'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsFloodSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Flood'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Flood'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsFreezingFogSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Freezing Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Freezing Fog'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Freezing Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Freezing Fog'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsFrostFreezeSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Frost/Freeze'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Frost/Freeze'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Frost/Freeze'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Frost/Freeze'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsFunnelCloudSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Funnel Cloud'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Funnel Cloud'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Funnel Cloud'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Funnel Cloud'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHailSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Hail'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Hail'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Hail'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Hail'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHeatSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Heat'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heat'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Heat'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heat'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHeavyRainSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Heavy Rain'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Rain'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Heavy Rain'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Rain'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHeavySnowSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Heavy Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Snow'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Heavy Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Snow'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHeavyWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Heavy Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Heavy Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Heavy Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHighSnowSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('High Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Snow'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('High Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Snow'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHighSurfSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('High Surf'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Surf'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('High Surf'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Surf'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHighWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('High Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('High Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'High Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsHurricaneSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Hurricane'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Hurricane'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Hurricane'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Hurricane'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsIceStormSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Ice Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Ice Storm'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Ice Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Ice Storm'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsLakeEffectSnowSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Lake-Effect Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lake-Effect Snow'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Lake-Effect Snow'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lake-Effect Snow'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsLakeshoreFloodSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Lakeshore Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lakeshore Flood'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Lakeshore Flood'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lakeshore Flood'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsLandslideSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Landslide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Landslide'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Landslide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Landslide'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsLightningSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Lightning'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lightning'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Lightning'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Lightning'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineDenseFogSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine Dense Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Dense Fog'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine Dense Fog'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Dense Fog'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineHailSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine Hail'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Hail'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine Hail'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Hail'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineHighWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine High Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine High Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine High Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine High Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineStrongWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine Strong Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Strong Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine Strong Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Strong Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineThunderstormWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine Thunderstorm Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Thunderstorm Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine Thunderstorm Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Thunderstorm Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsMarineTropicalStormSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Marine Tropical Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Tropical Storm'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Marine Tropical Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Marine Tropical Storm'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsNorthernLightsSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Northern Lights'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Northern Lights'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Northern Lights'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Northern Lights'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsOtherSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Other'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Other'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Other'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Other'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsRipCurrentSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Rip Current'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Rip Current'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Rip Current'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Rip Current'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsSeicheSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Seiche'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Seiche'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Seiche'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Seiche'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsSleetSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Sleet'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Sleet'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Sleet'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Sleet'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsStormSurgeTideSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Storm Surge/Tide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Storm Surge/Tide'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Storm Surge/Tide'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Storm Surge/Tide'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsStrongWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Strong Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Strong Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Strong Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Strong Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsThunderstormWindSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Thunderstorm Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Thunderstorm Wind'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Thunderstorm Wind'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Thunderstorm Wind'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsTornadoSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Tornado'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tornado'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Tornado'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tornado'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsTropicalDepressionSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Tropical Depression'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tropical Depression'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Tropical Depression'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tropical Depression'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsTropicalStormSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Tropical Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tropical Storm'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Tropical Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tropical Storm'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsTsunamiSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Tsunami'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tsunami'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Tsunami'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Tsunami'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsVolcanicAshSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Volcanic Ash'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Volcanic Ash'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Volcanic Ash'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Volcanic Ash'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsVolcanicAshfallSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Volcanic Ashfall'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Volcanic Ashfall'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Volcanic Ashfall'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Volcanic Ashfall'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsWaterspoutSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Waterspout'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Waterspout'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Waterspout'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Waterspout'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsWildfireSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Wildfire'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Wildfire'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Wildfire'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Wildfire'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsWinterStormSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Winter Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Winter Storm'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Winter Storm'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Winter Storm'";
                    }
                }

                eventTypeSelected = true;
            }

            if (this.IsWinterWeatherSelected)
            {
                if (!isFirstWhereClauseAlreadyAdded)
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "WHERE [EventType] IN ('Winter Weather'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Winter Weather'";
                    }
                    isFirstWhereClauseAlreadyAdded = true;
                }
                else
                {
                    if (!isFirstInStatementAlreadyAdded)
                    {
                        query += "AND [EventType] IN ('Winter Weather'";
                        isFirstInStatementAlreadyAdded = true;
                    }
                    else
                    {
                        query += ",'Winter Weather'";
                    }
                }

                eventTypeSelected = true;
            }

            if (eventTypeSelected)
            {
                query += ")";
            }

            return query;
        }
    }
}