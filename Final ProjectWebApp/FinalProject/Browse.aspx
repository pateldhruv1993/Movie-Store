<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Browse.aspx.cs" Inherits="FinalProject.Browse" MasterPageFile="~/Site1.Master" %>

<asp:Content ID ="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divLoginBox" runat="server" style="margin:10px; border-bottom: 1px solid black">
        Please login to add items to your cart.<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>
    <div id="divItemList"  style="margin:10px;" runat="server">
       
        
    </div>
</asp:Content>