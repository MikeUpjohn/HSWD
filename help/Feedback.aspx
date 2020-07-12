<%@ Page Title="" Language="C#" MasterPageFile="~/master-pages/level1-main.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="artefact.help.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="WebPageTitle" runat="server">
    Feedback
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
    <h2>Feedback</h2>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel_ScreenOne" runat="server">
        <h3>Feedback</h3>
        <p>Please use the form below to send us any feedback you may have. An administrator will decide whether your feedback required further communication and contact you within 7 working days.</p>
        <asp:Panel ID="Panel_ValidationErrors" runat="server" CssClass="validation-errors-red">
            <asp:Label ID="Label_ValidationErrorText" runat="server" CssClass="validation-error-text-red"></asp:Label>
        </asp:Panel>
        <div id='feedback'>
            <div class='formRow'>
                <asp:Label ID="Label_FeedbackSubject" runat="server" Text="Feedback Subject:" CssClass="leftFormLabel" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TextBox_FeedbackSubject" runat="server" CssClass="rightFormField"></asp:TextBox>
            </div>
            <div class='formRow'>
                <asp:Label ID="Label_Feedback" runat="server" Text="Feedback:" CssClass="leftFormLabel" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TextBox_Feedback" runat="server" TextMode="MultiLine" CssClass="feedback"></asp:TextBox>
            </div>
            <div class='formRow'>
                <asp:Label ID="Label_FeedbackRating" runat="server" Text="Rating:" CssClass="leftFormLabel" Font-Bold="True"></asp:Label>
                <asp:DropDownList ID="DropDownList_FeedbackRating" runat="server" CssClass="rightFormDropDown">
                    <asp:ListItem>Choose...</asp:ListItem>
                    <asp:ListItem>1 (Poor)</asp:ListItem>
                    <asp:ListItem>2 (Below Average)</asp:ListItem>
                    <asp:ListItem>3 (Average)</asp:ListItem>
                    <asp:ListItem>4 (Good)</asp:ListItem>
                    <asp:ListItem>5 (Very Good)</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class='formRow'>
                <asp:Button ID="Button_SendFeedback" runat="server" Text="Send" CssClass="feedbackFormSubmit" onclick="Button_SendFeedback_Click"/>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel_ScreenTwo" runat="server">
        <h3>Feedback Submitted</h3>
        <p>Your feedback has been successfully submitted. An administrator will decide whether your feedback required further communication and contact you within 7 working days if necessary.</p>
    </asp:Panel>
</asp:Content>
