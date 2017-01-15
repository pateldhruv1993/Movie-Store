<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FinalProject.Login" MasterPageFile="~/Site1.Master" %>

<asp:Content ID ="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="margin:20px;">
        <h1>Login:</h1>
        <asp:Label ID="lblSqlError" runat="server" ForeColor="Red"></asp:Label>
        <asp:Label ID="lblWrongDetails" Visible="false" runat="server" ForeColor="Red" Text="Wrong username or password."></asp:Label>
        <br />
        Username:
        <asp:TextBox ID="tbUsername" runat="server"></asp:TextBox><br />
        Password:
        <asp:TextBox ID="tbPwd" runat="server"></asp:TextBox><br />

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnRegister" runat="server" text="New User" OnClick="btnRegister_Click"/>
        </div>
</asp:Content>