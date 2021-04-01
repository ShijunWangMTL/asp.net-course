<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SelectTableList.ascx.cs" Inherits="session_two_validation.SelectTableList" %>
<br />
<asp:Label runat="server" ID="lblTitle"></asp:Label>
<table>
    <tr>
        <td>
            <asp:ListBox ID="listSource" runat="server" SelectionMode="Multiple" Width="250px" Height="138px"></asp:ListBox>
        </td>

        <td>
            <asp:Button ID="btnAllRight" runat="server" Text="&gt;&gt;" Width="50px" OnClick="btnAllright_Click" /><br />
            <asp:Button ID="btnSelectedRight" runat="server" Text="&gt;" Width="50px" OnClick="btnSelectedRight_Click" /><br />
            <asp:Button ID="btnSelectedLeft" runat="server" Text="&lt;" Width="50px" OnClick="btnSelectedLeft_Click" /><br />
            <asp:Button ID="btnAllLeft" runat="server" Text="&lt;&lt;" Width="50px" OnClick="btnAllLeft_Click" />
        </td>

        <td>
            <asp:ListBox ID="listDestination" runat="server" SelectionMode="Multiple" Width="250px" Height="138px"></asp:ListBox>
        </td>
    </tr>

</table>