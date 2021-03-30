<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataList.aspx.cs" Inherits="session3_DataMigrationAuth.DataList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Data List</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/js/bootstrap.min.js"></script>
    <style>
        .productList {
            border: 1px solid #6c757d;
            margin-bottom: 10px;
            padding: 15px;
            border-radius: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container py-4">
            <h5 class="text-center text-uppercase">DataList control in asp.net</h5>
            <asp:DataList ID="DataList1" runat="server" CssClass="row">
                <ItemTemplate>
                    <div class="row productList">
                        <div class="col-4">
                            <%--<img alt="" width="250" src='<%#Eval("ProductImage")%>' />--%>
                        </div>
                        <div class="col-8">
                            <h4><%#Eval("Id")%></h4>
                            <h6><%#Eval("Name")%></h6>
                            <div><%#Eval("Age")%></div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
