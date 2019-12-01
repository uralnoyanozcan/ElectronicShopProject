<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Pages.Account.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:Label ID="Label1" runat="server" Text="UserName:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
</p>
<p>
    <asp:TextBox ID="txtPasswordLog" runat="server" TextMode="Password"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnSubmit" runat="server" Text="submit" OnClick="btnSubmit_Click" />
</p>
<p>
    <asp:Label ID="lblResult" runat="server"></asp:Label>
</p>
</asp:Content>
