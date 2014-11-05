<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="PlayerReg.aspx.cs" Inherits="INFS3204Prac4.PlayerReg" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

<br />
<br />

<asp:TextBox ID="FirstName" runat="server" class="form-control" placeholder="Enter Firstname"></asp:TextBox>

<br />
<asp:TextBox ID="LastName" runat="server" class="form-control" placeholder="Enter Lastname"></asp:TextBox>
<br />

<asp:TextBox ID="PhoneNumber" type="number" runat="server" class="form-control" placeholder="Enter Phone Number (Optional)"></asp:TextBox>

<br />
<asp:TextBox ID="Address" runat="server" class="form-control" placeholder="Enter Address"></asp:TextBox>
   
<br />
<asp:TextBox ID="DateOfBirth" type="date" runat="server" class="form-control" placeholder="Enter Date of Birth"></asp:TextBox>


<hr />

<asp:Button ID="SearchBtn" runat="server" Text="Search" class="btn btn-success" OnClick="SearchBtn_Click" />
<asp:Button ID="SaveBtn" runat="server" class="btn btn-primary" Text="Save" OnClick="SaveBtn_Click" />

<br />
<br />
<br />

<asp:Label ID="Error" runat="server" Text=""></asp:Label>

</asp:Content>
