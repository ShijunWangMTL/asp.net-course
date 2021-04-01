<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalInfo.aspx.cs" Inherits="session_two_validation.PersonalInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Personal Info</h2>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblFname" runat="server" Text="Firstname">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtFname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFname" runat="server" ErrorMessage="Firstname cannot be blank" ControlToValidate="txtFname" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorFname" runat="server"
                ErrorMessage="Firstname may contain letters and special characters ., -, _" ControlToValidate="txtFname"
                ValidationExpression="^[A-Za-z._\-]{2,50}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblLname" runat="server" Text="Lastname">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtLname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Lastname cannot be blank" ControlToValidate="txtLname" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorLname" runat="server"
                ErrorMessage="Lastname may contain letters and special characters ., -, _" ControlToValidate="txtLname"
                ValidationExpression="^[A-Za-z._\-]{2,50}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblStrNum" runat="server" Text="Street No.">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtStrNum" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Street number cannot be blank" ControlToValidate="txtStrNum" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorStrNum" runat="server"
                ErrorMessage="Enter a valid street number." ControlToValidate="txtStrNum"
                ValidationExpression="^[0-9]{1,10}[a-zA-Z]{0,1}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblStr" runat="server" Text="Street">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtStr" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorStr" runat="server" ErrorMessage="Street name cannot be blank" ControlToValidate="txtStr" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                ErrorMessage="Enter a valid street name." ControlToValidate="txtStr"
                ValidationExpression="^[A-Za-z]{2,50}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblPstlCode" runat="server" Text="Postal Code">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtPstlCode" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Postal code cannot be blank" ControlToValidate="txtPstlCode" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPstlCode" runat="server"
                ErrorMessage="Postal code has to be the format of A1A1A1." ControlToValidate="txtPstlCode"
                ValidationExpression="^[a-zA-Z]{1}[\d]{1}[a-zA-Z]{1}[\d]{1}[a-zA-Z]{1}[\d]{1}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblPhone" runat="server" Text="Phone No.">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Phone number cannot be blank" ControlToValidate="txtPhone" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorPhone" runat="server"
                ErrorMessage="Phone number has to be 10 digits without space." ControlToValidate="txtPhone"
                ValidationExpression="^[0-9]{10}$" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </div>

    <h2><asp:Label ID="lblResult" runat="server" Text="" /></h2>

    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="lblName" runat="server" Text="">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblNameResult" runat="server" Text="">
            </asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="lblAddr" runat="server" Text="">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblAddrResult" runat="server" Text="">
            </asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="col-md-2">
            <asp:Label ID="lblPh" runat="server" Text="">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:Label ID="lblPhResult" runat="server" Text="">
            </asp:Label>
        </div>
    </div>
    
</asp:Content>
