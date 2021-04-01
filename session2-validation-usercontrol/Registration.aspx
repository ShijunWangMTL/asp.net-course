<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="session_two_validation.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblUserid" runat="server" Text="Enter your user ID: ">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtUserid" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserid" runat="server" ErrorMessage="You need to enter user ID." ControlToValidate="txtUserid" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidatorUserid" ControlToValidate="txtUserid" OnServerValidate="CustomValidatorUserid_ServerValidate" runat="server" ErrorMessage="User ID should have atleast a capital, small and digit and should be greater than 5 and less than 26 letters"
                SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:CustomValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblId" runat="server" Text="Enter your Email: ">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ErrorMessage="You need to enter password." ControlToValidate="txtPwd" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server"
                ErrorMessage="Enter a valid email." ControlToValidate="txtEmail"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RegularExpressionValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblPwd" runat="server" Text="Enter password: ">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtPwd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPwd" runat="server" ErrorMessage="You need to enter password." ControlToValidate="txtPwd" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblPwd2" runat="server" Text="Re-enter password: ">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtPwd2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPwd2" runat="server" ErrorMessage="You need to re-enter the ID." ControlToValidate="txtPwd2" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Enter password and Re-enter password must be the same." ControlToCompare="txtPwd" ControlToValidate="txtPwd2" BorderStyle="Dotted" ForeColor="#CC3300"></asp:CompareValidator>

        </div>
    </div>

    <div class="row">
        <div class="col-md-4">
            <asp:Label ID="lblAge" runat="server" Text="Age: ">
            </asp:Label>
        </div>
        <div class="col-md-4">
            <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge" runat="server" ErrorMessage="You need to enter age." ControlToValidate="txtAge" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeValidatorAge" runat="server" ErrorMessage="You need to enter valid age." ControlToValidate="txtAge" MaximumValue="100" MinimumValue="18" Type="Integer" SetFocusOnError="True" BorderStyle="Dotted" ForeColor="#CC3300"></asp:RangeValidator>
        </div>
    </div>

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" />



</asp:Content>
