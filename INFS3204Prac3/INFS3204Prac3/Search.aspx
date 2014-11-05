<%@ Page Title="Search" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="INFS3204Prac3.Search" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

<br />
<br />
<div class="row">
    <div class="col-xs-8 form-group">
        <asp:TextBox ID="name" runat="server" class="form-control" placeholder="Enter Keywords"></asp:TextBox>
    </div>
    <div class="col-xs-4 form-group">
        <asp:Button OnClick="SearchBtn_Click" ID="SearchBtn" runat="server" Text="Search" CssClass="btn btn-block btn-primary" />
    </div>
</div>

    <br />
<asp:Label ID="Error" runat="server" Text=""></asp:Label>

<asp:Table ID="Table1" runat="server" CssClass="table table-bordered table-hover"></asp:Table>

</asp:Content>