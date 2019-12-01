<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Pages.Account.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Literal ID="litStatus" runat="server"></asp:Literal>
    </p>
    <p>
        Username:</p>
    <p>
        <asp:TextBox ID="txtUserName" runat="server" CssClass="inputs"></asp:TextBox>
    </p>
    <p>
        Password:</p>
    <p>
        <asp:TextBox ID="txtPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        Confirm Password:</p>
    <p>
        <asp:TextBox ID="txtConfirmPassword" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" CssClass="button" OnClick="Button1_Click" Text="submit" />
    </p>
    <p>
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
</asp:Content>
