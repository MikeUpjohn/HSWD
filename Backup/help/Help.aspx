<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="Help.aspx.cs" Inherits="artefact.help.Help" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Help
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="../styles/main.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/table-styles.css" />
    <link type='text/css' rel='Stylesheet' href="../styles/form.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/us-severe-weather-database.css" />
    <link type="text/css" rel="Stylesheet" href="../styles/results-table.css" />
    <link type="text/css" rel="Stylesheet" href="../styles/feedback.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>General Help</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <h3>State and County FIPS Codes</h3>
    <p>Need to find a specific state or county FIPS Code? Please use the <a href='../documents/fips-codes.xls'>State and County FIPS Code Guide</a>.</p>

    <h3>U.S. Severe Weather Database Icons</h3>
    <p>The table below, lists all of the icons that will appear in the U.S. Severe Weather Database section of this site.</p>
    <table>
        <tr>
            <th>Icon</th>
            <th>Description</th>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/astronomical-low-tide.png" alt="Astronomical Low Tide Icon" />
            </td>
            <td>
                Astronomical Low Tide
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/avalanche.png" alt="Avalanche Icon" />
            </td>
            <td>
                Avalanche
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/blizzard.png" alt="Blizzard Icon" />
            </td>
            <td>
                Blizzard
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/coastal-flood.png" alt="Coastal Flood Icon" />
            </td>
            <td>
                Coastal Flood
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/cold-wind-chill.png" alt="Cold / Wind Chill Icon" />
            </td>
            <td>
                Cold / Wind Chill
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/debris-flow.png" alt="Debris Flow Icon" />
            </td>
            <td>
                Debris Flow
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/dense-fog.png" alt="Dense Fog Icon" />
            </td>
            <td>
                Dense Fog
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/dense-smoke.png" alt="Dense Smoke Icon" />
            </td>
            <td>
                Dense Smoke
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/drought.png" alt="Drought Icon" />
            </td>
            <td>
                Drought
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/dust-devil.png" alt="Dust Devil Icon" />
            </td>
            <td>
                Dust Devil
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/dust-storm.png" alt="Dust Storm Icon" />
            </td>
            <td>
                Dust Storm
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/excessive-heat.png" alt="Excessive Heat Icon" />
            </td>
            <td>
                Excessive Heat
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/extreme-cold-wind-chill.png" alt="Extreme Cold / Wind Chill Icon" />
            </td>
            <td>
                Extreme Cold/Wind Chill
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/flash-flood.png" alt="Flash Flood Icon" />
            </td>
            <td>
                Flash Flood
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/flood.png" alt="Flood Icon" />
            </td>
            <td>
                Flood
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/freezing-fog.png" alt="Freezing Fog Icon" />
            </td>
            <td>
                Freezing Fog
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/frost-freeze.png" alt="Frost / Freeze Icon" />
            </td>
            <td>
                Frost / Freeze
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/funnel-cloud.png" alt="Funnel Cloud Icon" />
            </td>
            <td>
                Funnel Cloud
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/hail.png" alt="Hail Icon" />
            </td>
            <td>
                Hail
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/heat.png" alt="Heat Icon" />
            </td>
            <td>
                Heat
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/heavy-rain.png" alt="Heavy Rain Icon" />
            </td>
            <td>
                Heavy Rain
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/heavy-snow.png" alt="Heavy Snow Icon" />
            </td>
            <td>
                Heavy Snow
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/heavy-wind.png" alt="Heavy Wind Icon" />
            </td>
            <td>
                Heavy Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/high-snow.png" alt="High Snow Icon" />
            </td>
            <td>
                High Snow
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/high-surf.png" alt="High Surf Icon" />
            </td>
            <td>
                High Surf
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/high-wind.png" alt="High Wind Icon" />
            </td>
            <td>
                High Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/hurricane.png" alt="Hurricane Icon" />
            </td>
            <td>
                Hurricane
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/ice-storm.png" alt="Ice Storm Icon" />
            </td>
            <td>
                Ice Storm
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/lake-effect-snow.png" alt="Lake Effect Snow Icon" />
            </td>
            <td>
                Lake Effect Snow
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/lakeshore-flood.png" alt="Lakeshore Flood Icon" />
            </td>
            <td>
                Lakeshore Flood
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/landslide.png" alt="Landslide Icon" />
            </td>
            <td>
                Landslide
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/lightning.png" alt="Lightning Icon" />
            </td>
            <td>
                Lightning
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-dense-fog.png" alt="Marine Dense Fog Icon" />
            </td>
            <td>
                Marine Dense Fog
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-hail.png" alt="Marine Hail Icon" />
            </td>
            <td>
                Marine Hail
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-high-wind.png" alt="Marine High Wind Icon" />
            </td>
            <td>
                Marine High Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-strong-wind.png" alt="Marine Strong Wind Icon" />
            </td>
            <td>
                Marine Strong Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-thunderstorm-wind.png" alt="Marine Thunderstorm Wind Icon" />
            </td>
            <td>
                Marine Thunderstorm Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/marine-tropical-storm.png" alt="Marine Tropical Storm Icon" />
            </td>
            <td>
                Marine Tropical Storm
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/northern-lights.png" alt="Northern Lights Icon" />
            </td>
            <td>
                Northern Lights
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/other.png" alt="Other Icon" />
            </td>
            <td>
                Other Event
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/rip-current.png" alt="Rip Current Icon" />
            </td>
            <td>
                Rip Current
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/seiche.png" alt="Seiche Icon" />
            </td>
            <td>
                Seiche
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/sleet.png" alt="Sleet Icon" />
            </td>
            <td>
                Sleet
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/storm-surge-tide.png" alt="Storm Surge Tide Icon" />
            </td>
            <td>
                Storm Surge Tide
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/strong-wind.png" alt="Strong Wind Icon" />
            </td>
            <td>
                Strong Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/thunderstorm-wind.png" alt="Thunderstorm Wind Icon" />
            </td>
            <td>
                Thunderstorm Wind
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/tornado.png" alt="Tornado Icon" />
            </td>
            <td>
                Tornado
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/tropical-depression.png" alt="Tropical Depression Icon" />
            </td>
            <td>
                Tropical Depression
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/tropical-storm.png" alt="Tropical Storm Icon" />
            </td>
            <td>
                Tropical Storm
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/tsunami.png" alt="Tsunami Icon" />
            </td>
            <td>
                Tsunami
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/volcanic-ash.png" alt="Volcanic Ash Icon" />
            </td>
            <td>
                Volcanic Ash
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/volcanic-ashfall.png" alt="Volcanic Ashfall Icon" />
            </td>
            <td>
                Volcanic Ashfall
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/waterspout.png" alt="Waterspout Icon" />
            </td>
            <td>
               Waterspout
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/wildfire.png" alt="Wildfire Icon" />
            </td>
            <td>
                Wildfire
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/winter-storm.png" alt="Winter Storm Icon" />
            </td>
            <td>
                Winter Storm
            </td>
        </tr>
        <tr>
            <td>
                <img src="../images/icons/winter-weather.png" alt="Winter Weather Icon" />
            </td>
            <td>
                Winter Weather
            </td>
        </tr>
    </table>
</asp:Content>
