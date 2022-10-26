<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="calander.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <main id="main" class="main">
    
 <div class="row">

        <label> Date From </label>
        <div class="col-sm-6 m-2"  style="display:inline-flex;">
        <asp:TextBox ID="txtDate" runat="server" class="form-control" ></asp:TextBox></div>
     <label> Date To: </label>
     <div class="col-sm-6" style="display:inline-flex;">
     <asp:TextBox ID="txtTo" runat="server" class="form-control"></asp:TextBox></div>

        <hr />
        <div class="col-sm-6">
        <asp:Button ID="btnSubmit" runat="server" Text="Submit"
         OnClick="btnSubmit_Click" style="margin:0 auto; display: block;" CssClass="btn btn-outline-danger" />

        </div>
     <br /><br /><br /><hr />
      <asp:GridView ID="grddate" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
          <AlternatingRowStyle BackColor="White" />
          <FooterStyle BackColor="#CCCC99" />
          <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
          <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
          <RowStyle BackColor="#F7F7DE" />
          <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
          <SortedAscendingCellStyle BackColor="#FBFBF2" />
          <SortedAscendingHeaderStyle BackColor="#848384" />
          <SortedDescendingCellStyle BackColor="#EAEAD3" />
          <SortedDescendingHeaderStyle BackColor="#575357" />

            </asp:GridView>
 </div>



    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.6/jquery.min.js" type="text/javascript"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/jquery-ui.min.js" type="text/javascript"></script>
<link href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8/themes/base/jquery-ui.css" rel="Stylesheet" type="text/css" />
<script type="text/javascript">
    $(function () {
        $("[id*=txtDate]").datepicker({
            showOn: 'button',
            buttonImageOnly: true,
            buttonImage: 'assets/img/calender.png'
        });

        $("[id*=txtTo]").datepicker({
            showOn: 'button',
            buttonImageOnly: true,
            buttonImage: 'assets/img/calender.png'
        });
    });
</script>
       
        </main>

</asp:Content>

