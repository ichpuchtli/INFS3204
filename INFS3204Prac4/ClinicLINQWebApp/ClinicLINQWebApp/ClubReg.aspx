<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ClubReg.aspx.cs" Inherits="INFS3204Prac4.ClubReg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<br />
<br />

<asp:TextBox ID="Name" runat="server" class="form-control" placeholder="Enter Name"></asp:TextBox>

<br />
<asp:TextBox ID="Founded" type="date" runat="server" class="form-control" placeholder="Enter Date Founded"></asp:TextBox>

<br />
<asp:TextBox ID="WorldRanking" type="number" runat="server" class="form-control" placeholder="Enter World Ranking"></asp:TextBox>
<br />

<hr />

<asp:Button ID="SearchBtn" runat="server" Text="Search" class="btn btn-success" OnClick="SearchBtn_Click" />
<asp:Button ID="SaveBtn" runat="server" Text="Save" class="btn btn-primary" OnClick="SaveBtn_Click" />

<br />
<br />
<br />

<asp:Label ID="Error" runat="server" Text=""></asp:Label>

</asp:Content>