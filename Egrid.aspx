<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Egrid.aspx.cs" Inherits="Egrid" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <main id="main" class="main">
    
     <h1 class="text-center" style="margin-top:100px">EXCEL UPLOAD AND DOWNLOAD and Transfer it to DataBase</h1>
    <div class="text-center">
        <asp:FileUpload ID="flupl" runat="server" CssClass="btn btn-success" />
        <asp:Button ID="uplddb" runat="server" Text="UPLOAD to DB" CssClass="btn btn-danger" OnClick="uplddb_Click" />
        <asp:Button ID="btnup" runat="server" Text="View File" CssClass="btn btn-info" OnClick="btnup_Click"/>
        </div>
        <hr />
        <div class=".table-hover">
        <asp:GridView ID="grdvw" runat="server" style="margin:0 auto" CssClass="mydatagrid" PagerStyle-CssClass="pager"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" class="table-hover" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            
            <headerstyle backcolor="#4A3C8C"
       ForeColor="#F7F7F7" Font-Bold="True"/>

<PagerStyle CssClass="pager" BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right"></PagerStyle>

<RowStyle CssClass="rows" BackColor="#E7E7FF" ForeColor="#4A3C8C"></RowStyle>
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView></div>

       <asp:Button ID="expexcl" runat="server" Text="export to excel" CssClass="btn btn-success" OnClick="expexcl_Click" />


        </main>
</asp:Content>

