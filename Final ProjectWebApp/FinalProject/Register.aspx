<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="FinalProject.Register" MasterPageFile="~/Site1.Master" %>

<asp:Content ID ="content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:20px;">    
        <h1>Register:</h1>
        Username:
        <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbUsername" ErrorMessage="Username is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Password:
        <asp:TextBox ID="tbPwd" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbPwd" ErrorMessage="Password is Required" ForeColor="Red"></asp:RequiredFieldValidator><br />
        Address:
        <asp:TextBox ID="tbAddress" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbAddress" ErrorMessage="Address is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        CreditCard:
        <asp:TextBox ID="tbCreditCard" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="tbCreditCard" ErrorMessage="Credit card number is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        Email:
        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email address is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:Button ID="btnRegister" runat="server" text="Register" OnClick="btnRegister_Click"/>
        </div>
</asp:Content>