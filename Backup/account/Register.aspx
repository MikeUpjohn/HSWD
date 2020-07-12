<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="artefact.account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    HSWD - Register
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="headerLinks" runat="server">
    <link type='text/css' rel='Stylesheet' href="../styles/main.css" />
    <link type='text/css' rel="Stylesheet" href="../styles/table-styles.css" />
    <link type='text/css' rel='Stylesheet' href="../styles/form.css" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainHeading" runat="server">
    <h1>Historical Severe Weather Database</h1>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="SecondaryHeading" runat="server">
    <h2>Register</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel_FirstScreen" runat="server">
    
    <h3>Register</h3>
    <p>Please use the form below to create an account. Fields marked with a red asterisk are required. When complete, press the Register button and check the e-mail account you specified for an activation e-mail.</p>
    <asp:Panel ID="Panel_ValidationErrors" runat="server" CssClass="validation-errors-red" Visible="False">
        <asp:Label ID="Label_ValidationErrors" runat="server" CssClass="validation-error-text-red" Visible="False"></asp:Label>
    </asp:Panel>
     <asp:Panel ID="Panel_RegisterForm" runat="server" DefaultButton="Button_Register">
         <table class="standard">
            <tr>
                <td>
                    <asp:Label ID="Label_Title" runat="server" Text="Title: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="DropDownList_Title" runat="server">
                        <asp:ListItem Selected="True">---</asp:ListItem>
                        <asp:ListItem>Mr</asp:ListItem>
                        <asp:ListItem>Mrs</asp:ListItem>
                        <asp:ListItem>Ms.</asp:ListItem>
                        <asp:ListItem>Miss</asp:ListItem>
                        <asp:ListItem>Dr</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_Forename" runat="server" Text="Forename: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Forename" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_Surname" runat="server" Text="Surname: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_Surname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_EmailAddress" runat="server" Text="E-mail Address: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_EmailAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label_ConfirmEmailAddress" runat="server" Text="Confirm E-mail Address: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_ConfirmEmailAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
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
                <td>
                    <asp:Label ID="Label_ConfirmPassword" runat="server" Text="Confirm Password: " CssClass="label"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox_ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="center" colspan="2">
                    <asp:CheckBox ID="CheckBox_TermsAndConditions" runat="server" 
                        Text="I accept the terms and conditions of use of this website" />
                </td>
            </tr>
            <tr>
                <td class="center" colspan="2">
                    <asp:Button ID="Button_Register" runat="server" Text="Register" Height="30px" 
                        BorderColor="Black" BorderWidth="1px" BorderStyle="Solid" Width="100px" 
                        onclick="Button_Register_Click" />
                </td>
            </tr>
        </table>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="Panel_SecondScreen" runat="server">
        <h3>Registration Successful</h3>
        <p>Thank you! Your registration was successful. As a secondary measure, please check the inbox of the e-mail address you just signed up with, in the next few minutes for a confirmation e-mail.</p>
    </asp:Panel>
    <asp:Panel ID="Panel_ThirdScreen" runat="server">
        <asp:Panel ID="Panel_EnableAccountValidationErrors" runat="server" 
            CssClass="validation-errors-red" Visible="False">
            <asp:Label ID="Label_EnableAccountValidationErrors" runat="server" CssClass="validation-error-text-red"></asp:Label>
        </asp:Panel>
    </asp:Panel>
</asp:Content>
