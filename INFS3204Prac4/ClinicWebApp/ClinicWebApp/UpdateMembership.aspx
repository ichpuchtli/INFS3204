<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateMembership.aspx.cs" Inherits="INFS3204Prac4.UpdateMembership" %>

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
<br />
<asp:TextBox ID="EndDate" type="date" runat="server" class="form-control" placeholder="Enter End Date"></asp:TextBox>
<br />
<asp:TextBox ID="NumOfGames" type="number" runat="server" class="form-control" placeholder="Enter Num of Games Played"></asp:TextBox>

<hr />

<asp:Button ID="SearchBtn" runat="server" Text="Search" class="btn btn-success" OnClick="SearchBtn_Click" />
<asp:Button ID="UpdateBtn" runat="server" Text="Update" class="btn btn-primary" OnClick="UpdateBtn_Click" />

<br />
<br />
<br />
<asp:Label ID="Error" runat="server" Text=""></asp:Label>

</asp:Content>
