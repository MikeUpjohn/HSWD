<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level0-main.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="artefact.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Welcome
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="styles/main.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>Welcome</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Welcome to HSWD!</h3>
    <p>Welcome to HSWD, short for Historical Severe Weather Database. At present four main areas exist:-</p>
        <ol>
            <li>Live Weather Data</li>
            <li>Weather Forecast</li>
            <li>U.S. Severe Weather Database</li>
            <li>Historical Weather Conditions</li>
        </ol>
    <h3>Getting Started</h3>
    <p>If you are a first time visitor to this site, you will need to <a href='account/Register.aspx'>Register</a> to use further features on the site. If you have already registered please <a href='account/Login.aspx'>log in</a> and continue using the application. If you have forgotten either your username or password, please proceed to the login page and follow information from there.</p>

    <h3>Further Information</h3>
    <p>Further information for this site can be found by using the link in the footer of each page. A general help guide is present here for use of all areas on the site, along with the terms and conditions of use, a feedback form for your use, a little information about the project and application and further contact information for moments when you may get really stuck with something.</p>
</asp:Content>