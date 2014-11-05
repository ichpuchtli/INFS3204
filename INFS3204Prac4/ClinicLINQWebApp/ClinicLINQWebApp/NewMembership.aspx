<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewMembership.aspx.cs" Inherits="INFS3204Prac4.NewMembership" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<br />
<br />

<asp:TextBox ID="FirstName" runat="server" class="form-control" placeholder="Enter Firstname"></asp:TextBox>
<br />
<asp:TextBox ID="LastName" runat="server" class="form-control" placeholder="Enter Lastname"></asp:TextBox>
<br />
<asp:TextBox ID="ClubName" runat="server" class="form-control" placeholder="Enter Club Name"></asp:TextBox>
<br />
<asp:TextBox ID="StartDate" type="date" runat="server" class="form-control" placeholder="Enter Start Date"></asp:TextBox>

<hr />

<asp:Button ID="SaveBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="SaveBtn_Click" />

<br />
<br />
<br />
<asp:Label ID="Error" runat="server" Text=""></asp:Label>

</asp:Content>
