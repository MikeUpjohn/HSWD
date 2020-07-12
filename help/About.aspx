<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="artefact.help.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - About
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
    <h2>About This Website</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <h3>This Website</h3>
    <p>Version 0.1<br />
    Released: April 2013</p>

    <h3>With Thanks To...</h3>
    <p>NOAA NCDC (National Oceanic Atmospheric Administration National Climatic Data Center.</p>
</asp:Content>
