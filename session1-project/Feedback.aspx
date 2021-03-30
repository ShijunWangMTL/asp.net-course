<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="session1_project.Feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div>
        <h2>Courseware Feedback Form</h2>
        <%--<asp:Label ID="LblTitle" runat="server" Text="Courseware Feedback Form"></asp:Label>--%>
    </div>
        <div>
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
         <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </div>
    <br />
    <div>
        Sex:
        <asp:RadioButtonList ID="RbtnSex" runat="server" CssClass="rbtn">
           <%-- <asp:ListItem Text="Male"></asp:ListItem>
            <asp:ListItem Text="Female"></asp:ListItem>--%>
        </asp:RadioButtonList>
    </div>
    <br />
    <div>
        Select course: 
        <asp:DropDownList ID="DdlCourse" runat="server">
            <%--<asp:ListItem Text="DotNET"></asp:ListItem>
            <asp:ListItem Text="APS.NET"></asp:ListItem>
            <asp:ListItem Text="PHP"></asp:ListItem>
            <asp:ListItem Text="VISUAL BASIC"></asp:ListItem>
            <asp:ListItem Text="C#"></asp:ListItem>--%>
        </asp:DropDownList>
    </div>
    <br />
    <div>
        Technical Coverage:
        <asp:RadioButtonList ID="RbtnCoverage" runat="server" CssClass="rbtn">
            <asp:ListItem Text="Excellent"></asp:ListItem>
            <asp:ListItem Text="Good"></asp:ListItem>
            <asp:ListItem Text="Average"></asp:ListItem>
            <asp:ListItem Text="Poor"></asp:ListItem>
        </asp:RadioButtonList>
    </div>
    <br />
    <div>
        <asp:Label ID="LblSuggestion" runat="server" Text="Suggestions:"></asp:Label>
        <br />
        <textarea id="TxtSuggestion" runat="server" rows="2"></textarea>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Submit Form" OnClick="BtnSubmit_Click" />
    <br />
    <div>
        <asp:Label ID="LblSubmitted" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
