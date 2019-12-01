<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebApplication1.Pages.Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style>

.productPrice {
    font-family: arial,helvetica,sans-serif;
    color: #FFB600;
}



.detailsImage {
    width: 400px;
    height: 400px;
    margin-right: 20px;
}

.detailsDescription {
    width: 400px;
    font-style: italic
}

.detailsPrice {
    font-size: 24px;
    font-weight: bold;
}

.button {
    padding: 10px;
    margin: 20px;
    color: #ffffff;
    border: 0;
    border-radius: 4px;
    -moz-border-radius: 4px;
    -webkit-border-radius: 4px;
    clear: both;
    background: linear-gradient(to bottom, darkgreen, green);
}

    </style>


    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" /></td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                </h2>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label></td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label></td><br />
                Quantity:<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br/>
                <asp:Button ID ="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Add Product" />
            <br />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </tr>
        <tr>
            <td>Product Number: <asp:Label ID="lblItemNr" runat="server" Text="Label"></asp:Label></td>
            
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label></td>
            
        </tr>
    </table>
</asp:Content>
