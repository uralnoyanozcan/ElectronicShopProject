<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="WebApplication1.Pages.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" AllowSorting="True" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
            <asp:BoundField DataField="ClientID" HeaderText="ClientID" SortExpression="ClientID" />
            <asp:BoundField DataField="ProductID" HeaderText="ProductID" SortExpression="ProductID" />
            <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            <asp:CheckBoxField DataField="IsInCart" HeaderText="IsInCart" SortExpression="IsInCart" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Model1 %>" SelectCommand="SELECT * FROM [Carts] WHERE ([ClientID] = @ClientID)" DeleteCommand="DELETE FROM [Carts] WHERE [ID] = @original_ID" InsertCommand="INSERT INTO [Carts] ([ClientID], [ProductID], [Amount], [Date], [IsInCart]) VALUES (@ClientID, @ProductID, @Amount, @Date, @IsInCart)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [Carts] SET [ClientID] = @ClientID, [ProductID] = @ProductID, [Amount] = @Amount, [Date] = @Date, [IsInCart] = @IsInCart WHERE [ID] = @original_ID">
        <DeleteParameters>
            <asp:Parameter Name="original_ID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="ClientID" Type="Int32" />
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="Amount" Type="Int32" />
            <asp:Parameter Name="Date" Type="DateTime" />
            <asp:Parameter Name="IsInCart" Type="Boolean" />
        </InsertParameters>
        <SelectParameters>
            <asp:SessionParameter DefaultValue="" Name="ClientID" SessionField="user" Type="Int32" />
        </SelectParameters>
        <UpdateParameters>
            <asp:Parameter Name="ClientID" Type="Int32" />
            <asp:Parameter Name="ProductID" Type="Int32" />
            <asp:Parameter Name="Amount" Type="Int32" />
            <asp:Parameter Name="Date" Type="DateTime" />
            <asp:Parameter Name="IsInCart" Type="Boolean" />
            <asp:Parameter Name="original_ID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>
