<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication1.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #ContentPlaceHolder1_pnlProducts div {
    float: left;
    width: 250px;
    height: 250px;
    text-align: center;
}

.productImage {
    width: 150px;
    height: 150px;
    vertical-align: central;
    padding: 10px;
    border-radius: 50px;
    -moz-border-radius: 50px;
    -webkit-border-radius: 50px;
}

.productName {
    font-size: 18px;
    font-weight: bold;
}

.productPrice {
    font-family: arial,helvetica,sans-serif;
    color: #FFB600;
}
    </style>
    <asp:Panel ID="pnlProducts" runat="server">
</asp:Panel>
    <p style="clear: both"></p>
</asp:Content>
