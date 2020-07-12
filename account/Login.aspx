<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="artefact.account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Login
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="../styles/main.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/table-styles.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/form.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>Login</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Login</h3>
    <p>Please use the form below to login to the system. If you can't remember your password use the lost password feature and if you can't remember you username, use the username reminder service.</p>
    <asp:Panel ID="Panel_ValidationErrors" runat="server" CssClass="validation-errors-red" Visible="False">
        <asp:Label ID="Label_ValidationErrors" runat="server" CssClass="validation-error-text-red" Visible="False"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="Panel_Login" runat="server" DefaultButton="Button_Login">
        <table class="standard">
            <tr>
                <td>
                    <asp:Label ID="Label_Username" runat="server" Text="Username: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_Password" runat="server" Text="Password: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class='center' colspan='2'>
                    <asp:Button ID="Button_Login" runat="server" Text="Login" BorderColor="Black" 
                        BorderStyle="Solid" BorderWidth="1px" Font-Bold="True" Height="30px" 
                        Width="100px" onclick="Button_Login_Click"/>
                </td>
            </tr>
            <tr>
                <td class='center' colspan='2'>
                    <asp:HyperLink ID="Hyperlink_ForgottenYourPassword" runat="server" 
                        NavigateUrl="~/account/forgotten-password/ForgottenPassword.aspx?screen=1">Forgotten Your Password?</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class='center' colspan='2'>
                    <asp:HyperLink ID="Hyperlink_ForgottenYourUsername" runat="server" 
                        NavigateUrl="~/account/forgotten-username/ForgottenUsername.aspx?screen=1">Forgotten Your Username?</asp:HyperLink>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
