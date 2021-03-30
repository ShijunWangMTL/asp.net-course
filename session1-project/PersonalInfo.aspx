<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="session1_project.PersonalInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="lblWelcom" runat="server"></asp:Label>

    <table ID="tbl" runat="server" style="width:100%; padding:10px; height: 122px;">
        <tr>
            <td style="height:20px">
                <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server" Style="margin-left:0" Height="30px" Width="153px"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="height:20px">
                <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server" Style="margin-left:0" Height="30px" Width="153px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
    <br />
    <input id="Reset" type="reset" value="reset" runat="server" />
</asp:Content>

<%--<script runat="server">
            protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            lblResult.Text = string.Format("The personal info {0}, {1}", firstName, lastName);
        }
</script>--%>
