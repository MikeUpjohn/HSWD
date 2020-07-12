<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level2-main.Master" AutoEventWireup="true" CodeBehind="ForgottenPassword.aspx.cs" Inherits="artefact.account.forgotten_password.forgotten_password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Forgotten Your Password?
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
    <h2>Forgotten Your Password?</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel_ScreenOne" runat="server" DefaultButton="Button_ResetPassword">
        <h3>Forgotten Your Password?</h3>
        <p>Please use the form below to reset your password. Fill in your username and press the Reset Password button. Check your inbox for an e-mail with a temporary password and then use this on the next screen to reset your password.</p>
        <asp:Panel ID="Panel_FirstScreenValidationErrors" runat="server" CssClass="validation-errors-red" Visible="False">
            <asp:Label ID="Label_FirstScreenValidationErrors" runat="server" CssClass="validation-error-text-red" Visible="False"></asp:Label>
        </asp:Panel>
        <table class="standard">
            <tr>
                <td>
                    <asp:Label ID="Label_Username" runat="server" Text="Username:" CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="center" colspan='2'>
                    <asp:Button ID="Button_ResetPassword" runat="server" Text="Reset Password" 
                        Height="30px" Width="200px" BorderColor="Black" BorderStyle="Solid" 
                        BorderWidth="1px" onclick="Button_ResetPassword_Click"/>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel_ScreenTwo" runat="server">
        <h3>Forgotten Your Password?</h3>
        <p>An e-mail has been sent to the e-mail address corresponding to that username you just entered. Please check this inbox over the next few minutes for a temporary password to reset your normal password.</p>
        <div class="center-button">
            <asp:Button ID="Button_IHaveTheEmail" runat="server" Text="I Have The E-mail" 
                Height="30px" Width="200px" onclick="Button_IHaveTheEmail_Click" />
        </div>

        <h3>No E-mail?</h3>
        <p>Double check the 'Spam' folder to make sure the e-mail is not in there or <a href='ForgottenPassword.aspx?screen=1'>request another reminder of your username</a>.</p>
        <p>OIf things really don't work out, please <a href='#'>contact our administrator</a> with the subject "Can't Reset Password".</p>
    </asp:Panel>
    <asp:Panel ID="Panel_ScreenThree" runat="server" DefaultButton="Button_ChangePassword">
        <h3>Forgotten Your Password?</h3>
        <p>Please use the form below to reset your password. You will find the temporary password in an e-mail in the inbox you specified when you signed up.</p>
        <asp:Panel ID="Panel_ThirdScreenValidationErrors" runat="server" 
            CssClass="validation-errors-red" Visible="False">
            <asp:Label ID="Label_ThirdScreenValidationErrors" runat="server" Text="Label" CssClass="validation-error-text-red" Visible="False"></asp:Label>
        </asp:Panel>
        <table class='standard'>
            <tr>
                <td>
                    <asp:Label ID="Label_TemporaryPassword" runat="server" Text="Temporary Password: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_TemporaryPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_NewPassword" runat="server" Text="New Password: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_NewPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_ConfirmNewPassword" runat="server" Text="Confirm New Password: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_ConfirmNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="center" colspan="2">
                    <asp:Button ID="Button_ChangePassword" runat="server" Text="Change Password" 
                        Width="200px" Height="30px" BorderColor="Black" BorderStyle="Solid" 
                        BorderWidth="1px" onclick="Button_ChangePassword_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel_ScreenFour" runat="server">
        <asp:Panel ID="Panel_FourthScreenValidationErrors" runat="server" CssClass="validation-errors-green">
            <asp:Label ID="Label_FourthScreenValidationText" runat="server" Text="Label" CssClass="validation-error-text-green"></asp:Label>
        </asp:Panel>
    </asp:Panel>
</asp:Content>