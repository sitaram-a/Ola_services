<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exp.aspx.cs" Inherits="exp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <asp:Button ID="btnshow" runat="server" Text="Show Data" OnClick="btnshow_Click" />
        <asp:Button ID="btnexp" runat="server" Text="Export to Excel" OnClick="btnexp_Click" />

        <hr />

        <asp:GridView ID="grdv" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" OnSelectedIndexChanged="grdv_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        
        <Columns>
           
            <asp:TemplateField HeaderText="Select Rows"> 
            <ItemTemplate>
                         <asp:CheckBox ID="chk" runat="server" />
            </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Remarks"> 
            <ItemTemplate>
                         <asp:TextBox ID="txtrmk" runat="server"></asp:TextBox>
            </ItemTemplate>
            </asp:TemplateField>


        </Columns>
        
        
        
        
        </asp:GridView>

        <asp:Button ID="btngrd" runat="server" Text="Export to Excel from grid" OnClick="btngrd_Click" />
        <asp:Button ID="btnins" runat="server" Text="insert to sql table" />
    </div>
    </form>
</body>
</html>
