<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="ManageProducts.aspx.cs" Inherits="WebApplication1.Pages.Management.ManageProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Name:</p>
    <p>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        Type:</p>
    <p>
        <asp:DropDownList ID="ddlType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GarageConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes]"></asp:SqlDataSource>
    </p>
    <p>
        Price:</p>
    <p id="txtPrice">
        <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="txtPrice_TextChanged"></asp:TextBox>
    </p>
    <p>
        Image:</p>
    <p id="ddlImage">
        <asp:DropDownList ID="ddlImage" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        Description:</p>
    <p id="txtDescription">
        <asp:TextBox ID="txtDescription" runat="server" Height="76px" TextMode="MultiLine" Width="223px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
</asp:Content>
