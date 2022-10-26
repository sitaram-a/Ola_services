<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="frmVehi.aspx.cs" Inherits="frmVehi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
     <main id="main" class="main">
    <div class="row">
    
      <div class="alert alert-success">
         <h3>REQUIREMENT FORM AS PER CUSTOMER.</h3>
        
         <h4>AMOUNT MAY VARY*</h4> </div>
    
        <div class="form-group">
            <label>Vehicle No: </label>
            <asp:TextBox ID="txtVehiNo" runat="server" class="form-control" placeholder="Auto Generated" ReadOnly ="true"></asp:TextBox>
        </div>

    <div class="form-group">
        <label> Model </label>
        <asp:TextBox ID="txtModel" runat="server" class="form-control" placeholder="Enter Model"></asp:TextBox>
    </div>
    
    <div class="form-group">
        <label> 1st Brand: </label>
        <asp:DropDownList ID="txtBrand1" runat="server" class="form-control" placeholder="Select 1st Brand"></asp:DropDownList>
    </div>
     
    <div class="form-group">
        <label> 2nd Brand: </label>
        <asp:DropDownList ID="txtBrand2" runat="server" class="form-control" placeholder="Select 2nd Brand"></asp:DropDownList>
    </div>

    <div class="form-group">
        <label> Engine Type: </label>
        <asp:DropDownList ID="txtEngineType" runat="server" class="form-control" placeholder="Engine Type"></asp:DropDownList>
    </div>



    <div class="form-group">
    <label> No. Of Person: </label>
    <asp:DropDownList ID="txtPerson" runat="server" class="form-control">
    <asp:ListItem> ONE </asp:ListItem>
    <asp:ListItem> TWO </asp:ListItem>
    <asp:ListItem> THREE </asp:ListItem>
    <asp:ListItem> FOUR </asp:ListItem>
    <asp:ListItem> FIVE </asp:ListItem>
    </asp:DropDownList>
    </div>
     
    <div class="form-group">
        <label> Amount: </label>
        <asp:TextBox ID="txtAmount" runat="server" class="form-control" placeholder="Approx Amount"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Quantity:</label>
        <asp:TextBox ID="txtqty" runat="server" class="form-control" placeholder="Quantity"></asp:TextBox>
    </div>
    
        <br /><a href="List_BikeCar.aspx">OPEN LIST</a>

    <hr /><br />
    <asp:Button ID="btnsave" runat="server" Text="SAVE" onclick="btnsave_Click"/>
    <br />
    <asp:Label ID="lblmsg" runat="server">...........</asp:Label>
     <hr />
    
      </div>
    </main>


</asp:Content>

