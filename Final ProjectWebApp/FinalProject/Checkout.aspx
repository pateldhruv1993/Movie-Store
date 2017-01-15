<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="FinalProject.Checkout" MasterPageFile="~/Site1.Master" %>

<asp:Content ID ="content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="divLoginBox" runat="server" style="margin:10px; border-bottom: 1px solid black">
    </div>
    <div id="divCheckoutList"  style="margin:10px;" runat="server">
        
    </div>

    <div style="border:1px 0 0 0 solid; border-color:black; clear:both; float:right;">
        <div style="margin:20px;">
            
        <span style="font-size: 25px; font-weight:bold;">Total:</span><asp:Label ID="lblTotalPrice" runat="server" Font-Bold="True" Font-Size="20pt"></asp:Label>
            <br /><br />
        <br />
            <asp:Button ID="btnCheckout" runat="server" Text="Checkout" OnClick="btnCheckout_Click" /> &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDeleteAll" runat="server" Text="Delete All" OnClick="btnDeleteAll_Click" />
        </div>
    </div>
</asp:Content>