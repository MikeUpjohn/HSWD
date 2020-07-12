<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="us-severe-weather-database.aspx.cs" Inherits="artefact.us_severe_weather_database.us_severe_weather_database" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    U.S. Severe Weather Database
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="../styles/main.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/table-styles.css" />
    <link type='text/css' rel='Stylesheet' href="../styles/form.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/us-severe-weather-database.css" />
    <link type="text/css" rel="Stylesheet" href="../styles/results-table.css" />
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCw0QcIo79vl6vEPtRFr1Fm6g9nf9l8VVQ&amp;sensor=true"></script>
    <script type="text/javascript" src="../scripts/map-resize.js"/></script>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>U.S. Severe Weather Database</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <div id="queryContainer">    
        <asp:Panel ID="Panel_QueryWindow" runat="server" DefaultButton="Button_RunQuery">
            <asp:Panel ID="Panel_ValidationErrors" runat="server" CssClass="validation-errors-red" Visible="False">
                <asp:Label ID="Label_ValidationErrors" runat="server" Text="" CssClass="validation-error-text-red" Visible="False"></asp:Label>
            </asp:Panel>
            <div id='results'>
                <div id="map"></div>
                <div id='statistics'>
                    <table class='statisticsTable'>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_DataStatisticsHeader" runat="server" 
                                    Text="Data Statistics" Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_NumberOfEventsRetrievedText" runat="server" 
                                    Text="Number of Events Retrieved: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NumberOfEventsRetrievedValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='6'>
                                <asp:Label ID="Label_DayWithMostEventsText" runat="server" 
                                    Text="Day With Most Events: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DayWithMostEventsValue" runat="server" Text="01 January 2012"></asp:Label>
                            </td>
                        </tr>
                        <tr class='spacerRow'>
                            <td colspan='9'></td>
                        </tr>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_TornadoStatisticsHeader" runat="server" 
                                    Text="Tornado Statistics" Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_TotalTornadoEventsText" runat="server" 
                                    Text="Total Tornado Events: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TotalTornadoEventsValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='3'>
                                <asp:Label ID="Label_StrongestTornadoText" runat="server" 
                                    Text="Strongest Tornado: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_StrongestTornadoValue" runat="server" Text="F0 / EF0"></asp:Label>
                            </td>
                            <td colspan='3'>
                                <asp:Label ID="Label_WidestTornadoText" runat="server" Text="Widest Tornado: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_WidestTornadoValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_LongestTornadoText" runat="server" 
                                    Text="Longest Tornado: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_LongestTornadoValue" runat="server" Text="0.0"></asp:Label>
                            </td>
                            <td colspan='3'>
                                <asp:Label ID="Label_TornadoWithMostInjuriesText" runat="server" 
                                    Text="Tornado With Most Injuries: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TornadoWithMostInjuriesValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='3'>
                                <asp:Label ID="Label_TornadoWithMostDeathsText" runat="server" 
                                    Text="Tornado With Most Deaths:" Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TornadoWithMostDeathsValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_TornadoWithMostCropDamageText" runat="server" 
                                    Text="Tornado With Most Crop Damage: $" Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TornadoWithMostCropDamageValue" runat="server" Text="0.0K"></asp:Label>
                            </td>
                            <td colspan='6'>
                                <asp:Label ID="Label_TornadoWithMostPropertyDamageText" runat="server" 
                                    Text="Tornado With Most Property Damage: $" Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TornadoWithMostPropertyDamageValue" runat="server" Text="0.0K"></asp:Label>
                            </td>
                        </tr>
                        <tr class='spacerRow'>
                            <td colspan='9'></td>
                        </tr>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_PropertyDamageStatistics" runat="server" 
                                    Text="Property Damage Statistics" Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_HighestPropertyDamageEventText" runat="server" 
                                    Text="Highest Property Damage Event: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_HighestPropertyDamageEventValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='6'>
                                <asp:Label ID="Label_DayWithMaximumNumberOfPropertyDamagesText" runat="server" 
                                    Text="Day With Maximum Number Of Property Damages: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DayWithMaximumNumberOfPropertyDamagesValue" runat="server" Text="01 January 2012"></asp:Label>
                            </td>
                        </tr>
                        <tr class='spacerRow'>
                            <td colspan='9'></td>
                        </tr>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_CropDamageStatistics" runat="server" 
                                    Text="Crop Damage Statistics" Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_HighestCropDamageEventText" runat="server" 
                                    Text="Highest Crop Damage Event: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_HighestCropDamageEventValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='6'>
                                <asp:Label ID="Label_DayWithMaximumNumberOfCropDamagesText" runat="server" 
                                    Text="Day With Maximum Number Of Crop Damages: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DayWithMaximumNumberOfCropDamagesValue" runat="server" Text="01 January 2012"></asp:Label>
                            </td>
                        </tr>
                        <tr class='spacerRow'>
                            <td colspan='9'></td>
                        </tr>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_DeathStatistics" runat="server" Text="Death Statistics" 
                                    Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td colspan='3'>
                                <asp:Label ID="Label_EventWithMostDeathsText" runat="server" 
                                    Text="Event with Most Deaths: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_EventWithMostDeathsValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='6'>
                                <asp:Label ID="Label_DayWithMostDeathsText" runat="server" 
                                    Text="Day With Most Deaths: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DayWithMostDeathsValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <!--<tr>
                            <td colspan='9'>
                                <asp:Label ID="Label_NumberOfDeathsSubHeading" runat="server" 
                                    Text="Number of Deaths: " Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                            <td colspan='2'>
                                <asp:Label ID="Label_DeathsLessThanThirteenYearsOldText" runat="server" 
                                    Text="Less Than 13 Year Old: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DeathsLessThanThirteenYearsOldValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='2'>
                                <asp:Label ID="Label_DeathsThirteenToTwentyFourYearsOldText" runat="server" 
                                    Text="13 to 24 Years Old: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DeathsThirteenToTwentyFourYearsOldValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='2'>
                                <asp:Label ID="Label_DeathsTwentyFiveToSixtyFourYearsOldText" runat="server" 
                                    Text="25 to 64 Year Old: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DeathsTwentyFiveToSixtyFourYearsOldValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='2'>
                                <asp:Label ID="Label_DeathsSixtyFiveYearsOldOrMoreText" runat="server" 
                                    Text="65 Years Old or More: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DeathsSixtyFiveYearsOldOrMoreValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>-->
                        <tr class='spacerRow'>
                            <td colspan='9'></td>
                        </tr>
                        <tr>
                            <td colspan='9'>
                                <asp:Label ID="label_StatisticsByStateHeader" runat="server" 
                                    Text="Statistics By State" Font-Bold="True" Font-Underline="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_AlabamaCountText" runat="server" Text="Alabama: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_AlabamaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_AlaskaCountText" runat="server" Text="Alaska: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_AlaskaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_ArizonaCountText" runat="server" Text="Arizona: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_ArizonaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_ArkansasCountText" runat="server" Text="Arkansas: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_ArkansasCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_CaliforniaCountText" runat="server" Text="California: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_CaliforniaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_ColoradoCountText" runat="server" Text="Colorado: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_ColoradoCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_ConnecticutCountText" runat="server" Text="Connecticut: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_ConnecticutCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_DelawareCountText" runat="server" Text="Delaware: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DelawareCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_DistrictOfColumbiaText" runat="server" Text="District of Columbia: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_DistrictOfColumbiaValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_FloridaCountText" runat="server" Text="Florida: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_FloridaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_GeorgiaCountText" runat="server" Text="Georgia: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_GeorgiaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_HawaiiCountText" runat="server" Text="Hawaii: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_HawaiiCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_IdahoCountText" runat="server" Text="Idaho: "  Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_IdahoCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_IllinoisCountText" runat="server" Text="Illinois: "  Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_IllinoisCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_IndianaCountText" runat="server" Text="Indiana: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_IndianaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_IowaCountText" runat="server" Text="Iowa: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_IowaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td class="style1">
                                <asp:Label ID="Label_KansasCountText" runat="server" Text="Kansas: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_KansasCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_KentuckyCountText" runat="server" Text="Kentucky: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_KentuckyCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_LouisianaCountText" runat="server" Text="Louisiana: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_LouisianaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MaineCountText" runat="server" Text="Maine: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MaineCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MarylandCountText" runat="server" Text="Maryland: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MarylandCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MassachusettsCountText" runat="server" Text="Massachusetts: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MassachusettsCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MichiganCountText" runat="server" Text="Michigan: "  Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MichiganCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MinnesotaCountText" runat="server" Text="Minnesota: "  Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MinnesotaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MississippiCountText" runat="server" Text="Mississippi: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MississippiCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MissouriCountText" runat="server" Text="Missouri: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MissouriCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_MontanaCountText" runat="server" Text="Montana: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_MontanaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_NebraskaCountText" runat="server" Text="Nebraska: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NebraskaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NevadaCountText" runat="server" Text="Nevada: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NevadaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NewHampshireCountText" runat="server" Text="New Hampshire: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NewHampshireCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NewJerseyCountText" runat="server" Text="New Jersey: "  Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NewJerseyCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NewMexicoCountText" runat="server" Text="New Mexico: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NewMexicoCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NewYorkCountText" runat="server" Text="New York: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NewYorkCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NorthCarolinaCountText" runat="server" Text="North Carolina: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NorthCarolinaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_NorthDakotaCountText" runat="server" Text="North Dakota: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_NorthDakotaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_OhioCountText" runat="server" Text="Ohio: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_OhioCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_OklahomaCountText" runat="server" Text="Oklahoma: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_OklahomaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_OregonCountText" runat="server" Text="Oregon: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_OregonCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_PennsylvaniaCountText" runat="server" Text="Pennsylvania: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_PennsylvaniaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_RhodeIslandCountText" runat="server" Text="Rhode Island: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_RhodeIslandCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_SouthCarolinaCountText" runat="server" Text="South Carolina: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_SouthCarolinaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_SouthDakotaCountText" runat="server" Text="South Dakota: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_SouthDakotaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_TennesseeCountText" runat="server" Text="Tennessee: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TennesseeCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_TexasCountText" runat="server" Text="Texas: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_TexasCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_UtahCountText" runat="server" Text="Utah: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_UtahCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_VermontCountText" runat="server" Text="Vermont: " Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_VermontCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_VirginiaCountText" runat="server" Text="Virginia: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_VirginiaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_WashingtonCountText" runat="server" Text="Washington: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_WashingtonCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_WestVirginiaCountText" runat="server" Text="West Virginia: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_WestVirginiaCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_WisconsinCountText" runat="server" Text="Wisconsin: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_WisconsinCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="Label_WyomingCountText" runat="server" Text="Wyoming: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_WyomingCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                            <td colspan='3'>
                                <asp:Label ID="Label_PuertoRicoCountText" runat="server" Text="Puerto Rico: " 
                                    Font-Bold="True"></asp:Label>
                                <asp:Label ID="Label_PuertoRicoCountValue" runat="server" Text="0"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
                <div id='resultsTable'>
                <asp:Table ID="Table_Results" runat="server" CssClass="resultsTable">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell CssClass="eventNumber">ID</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="dateTime">Date Time</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="state">State</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="county">County</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="eventType">Event Type</asp:TableHeaderCell>
                        <asp:TableHeaderCell CssClass="eventDescription">Event Description</asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
            </div>
            <div id="query">
                <h4>Date Criteria</h4>
                <div id='dateCriteria'>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label_FromDate" runat="server" Text="From:" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox_FromDay" runat="server" CssClass="twoDigit"></asp:TextBox> / 
                                <asp:TextBox ID="TextBox_FromMonth" runat="server" CssClass="twoDigit"></asp:TextBox> / 
                                <asp:TextBox ID="TextBox_FromYear" runat="server" CssClass="fourDigit"></asp:TextBox><br />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_ToDate" runat="server" Text="To:" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox_ToDay" runat="server" CssClass="twoDigit"></asp:TextBox> / 
                                <asp:TextBox ID="TextBox_ToMonth" runat="server" CssClass="twoDigit"></asp:TextBox> / 
                                <asp:TextBox ID="TextBox_ToYear" runat="server" CssClass="fourDigit"></asp:TextBox><br />
                            </td>
                        </tr>
                    </table>
                </div>
                <h4>Location Criteria</h4>
                <div id='locationCriteria'>
                    <table>
                        <tr>
                            <td>
                                <asp:Label ID="Label_State" runat="server" Text="State:" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList_States" runat="server" AutoPostBack="True" 
                                    onselectedindexchanged="DropDownList_States_SelectedIndexChanged"></asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label_County" runat="server" Text="County:" Font-Bold="True"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownList_County" runat="server"></asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </div>
                <h4>Location Criteria by FIPS Codes</h4>
                <div id='locationFIPS'>
                    <asp:CheckBox ID="CheckBox_EnableFIPSCodes" runat="server" AutoPostBack="True" oncheckedchanged="CheckBox_EnableFIPSCodes_CheckedChanged" 
                        Text="Enable FIPS Codes" />
                    <table class='centeredQueryTable'>
                        <!--<tr>
                            <td colspan='2'>
                                
                            </td>
                        </tr>-->
                        <tr>
                            <td class='centeredLabel'>
                                <asp:Label ID="Label_StateFIPS" runat="server" Text="State FIPS" 
                                    Font-Bold="True"></asp:Label>
                            </td>
                            <td class='centeredLabel'>
                                <asp:Label ID="Label_CountyFIPS" runat="server" Text="County FIPS" 
                                    Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:TextBox ID="TextBox_StateFIPS" runat="server" CssClass="stateFIPSCode">0</asp:TextBox>
                            </td>
                            <td>
                                <asp:TextBox ID="TextBox_CountyFIPS" runat="server" CssClass="countyFIPSCode">0</asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div>
                <h4>Event Types</h4>
                <div id='eventTypes'>
                    <div id='leftColumn'>
                        <asp:CheckBox ID="CheckBox_AstronomicalLowTide" runat="server" Text="Astronomical Low Tide" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Blizzard" runat="server" Text="Blizzard" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_ColdWindChill" runat="server" Text="Cold/Wind Chill" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_DenseFog" runat="server" Text="Dense Fog" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Drought" runat="server" Text="Drought" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_DustStorm" runat="server" Text="Dust Storm" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_ExtremeColdWindChill" runat="server" Text="Extreme Cold/Wind Chill" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Flood" runat="server" Text="Flood" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_FrostFreeze" runat="server" Text="Frost/Freeze" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Hail" runat="server" Text="Hail" 
                            CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HeavyRain" runat="server" Text="Heavy Rain" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HeavyWind" runat="server" Text="Heavy Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HighSurf" runat="server" Text="High Surf" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Hurricane" runat="server" Text="Hurricane" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_LakeEffectSnow" runat="server" Text="Lake-Effect Snow" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Landslide" runat="server" Text="Landslide" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineDenseFog" runat="server" Text="Marine Dense Fog" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineHighWind" runat="server" Text="Marine High Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineThunderstormWind" runat="server" Text="Marine Thunderstorm Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_NorthernLights" runat="server" Text="Northern Lights" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_RipCurrent" runat="server" Text="Rip Current" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Sleet" runat="server" Text="Sleet" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_StrongWind" runat="server" Text="Strong Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Tornado" runat="server" Text="Tornado" 
                            CssClass="checkBox_SmallText" AutoPostBack="True" 
                            oncheckedchanged="CheckBox_Tornado_CheckedChanged" /><br />
                        <asp:CheckBox ID="CheckBox_TropicalStorm" runat="server" Text="Tropical Storm" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_VolcanicAsh" runat="server" Text="Volcanic Ash" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Waterspout" runat="server" Text="Waterspout" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_WinterStorm" runat="server" Text="Winter Storm" CssClass="checkBox_SmallText" /><br />
                    </div>
                    <div id='rightColumn'>
                        <asp:CheckBox ID="CheckBox_Avalanche" runat="server" Text="Avalanche" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_CoastalFlood" runat="server" Text="Coastal Flood" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_DebrisFlow" runat="server" Text="Debris Flow" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_DenseSmoke" runat="server" Text="Dense Smoke" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_DustDevil" runat="server" Text="Dust Devil" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_ExcessiveHeat" runat="server" Text="Excessive Heat" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_FlashFlood" runat="server" Text="Flash Flood" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_FreezingFog" runat="server" Text="Freezing Fog" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_FunnelCloud" runat="server" Text="Funnel Cloud" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Heat" runat="server" Text="Heat" 
                            CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HeavySnow" runat="server" Text="Heavy Snow" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HighSnow" runat="server" Text="High Snow" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_HighWind" runat="server" Text="High Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_IceStorm" runat="server" Text="Ice Storm" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_LakeshoreFlood" runat="server" Text="Lakeshore Flood" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Lightning" runat="server" Text="Lightning" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineHail" runat="server" Text="Marine Hail" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineStrongWind" runat="server" Text="Marine Strong Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_MarineTropicalStorm" runat="server" Text="Marine Tropical Storm" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Other" runat="server" Text="Other" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Seiche" runat="server" Text="Seiche" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_StormSurgeTide" runat="server" Text="Storm Surge/Tide" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_ThunderstormWind" runat="server" Text="Thunderstorm Wind" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_TropicalDepression" runat="server" Text="Tropical Depression" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Tsunami" runat="server" Text="Tsunami" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_VolcanicAshfall" runat="server" Text="Volcanic Ashfall" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_Wildfire" runat="server" Text="Wildfire" CssClass="checkBox_SmallText" /><br />
                        <asp:CheckBox ID="CheckBox_WinterWeather" runat="server" Text="Winter Weather" CssClass="checkBox_SmallText" /><br />
                    </div>
                </div>
                <h4><br /><br />Tornado Event</h4>
                <div id='tornadoEventCriteria'>
                    <asp:Label ID="Label_TornadoEventScaleFrom" runat="server" Text="F-Scale:" Font-Bold="True"></asp:Label>
                    <asp:DropDownList ID="DropDownList_TornadoEventScaleFrom" runat="server">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>F0 / EF0</asp:ListItem>
                        <asp:ListItem>F1 / EF1</asp:ListItem>
                        <asp:ListItem>F2 / EF2</asp:ListItem>
                        <asp:ListItem>F3 / EF3</asp:ListItem>
                        <asp:ListItem>F4 / EF4</asp:ListItem>
                        <asp:ListItem>F5 / EF5</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <!--<h4>Fatal Events</h4>
                <div id='fatalEventCriteria'>
                    <asp:CheckBox ID="CheckBox_IsFatalEventsEnabled" runat="server" 
                        Text="Enable Fatal Events Criteria" AutoPostBack="True" 
                        oncheckedchanged="CheckBox_IsFatalEventsEnabled_CheckedChanged"  /><br />
                    <asp:Label ID="Label_FatalEventCriteriaFrom" runat="server" Text="Age:" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="TextBox_FatalEventCriteriaFrom" runat="server" CssClass="fourDigit"></asp:TextBox>
                    <asp:Label ID="Label_FatalEventCriteriaTo" runat="server" Text="to" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="TextBox_FatalEventCriteriaTo" runat="server" CssClass="fourDigit"></asp:TextBox>
                </div>-->
                <div id='runQuery'>
                    <div id='run'>
                        <asp:Button ID="Button_RunQuery" runat="server" Text="Run Query" CssClass="runQuery" onclick="Button_RunQuery_Click" />
                    </div>
                    <div id='export'>
                        <asp:Button ID="Button_ExportResults" runat="server" Text="Export Results" 
                            CssClass="exportResults" onclick="Button_ExportResults_Click" />
                        <asp:Button ID="Button_ExportStatistics" runat="server" 
                            Text="Export Statistics" CssClass="exportStatistics" 
                            onclick="Button_ExportStatistics_Click" />
                    </div>
                </div>
            </div>
        </asp:Panel>
        <asp:Panel ID="Panel_ResultsTable" runat="server">
            
        </asp:Panel>
    </div>
</asp:Content>
