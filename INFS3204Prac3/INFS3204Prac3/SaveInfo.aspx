<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SaveInfo.aspx.cs" Inherits="INFS3204Prac3.SaveInfo" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <br />
  <div class="form-group">
    <label for="name">Store Name</label>
    <asp:TextBox ID="name" runat="server" class="form-control" placeholder="Enter name"></asp:TextBox>
    <asp:RequiredFieldValidator class="alert alert-danger" ControlToValidate="name" Display="Dynamic" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name field is required"></asp:RequiredFieldValidator>
  </div>
  <div class="form-group">
    <label for="branchNO">Store BranchNO</label>
    <asp:TextBox ID="branchNO" runat="server" class="form-control" placeholder="Enter branchNO"></asp:TextBox>
    <asp:RequiredFieldValidator class="text-danger" ControlToValidate="branchNO" Display="Dynamic" runat="server" ErrorMessage="Branch No. field is required"></asp:RequiredFieldValidator>
  <asp:CompareValidator Operator="DataTypeCheck" class="text-danger" ControlToValidate="branchNo" Type="Integer" EnableClientScript="true" Text="Value must be an Integer" runat="server" />
  </div>
  <div class="form-group">
    <label for="phoneNumber">Phone Number</label>
    <asp:TextBox ID="phoneNumber" type="number" runat="server" class="form-control" placeholder="Enter phone Number"></asp:TextBox>
     <asp:CompareValidator Operator="DataTypeCheck" class="text-danger" ControlToValidate="phoneNumber" Type="Integer" EnableClientScript="true" Text="Value must be an Integer" runat="server" />
  </div>
  <div class="form-group">
    <label for="address">Address</label>
    <asp:TextBox ID="address" runat="server" class="form-control" placeholder="Enter address"></asp:TextBox>
  </div>

   <hr />
  <div class="form-group">
    <label for="stockname">Stock Name</label>
    <asp:TextBox ID="stockname" runat="server" class="form-control" placeholder="Enter stockname"></asp:TextBox>
    <asp:RequiredFieldValidator class="text-danger" ControlToValidate="stockname" Display="Dynamic" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Stock name field is required"></asp:RequiredFieldValidator>
  </div>

  <div class="form-group">
<div class="checkbox">
    <label>
      <asp:CheckBox ID="isDiscontinued" runat="server" />
            Is this stock Discontinued
        </label>
    </div>
  </div>

  <div class="form-group">
    <label for="productionDate">Stock Production Date</label>
    <asp:TextBox type="date" ID="productionDate" runat="server" class="form-control" placeholder="Enter productionDate"></asp:TextBox>
  </div>

   <asp:Button OnClick="SubmitBtn_Click" ID="SubmitBtn" runat="server" Text="Submit" CssClass="btn btn-default" />

    <br />
    <br />
    <br />
   <asp:Label ID="Success" runat="server" Text="" CssClass=""></asp:Label>

    <br />
    <br />
    <br />

</asp:Content>
