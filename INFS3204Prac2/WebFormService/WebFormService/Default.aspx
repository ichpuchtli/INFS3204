<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormService._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <br />

    <a href="/WebService1.asmx" class="btn btn-primary btn-lg">WebService1</a>
    <a href="/WebService3.asmx" class="btn btn-success btn-lg">WebService2</a>
    <a href="/WebService2.asmx" class="btn btn-danger btn-lg">WebService3</a>

    <a href="/Task2.aspx" class="btn btn-info btn-lg">Task 2</a>
    <a href="/Task3.aspx" class="btn btn-warning btn-lg">Task 3</a>

    <a href="/json_db.txt" class="btn btn-default btn-lg"><span class="glyphicon glyphicon-file"></span> Database File</a>

</asp:Content>
