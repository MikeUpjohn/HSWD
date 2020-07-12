<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level2-main.Master" AutoEventWireup="true" CodeBehind="ForgottenUsername.aspx.cs" Inherits="artefact.account.forgotten_username.ForgottenUsername" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Username Reminder
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="../../styles/main.css" />
    <link type='text/css' rel="Stylesheet" href="../../styles/table-styles.css" />
    <link type='text/css' rel="Stylesheet" href="../../styles/form.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>Username Reminder</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel_FirstScreen" runat="server" DefaultButton="Button_SendUsernameReminder">
        <h3>Forgotten Your Username?</h3>
        <p>Please use the form below to get a reminder of your username. Fill in your e-mail address that you signed up with and press ther 'Send Username Reminder' button. Check your inbox shortly after for an e-mail with a reminder of your username.</p>
        <asp:Panel ID="Panel_ValidationErrors" runat="server" CssClass="validation-errors-red" Visible="False">
            <asp:Label ID="Label_ValidationErrorText" runat="server" Text="Label" CssClass="validation-error-text-red" Visible="False"></asp:Label>
        </asp:Panel>
        <table class="standard">
            <tr>
                <td>
                    <asp:Label ID="Label_EmailAddress" runat="server" Text="E-mail Address: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_EmailAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="center" colspan="2">
                    <asp:Button ID="Button_SendUsernameReminder" runat="server" 
                        Text="Send Username Reminder" Height="30px" Width="200px" 
                        onclick="Button_SendUsernameReminder_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel_SecondScreen" runat="server">
        <h3>Forgotten Your Username?</h3>
        <p>An e-mail has been sent to the e-mail address you just entered. Please check this over the next fwe minutes foir a reminder of your username.</p>
        <h3>No E-mail?</h3>
        <p>Double check the 'Spam' folder to make sure it is not there or <a href="ForgottenUsername.aspx?screen=1">request another reminder of your username</a>.</p>
        <p>If things really don't work out, please <a href='#'>contact our administrator</a> with the subject "Can't Retrieve Username".</p>
    </asp:Panel>
</asp:Content>
