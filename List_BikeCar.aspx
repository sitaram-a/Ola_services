<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="List_BikeCar.aspx.cs" Inherits="List_Vehi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div class="row">
    <div class="col-sm-4"></div> 

      <div class="col-sm-8"> <br /><br /><br /><br />
      <div class="alert alert-warning">
      <h3>LIST OF BIKE AND CAR MODELS</h3> </div>
    
      <div class="alert alert-info">
      <asp:TextBox ID="txtsrch" runat="server"></asp:TextBox>
      <asp:Button ID="btnsrch" runat="server" Text="SEARCH" onclick="btnsrch_Click"/><br /><br /><hr /></div>
   
    <div class="alert alert-success">
    <asp:GridView ID="grdBicar" runat="server" onrowcommand="grdBicar_RowCommand">
    <Columns>
    <asp:ButtonField Text="Delete" CommandName="del" />
    <asp:ButtonField Text="Edit" CommandName="edt" />
    
    </Columns>
    </asp:GridView> </div>
    <hr />
    <a href="frmVehi.aspx">OPEN FORM</a>
     
      </div>
      </div>

</asp:Content>

