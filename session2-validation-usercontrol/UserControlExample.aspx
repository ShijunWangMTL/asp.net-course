<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserControlExample.aspx.cs" Inherits="session_two_validation.UserControlExample" %>

<%--import --%>
<%@ Register Src="~/Controls/SelectTableList.ascx" TagName="WebControl" TagPrefix="TWebControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <TWebControl:WebControl Title="Fruit List" InitialItems="Apple,Banana,Kiwi,Lime,Mango,Orange" ID="Header" runat="server" />
</asp:Content>
