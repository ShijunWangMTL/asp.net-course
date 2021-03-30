<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerList.aspx.cs" Inherits="session3_DataMigrationAuth.CustomerList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Customer List</h1>

    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table class="table table-bordered">
                <tr>
                    <td><%# Eval("Id") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Age") %></td>
                </tr>               
            </table>                    
        </ItemTemplate>
    </asp:DataList>

</asp:Content>
